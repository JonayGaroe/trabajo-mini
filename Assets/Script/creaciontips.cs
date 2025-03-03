using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class creaciontips : MonoBehaviour
{

    // ?? Distancia m�xima para detectar objetos con Raycast (actualmente no se usa en este script)
    public float raycastDistance = 100f;

    // ?? Tipo de animaci�n de LeanTween que se aplicar� a los objetos
    [SerializeField] private LeanTweenType tipoAnimacion;

    // ?? Referencias a la interfaz de usuario (UI)
    [SerializeField] private GameObject BotonCrear; // Bot�n para activar la creaci�n de objetos
    [SerializeField] private GameObject InformacionCrearla; // Panel con la lista de objetos a crear

    // ?? Array de prefabs que pueden ser creados en la escena
    [SerializeField] private GameObject[] prefabItems;

    // ?? Array de botones en la UI que permiten seleccionar y crear objetos espec�ficos
    [SerializeField] private Button[] botonesCrear;

    // ?? Referencia al script "rotacion.cs" para manejar el objeto reci�n creado
    private rotacion objectController;

    void Start()
    {
        // ?? Busca autom�ticamente el script "rotacion.cs" en la escena y lo asigna
        objectController = FindObjectOfType<rotacion>();

        // ?? Si no encuentra "rotacion.cs", muestra un error en la consola y detiene la ejecuci�n
        if (objectController == null)
        {
            Debug.LogError("? No se encontr� el script 'rotacion.cs' en la escena.");
            return;
        }

        // ?? Asigna la funci�n `CrearObjeto(index)` a cada bot�n de la lista `botonesCrear`
        for (int i = 0; i < botonesCrear.Length; i++)
        {
            int index = i; // Se almacena en una variable para evitar problemas con lambdas
            botonesCrear[i].onClick.AddListener(() => CrearObjeto(index)); // ?? Asigna un evento al bot�n
        }
    }

    // ? M�todo para crear un objeto seleccionado de la lista y enviarlo a "rotacion.cs"
    public void CrearObjeto(int index)
    {
        // ?? Si el �ndice es inv�lido (fuera del rango del array), no hacer nada y salir del m�todo
        if (index < 0 || index >= prefabItems.Length) return;

        // ?? Instancia el objeto seleccionado en la posici�n (0,0,0) con rotaci�n por defecto
        GameObject objetoCreado = Instantiate(prefabItems[index], Vector3.zero, Quaternion.identity);
        objetoCreado.SetActive(true); // ?? Asegurar que el objeto est� visible en la escena

        // ?? Asegurar que el objeto NO tenga el script "rotacion.cs" antes de asignarlo
        if (objetoCreado.GetComponent<rotacion>() != null)
        {
            Destroy(objetoCreado.GetComponent<rotacion>()); // ?? Elimina el script "rotacion.cs" si ya est� presente
        }

        // ?? Enviar el objeto reci�n creado al script "rotacion.cs" para que lo maneje
        if (objectController != null)
        {
            objectController.AsignarObjetoSeleccionado(objetoCreado);
        }

        // ?? Ocultar el panel de creaci�n y desactivar el bot�n despu�s de crear un objeto
        if (InformacionCrearla != null) InformacionCrearla.SetActive(false);
        if (BotonCrear != null) BotonCrear.SetActive(false);
    }
}