using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class rotacion : MonoBehaviour
{

    [SerializeField] private GameObject circuloIndicador; // 🔥 Referencia al círculo
    [SerializeField] private float escalaBase = 1.5f; // 🔥 Tamaño base del círculo
    [SerializeField] private float escalaVariacion = 0.3f; // 🔥 Cuánto cambia de tamaño al animarse
    [SerializeField] private float velocidadAnimacion = 2f; // 🔥 Velocidad de la animación
    private bool circuloActivo = false; // 🔥 Controla si el círculo está visible

    // 🔥 Tipo de animación usada con LeanTween
    [SerializeField] private LeanTweenType tipoAnimacion;

    // 🔥 Velocidades de movimiento y rotación del objeto seleccionado
    public float movementSpeed = 20f;
    public float rotationSpeed = 3000f;

    // 🔥 Distancia máxima del Raycast para detectar objetos
    public float raycastDistance = 1000f;

    // 🔥 Estados para manejar las acciones del objeto seleccionado
    private bool isPlacing = false;  // Indica si se está colocando un objeto nuevo
    private bool isMoving = false;   // Indica si se está moviendo un objeto ya colocado
    private bool isRotating = false; // Indica si se está rotando el objeto
    private bool isScaling = false;  // Indica si se está escalando el objeto

    // 🔥 Máscara de colisión para detectar el suelo
    private LayerMask sueloMask;

    // 🔥 Referencias a los botones de la UI
    [SerializeField] private Button botonEliminar; // Botón para eliminar el objeto seleccionado
    [SerializeField] private Button botonEscalar;  // Botón para activar el modo de escalado
    [SerializeField] private Button botonMover;    // Botón para activar el modo de mover
    [SerializeField] private Button botonRotar;    // Botón para activar el modo de rotación

    // 🔥 Parámetros de escalado
    [SerializeField] private float scaleSpeed = 0.1f; // Velocidad de escalado
    [SerializeField] private float minScale = 1f;    // Tamaño mínimo del objeto
    [SerializeField] private float maxScale = 20f;   // Tamaño máximo del objeto

    // 🔥 Parámetros para la animación de eliminación
    [SerializeField] private float tiempoDestruir = 0.5f; // Tiempo de la animación de eliminación

    // 🔥 Referencia al objeto del suelo en la escena
    [SerializeField] private GameObject suelo;

    // 🔥 Referencia al objeto actualmente seleccionado en la escena
    [Header("📌 Objeto Seleccionado")]
    [SerializeField] private GameObject selectedObject; // Objeto que el usuario ha seleccionado
    private Rigidbody selectedRigidbody; // Referencia al Rigidbody del objeto seleccionado

    void Start()
    {
        // 🔥 Si se asignó el objeto "suelo", obtiene su capa para usarla en los raycasts
        if (suelo != null)
        {
            sueloMask = 1 << suelo.layer;
        }

        // 🔥 Asignar los métodos a los botones de la UI
        if (botonMover != null)
        {
            botonMover.onClick.AddListener(ActivarModoMover);
        }
        if (botonRotar != null)
        {
            botonRotar.onClick.AddListener(ActivarModoRotar);
        }
        if (botonEliminar != null)
        {
            botonEliminar.onClick.AddListener(EliminarObjetoSeleccionado);
        }
        if (botonEscalar != null)
        {
            botonEscalar.onClick.AddListener(ActivarModoEscalar);
        }
    }

    void Update()
    {
        if (selectedObject != null)
        {
            // 🔥 Mueve el círculo debajo del objeto seleccionado o creado
            circuloIndicador.transform.position = new Vector3(selectedObject.transform.position.x, 0.01f, selectedObject.transform.position.z);

            if (!circuloActivo)
            {
                circuloIndicador.SetActive(true); // 🔥 Activa el círculo si no está visible
                circuloActivo = true;
            }

            // 🔥 Aplicar animación de escala
            float escalaAnimada = escalaBase + Mathf.Sin(Time.time * velocidadAnimacion) * escalaVariacion;
            circuloIndicador.transform.localScale = new Vector3(escalaAnimada, 0.05f, escalaAnimada);
        }
        else if (circuloActivo)
        {
            // 🔥 Desactivar el círculo si no hay objeto seleccionado
            circuloIndicador.SetActive(false);
            circuloActivo = false;
        }



        /*

        if (isPlacing && selectedObject != null)
        {
            // 🔥 Mueve el círculo debajo del objeto en tiempo real
            circuloIndicador.transform.position = new Vector3(selectedObject.transform.position.x, 0.01f, selectedObject.transform.position.z);

            if (!circuloActivo)
            {
                circuloIndicador.SetActive(true); // 🔥 Activa el círculo si no está visible
                circuloActivo = true;
            }

            // 🔥 Aplicar animación de escala
            float escalaAnimada = escalaBase + Mathf.Sin(Time.time * velocidadAnimacion) * escalaVariacion;
            circuloIndicador.transform.localScale = new Vector3(escalaAnimada, 0.05f, escalaAnimada);
        }
        else if (!isPlacing && circuloActivo)
        {
            // 🔥 Desactivar el círculo cuando se coloca el objeto
            circuloIndicador.SetActive(false);
            circuloActivo = false;
        }
        */

        // 🔥 Permite seleccionar un objeto con un clic si no se está moviendo o colocando
        if (Input.GetMouseButtonDown(0) && !isPlacing && !isMoving)
        {
            SeleccionarObjeto();
        }

        // 🔥 Si no hay un objeto seleccionado, salir del método
        if (selectedObject == null) return;

        // 🔥 Si el objeto está en modo colocación o movimiento, permitir moverlo y rotarlo
        if (isPlacing || isMoving)
        {
            bool canMove = MoverConMouse();
            RotarConMouse();

            if (Input.GetMouseButtonDown(0) && canMove)
            {
                isPlacing = false;
                isMoving = false;
                AplicarAnimacionFinal();
            }
        }

        // 🔥 Manejo del modo rotación
        if (isPlacing || isMoving || isRotating)
        {
            bool canMove = MoverConMouse();

            if (isRotating)
            {
                RotarConMouse();
            }

            if (Input.GetMouseButtonDown(0) && canMove)
            {
                isPlacing = false;
                isMoving = false;
                isRotating = false;
                AplicarAnimacionFinal();
            }
        }

        // 🔥 Manejo del modo escalado
        if (isPlacing || isMoving || isRotating || isScaling)
        {
            bool canMove = MoverConMouse();

            if (isRotating)
            {
                RotarConMouse();
            }

            if (isScaling)
            {
                EscalarConMouse();
            }

            if (Input.GetMouseButtonDown(0) && canMove)
            {
                isPlacing = false;
                isMoving = false;
                isRotating = false;
                isScaling = false;
                AplicarAnimacionFinal();
            }
        }
    }

    // ✅ Método para seleccionar un objeto en la escena con un Raycast
    public void SeleccionarObjeto()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            selectedObject = hit.collider.gameObject;

            if (!selectedObject.TryGetComponent<Rigidbody>(out selectedRigidbody))
            {
                selectedRigidbody = selectedObject.AddComponent<Rigidbody>();
            }

            selectedRigidbody.isKinematic = false;
            selectedRigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;

            // 🔥 Activa el círculo al seleccionar un objeto
            circuloIndicador.SetActive(true);
            circuloActivo = true;
        }
    }
    public void AsignarObjetoSeleccionado(GameObject nuevoObjeto)
    {
        selectedObject = nuevoObjeto;

        // 🔥 Solo agregar Rigidbody si no tiene uno
        if (!selectedObject.TryGetComponent<Rigidbody>(out selectedRigidbody))
        {
            selectedRigidbody = selectedObject.AddComponent<Rigidbody>();
        }

        selectedRigidbody.isKinematic = false;
        selectedRigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;

        isPlacing = true; // Activa el modo de colocación y movimiento
    }
    // ✅ Método para mover el objeto con el ratón
    private bool MoverConMouse()
    {
        if (selectedObject == null) return false;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance, sueloMask))
        {
            selectedRigidbody.MovePosition(hit.point);
            return true;
        }
        return false;
    }

    // ✅ Método para rotar el objeto con la rueda del ratón
    private void RotarConMouse()
    {
        if (selectedObject == null || !isRotating) return;

        float scroll = Input.mouseScrollDelta.y;
        if (scroll != 0 && selectedRigidbody != null)
        {
            Quaternion newRotation = Quaternion.Euler(0, scroll * rotationSpeed * Time.deltaTime, 0);
            selectedRigidbody.MoveRotation(selectedRigidbody.rotation * newRotation);
        }
    }

    // ✅ Aplica una animación de rotación final cuando el objeto es colocado
    private void AplicarAnimacionFinal()
    {
        if (selectedObject != null)
        {
            LeanTween.rotateAround(selectedObject, Vector3.up, 360, 0.5f).setEase(tipoAnimacion);
        }
    }

    // ✅ Activa el modo mover
    public void ActivarModoMover()
    {
        if (selectedObject != null)
        {
            isMoving = true;
        }
    }



    // ✅ Activa el modo de rotación
    public void ActivarModoRotar()
    {
        if (selectedObject != null)
        {
            isRotating = true;
        }
    }

    // ✅ Elimina el objeto seleccionado con una animación de reducción
    public void EliminarObjetoSeleccionado()
    {
        if (selectedObject != null)
        {
            // ✅ Evitar eliminar el suelo
            if (selectedObject == suelo)
            {
                Debug.Log("⚠️ No puedes eliminar el suelo.");
                return;
            }

            // ✅ Evitar eliminar objetos de la capa "Pared"
            if (selectedObject.layer == LayerMask.NameToLayer("Pared"))
            {
                Debug.Log("⚠️ No puedes eliminar una pared.");
                return;
            }

            // 🔥 Animación de eliminación antes de destruir
            LeanTween.scale(selectedObject, Vector3.zero, tiempoDestruir)
                .setEase(LeanTweenType.easeInBack)
                .setOnComplete(() =>
                {
                    Destroy(selectedObject);
                    selectedObject = null;
                });
        }
    }



    // ✅ Escala el objeto con la rueda del ratón
    private void EscalarConMouse()
    {
        if (selectedObject == null || !isScaling) return;

        float scroll = Input.mouseScrollDelta.y;
        if (scroll != 0)
        {
            Vector3 newScale = selectedObject.transform.localScale + Vector3.one * scroll * scaleSpeed;

            newScale = new Vector3(
                Mathf.Clamp(newScale.x, minScale, maxScale),
                Mathf.Clamp(newScale.y, minScale, maxScale),
                Mathf.Clamp(newScale.z, minScale, maxScale)
            );

            selectedObject.transform.localScale = newScale;
        }
    }
    // si quisiera hacerlo con el raton lo de escalar
    /*
    private void EscalarConMouse()
    {
        if (selectedObject == null || !isScaling) return;

        // 🔥 Detectar el movimiento del mouse en la dirección Y (vertical)
        float mouseDeltaY = Input.GetAxis("Mouse Y");

        if (mouseDeltaY != 0)
        {
            // 🔥 Aumentar o reducir la escala según la dirección del mouse
            Vector3 newScale = selectedObject.transform.localScale + Vector3.one * mouseDeltaY * scaleSpeed;

            // 🔽 Mantener la escala dentro de los límites
            newScale = new Vector3(
                Mathf.Clamp(newScale.x, minScale, maxScale),
                Mathf.Clamp(newScale.y, minScale, maxScale),
                Mathf.Clamp(newScale.z, minScale, maxScale)
            );

            selectedObject.transform.localScale = newScale;
        }
    }

    */




    // ✅ Activa el modo de escalado
    public void ActivarModoEscalar()
    {
        if (selectedObject != null)
        {
            isScaling = true;
        }
    }
}
