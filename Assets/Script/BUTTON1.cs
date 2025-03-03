using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BUTTON1 : MonoBehaviour
{
    [SerializeField] private GameObject BotonCrear;
    [SerializeField] private GameObject InformacionCrear;
    [SerializeField] private GameObject InformacionCrearla;

    private rotacion objectController;
    private bool objetoColocado = false;

    void Start()
    {
        objectController = FindObjectOfType<rotacion>();
        CheckReferences();

        // Asegurar que la lista de creación está desactivada al iniciar
        if (InformacionCrearla != null) InformacionCrearla.SetActive(false);
    }

    private void CheckReferences()
    {
        if (BotonCrear == null) Debug.LogError("? Falta asignar 'BotonCrear'", this);
        if (InformacionCrear == null) Debug.LogError("? Falta asignar 'InformacionCrear'", this);
        if (InformacionCrearla == null) Debug.LogError("? Falta asignar 'InformacionCrearla'", this);
    }

    // ? Mostrar la lista de objetos al presionar "Crear"
    public void ClickEnBotonCrear()
    {
        if (InformacionCrear != null) InformacionCrear.SetActive(false);
        if (InformacionCrearla != null) InformacionCrearla.SetActive(true);
        objetoColocado = false;
    }

    // ? Ocultar la lista de creación cuando se coloca un objeto
    public void ObjetoColocado()
    {
        if (!objetoColocado)
        {
            if (InformacionCrearla != null) InformacionCrearla.SetActive(false);
            objetoColocado = true;
        }
    }
}