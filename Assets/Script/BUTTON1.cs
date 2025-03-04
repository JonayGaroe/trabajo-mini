using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BUTTON1 : MonoBehaviour
{
    // ?? Referencias a los elementos de la UI
    [SerializeField] private GameObject BotonCrear;       // Botón que inicia la creación de objetos
    [SerializeField] private GameObject InformacionCrear; // Panel de información inicial antes de crear
    [SerializeField] private GameObject InformacionCrearla; // Panel con la lista de objetos a crear
    [SerializeField] private GameObject InformacionbotonCrear;    // //  Activa la información de Crear


    // ?? Referencia al script de rotación (rotacion.cs) para gestionar los objetos creados

    // ?? Estado que indica si un objeto ha sido colocado en la escena
    private bool objetoColocado = false;

    void Start()
    {
    
        // ?? Comprobar si todas las referencias necesarias están asignadas en el Inspector
        CheckReferences();

        // ?? Asegurar que la lista de creación de objetos esté oculta al iniciar la escena
        if (InformacionCrearla != null) InformacionCrearla.SetActive(false);
    }

    // ? Método para verificar que los elementos de la UI están correctamente asignados
    private void CheckReferences()
    {
        if (BotonCrear == null) Debug.LogError("?? Falta asignar 'BotonCrear'", this);
        if (InformacionCrear == null) Debug.LogError("?? Falta asignar 'InformacionCrear'", this);
        if (InformacionCrearla == null) Debug.LogError("?? Falta asignar 'InformacionCrearla'", this);
    }

    // ? Método que se ejecuta cuando el usuario presiona el botón "Crear"
    // Muestra la lista de objetos disponibles para crear
    public void ClickEnBotonCrear()
    {
        InformacionbotonCrear.SetActive(true);
        if (InformacionCrear != null) InformacionCrear.SetActive(false); // ?? Oculta el panel de información inicial
        if (InformacionCrearla != null) InformacionCrearla.SetActive(true); // ?? Muestra la lista de objetos
        objetoColocado = false; // ?? Resetea el estado del objeto para permitir nuevas creaciones
    }

    // ? Método que se llama cuando un objeto es colocado en la escena
    // Oculta la lista de creación para evitar que el usuario siga creando sin control
    public void ObjetoColocado()
    {
        if (!objetoColocado) // ?? Solo ejecuta la acción si no se ha colocado un objeto antes
        {
            if (InformacionCrearla != null) InformacionCrearla.SetActive(false); // ?? Oculta la lista de objetos
            objetoColocado = true; // ?? Marca que un objeto ya ha sido colocado
            InformacionbotonCrear.SetActive(false);
        }
    }
}