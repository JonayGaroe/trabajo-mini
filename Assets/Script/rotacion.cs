using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class rotacion : MonoBehaviour
{
    [SerializeField] private LeanTweenType tipoAnimacion;
    public float movementSpeed = 20f;
    public float rotationSpeed = 3000f;
    public float raycastDistance = 1000f;
    private bool isPlacing = false;
    private GameObject selectedObject;
    private Rigidbody selectedRigidbody;
    private LayerMask sueloMask;

    [SerializeField] private GameObject suelo;

    void Start()
    {
        if (suelo != null)
        {
            sueloMask = 1 << suelo.layer;
        }
    }

    void Update()
    {
        if (selectedObject == null || !isPlacing) return;

        if (MoverConMouse() && Input.GetMouseButtonDown(0))
        {
            isPlacing = false;
            AplicarAnimacionFinal();
            selectedObject = null;
            selectedRigidbody = null;
        }

        RotarConMouse();
    }

    public void SeleccionarObjeto(GameObject objeto)
    {
        selectedObject = objeto;
        isPlacing = true;
        selectedObject.SetActive(true);

        // 🔥 Asegurar que el objeto tiene un Rigidbody
        if (!selectedObject.TryGetComponent<Rigidbody>(out selectedRigidbody))
        {
            selectedRigidbody = selectedObject.AddComponent<Rigidbody>();
        }

        selectedRigidbody.isKinematic = false; // 🔥 Habilita detección de colisión
        selectedRigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous; // 🔥 Evita atravesar objetos rápidos
    }

    private bool MoverConMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance, sueloMask))
        {
            Vector3 newPosition = hit.point;

            // 🔥 Movimiento con Rigidbody respetando colisiones
            selectedRigidbody.MovePosition(newPosition);
            return true;
        }
        return false;
    }

    private void RotarConMouse()
    {
        float scroll = Input.mouseScrollDelta.y;
        if (scroll != 0 && selectedRigidbody != null)
        {
            Quaternion newRotation = Quaternion.Euler(0, scroll * rotationSpeed * Time.deltaTime, 0);
            selectedRigidbody.MoveRotation(selectedRigidbody.rotation * newRotation); // 🔥 Evita atravesar paredes
        }
    }

    private void AplicarAnimacionFinal()
    {
        LeanTween.rotateAround(selectedObject, Vector3.up, 360, 0.5f).setEase(tipoAnimacion);
    }
}
