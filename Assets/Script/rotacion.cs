using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class rotacion : MonoBehaviour
{
    [SerializeField] private LeanTweenType tipoAnimacion;
    public float movementSpeed = 20f;
    public float rotationSpeed = 3000f;
    public float raycastDistance = 1000f;

    private bool isPlacing = false;
    private bool isMoving = false; // 🔥 Nuevo estado para mover objetos colocados
    private LayerMask sueloMask;

    [SerializeField] private Button botonEliminar; // 🔥 Botón para eliminar el objeto
    [SerializeField] private float tiempoDestruir = 0.5f; // ⏳ Tiempo de la animación de reducción


    [SerializeField] private Button botonEscalar; // 🔥 Botón para escalar el objeto
    [SerializeField] private float scaleSpeed = 0.1f; // 📏 Velocidad de escalado
    [SerializeField] private float minScale = 1f; // 🔽 Tamaño mínimo
    [SerializeField] private float maxScale = 20f; // 🔼 Tamaño máximo

    private bool isScaling = false; // 🔥 Estado para saber si estamos escalando


    [SerializeField] private GameObject suelo;
    [SerializeField] private Button botonMover; // 🔥 Botón para activar el modo mover

    [SerializeField] private Button botonRotar; // 🔥 Botón de rotación
    private bool isRotating = false; // 🔥 Estado de rotación activado/desactivado


    [Header("📌 Objeto Seleccionado")]
    [SerializeField] private GameObject selectedObject; // 🔥 Se muestra en el Inspector
    private Rigidbody selectedRigidbody;

    void Start()
    {
        if (suelo != null)
        {
            sueloMask = 1 << suelo.layer;
        }

        // 🔥 Asignar función al botón de mover
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
        // 🔥 Permite seleccionar un objeto con un clic
        if (Input.GetMouseButtonDown(0) && !isPlacing && !isMoving)
        {
            SeleccionarObjeto();
        }

        if (selectedObject == null) return;

        if (isPlacing || isMoving)
        {
            bool canMove = MoverConMouse();
            RotarConMouse();

            if (Input.GetMouseButtonDown(0) && canMove)
            {
                isPlacing = false;
                isMoving = false; // 🔥 Desactiva el modo mover al hacer clic
                AplicarAnimacionFinal();
            }
        }
        if (selectedObject == null) return;

        if (isPlacing || isMoving || isRotating)
        {
            bool canMove = MoverConMouse();

            if (isRotating)
            {
                RotarConMouse(); // 🔥 Solo rota si el modo está activado
            }

            if (Input.GetMouseButtonDown(0) && canMove)
            {
                isPlacing = false;
                isMoving = false;
                isRotating = false; // 🔥 Se desactiva el modo rotación
                AplicarAnimacionFinal();
            }
        }

        if (selectedObject == null) return;

        if (isPlacing || isMoving || isRotating || isScaling)
        {
            bool canMove = MoverConMouse();

            if (isRotating)
            {
                RotarConMouse();
            }

            if (isScaling)
            {
                EscalarConMouse(); // 🔥 Solo escala si el modo está activado
            }

            if (Input.GetMouseButtonDown(0) && canMove)
            {
                isPlacing = false;
                isMoving = false;
                isRotating = false;
                isScaling = false; // 🔥 Se desactiva el modo de escala al hacer clic
                AplicarAnimacionFinal();
            }
        }


    }

    // ✅ Método para seleccionar un objeto en la escena
    public void SeleccionarObjeto()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // 🔥 Si el objeto ya tenía Rigidbody, lo usa, si no, lo agrega
            selectedObject = hit.collider.gameObject;
            if (!selectedObject.TryGetComponent<Rigidbody>(out selectedRigidbody))
            {
                selectedRigidbody = selectedObject.AddComponent<Rigidbody>();
            }

            selectedRigidbody.isKinematic = false;
            selectedRigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
    }

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
    private void AplicarAnimacionFinal()
    {
        if (selectedObject != null)
        {
            LeanTween.rotateAround(selectedObject, Vector3.up, 360, 0.5f).setEase(tipoAnimacion);
        }
    }

    // ✅ Activar el modo de mover un objeto ya colocado
    public void ActivarModoMover()
    {
        if (selectedObject != null)
        {
            isMoving = true; // 🔥 Ahora podemos moverlo con el ratón
        }
    }
    public void AsignarObjetoSeleccionado(GameObject nuevoObjeto)
    {
        selectedObject = nuevoObjeto;

        if (!selectedObject.TryGetComponent<Rigidbody>(out selectedRigidbody))
        {
            selectedRigidbody = selectedObject.AddComponent<Rigidbody>();
        }

        selectedRigidbody.isKinematic = false;
        selectedRigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;

        isPlacing = true; // Activa el modo de colocación y movimiento
    }

    public void ActivarModoRotar()
    {
        if (selectedObject != null)
        {
            isRotating = true; // 🔥 Activa el modo de rotación
        }
    }

    public void EliminarObjetoSeleccionado()
    {
        if (selectedObject != null)
        {
            // 🔥 Animación de reducción con LeanTween
            LeanTween.scale(selectedObject, Vector3.zero, tiempoDestruir)
                .setEase(LeanTweenType.easeInBack)
                .setOnComplete(() =>
                {
                    Destroy(selectedObject); // 💥 Destruye el objeto cuando termina la animación
                    selectedObject = null; // ⚠️ Resetea la selección
                });
        }
    }
    private void EscalarConMouse()
    {
        if (selectedObject == null || !isScaling) return;

        float scroll = Input.mouseScrollDelta.y;
        if (scroll != 0)
        {
            Vector3 newScale = selectedObject.transform.localScale + Vector3.one * scroll * scaleSpeed;

            // 🔽 Asegurar que el tamaño se mantiene dentro de los límites
            newScale = new Vector3(
                Mathf.Clamp(newScale.x, minScale, maxScale),
                Mathf.Clamp(newScale.y, minScale, maxScale),
                Mathf.Clamp(newScale.z, minScale, maxScale)
            );

            selectedObject.transform.localScale = newScale;
        }
    }
    public void ActivarModoEscalar()
    {
        if (selectedObject != null)
        {
            isScaling = true; // 🔥 Activa el modo de escalado
        }
    }



}