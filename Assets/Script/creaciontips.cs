using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class creaciontips : MonoBehaviour
{

    public float raycastDistance = 100f;
    [SerializeField] private LeanTweenType tipoAnimacion;
    [SerializeField] private GameObject BotonCrear;
    [SerializeField] private GameObject InformacionCrearla;
    [SerializeField] private GameObject[] prefabItems;
    [SerializeField] private Button[] botonesCrear;

    private rotacion objectController; // Referencia a rotacion.cs

    void Start()
    {
        objectController = FindObjectOfType<rotacion>(); // Conectar con el script rotacion.cs

        for (int i = 0; i < botonesCrear.Length; i++)
        {
            int index = i;
            botonesCrear[i].onClick.AddListener(() => CrearObjeto(index));
        }
    }

    // ? Método para crear un objeto de la lista y enviarlo a rotacion.cs
    public void CrearObjeto(int index)
    {
        if (index < 0 || index >= prefabItems.Length) return;

        GameObject objetoCreado = Instantiate(prefabItems[index], Vector3.zero, Quaternion.identity);
        objetoCreado.SetActive(true);

        // ? Enviar el objeto a rotacion.cs para que pueda moverse y rotarse antes de colocarse
        if (objectController != null)
        {
            objectController.AsignarObjetoSeleccionado(objetoCreado);
        }
        else
        {
            Debug.LogError("? ERROR: No se encontró el script 'rotacion.cs' en la escena.");
        }

        // ? Ocultar la lista de creación y desactivar el botón de crear
        if (InformacionCrearla != null) InformacionCrearla.SetActive(false);
        if (BotonCrear != null) BotonCrear.SetActive(false);
    }
}