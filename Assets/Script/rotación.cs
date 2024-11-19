using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class rotación : MonoBehaviour
{
    [SerializeField]
    GameObject selectedObject;
    public float movementEjeX = 1;
    public float movementEjeY;
    public float movementEjeZ = 1;
    public float fastmovement = 1.5f;
    bool Seleccion = false;
    public float raycastDistance = 100f;
    [SerializeField]
    GameObject ButtonRotar;
    [SerializeField]
    GameObject ButtonIZQ;
    [SerializeField]
    GameObject ButtonDEREC;
    [SerializeField]
    GameObject ButtonABAJ;
    [SerializeField]
    GameObject ButtonARRIB;
    [SerializeField]
    GameObject ButtonEliminar;
    [SerializeField]
    GameObject ButtonInfo;
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            if (Seleccion = true)
            {


               SelectObject();


            }

        }

    }



    void SelectObject()
    {


        if (Seleccion = true)
        {
            // Crear un rayo que comienza en la posición de la cámara y va en la dirección de la cámara
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;  // Esta variable almacenará la información sobre lo que golpeó el rayo

            // Hacemos el raycast y comprobamos si tocamos algo


            if (Physics.Raycast(ray, out hit, raycastDistance) && hit.collider.GetComponent<rotación>())
            {

                // Si el rayo toca algo, 'hit' contendrá el objeto tocado.
                selectedObject = hit.collider.gameObject;

                // Imprimir el nombre del objeto seleccionado en la consola
                Debug.Log("Seleccionaste el objeto: " + selectedObject.name);


                // Aquí puedes hacer algo con el objeto seleccionado, por ejemplo cambiar su color:
                // para ponerlo con colores selectedObject.GetComponent<Renderer>().material.color = Color.blue;
                selectedObject.GetComponent<Renderer>();

            }
        }

    }
    void deselecionarobject()
    {


        selectedObject = null;


    }





    public void Rotate()
    {

        if (ButtonRotar.activeSelf) 
        {
            
          selectedObject.transform.Rotate(0f, 8f, 0f);
          Debug.Log("Esta Rotando");

        }


    }

    public void MovimientoIZQ()
    {

        if (ButtonIZQ.activeSelf)
        {

           selectedObject.transform.Translate(-1f, 0f, 0f);
           Debug.Log("MovimientoIZQ");

        }


    }

    public void MovimientoDRC()
    {
        if(ButtonDEREC.activeSelf)
        { 

           selectedObject.transform.Translate(1f, 0f, 0f);
           Debug.Log("MovimientoDRC");

        }

    }

    public void MovimientoABA()
    {
        if (ButtonABAJ.activeSelf)
        {

            selectedObject.transform.Translate(0f, 0f, -1f);
            Debug.Log("MovimientoABA");

        }


    }

    public void MovimientoArri()
    {
        if (ButtonARRIB.activeSelf)
        {

            selectedObject.transform.Translate(0f, 0f, 1f);
            Debug.Log("MovimientoArri");

        }

    }

    public void Eliminar()
    {

        ButtonInfo.SetActive(true);
        if (ButtonEliminar.activeSelf)
        {

            Destroy(selectedObject);
            Debug.Log("Se Elimino");
            ButtonInfo.SetActive(false);
        }

    }



}
