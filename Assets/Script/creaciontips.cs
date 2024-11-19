using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creaciontips : MonoBehaviour
{
    public float raycastDistance = 100f;


    [SerializeField]
    GameObject selectedObject;

     [SerializeField]
    GameObject BotonCrear;

    [SerializeField]
    GameObject prefabitem1;
    GameObject objetoCreado;

    [SerializeField]
    GameObject prefabitem2;
    GameObject objetoCreado2;


    [SerializeField]
    GameObject prefabitem3;
    GameObject objetoCreado3;

    [SerializeField]
    GameObject prefabitem4;
    GameObject objetoCreado4;
    [SerializeField]
    GameObject prefabitem5;
    GameObject objetoCreado5;

    [SerializeField]
    GameObject prefabitem6;
    GameObject objetoCreado6;

    [SerializeField]
    GameObject prefabitem7;
    GameObject objetoCreado7;

    [SerializeField]
    GameObject prefabitem8;
    GameObject objetoCreado8;

    [SerializeField]
    GameObject prefabitem9;
    GameObject objetoCreado9;

    [SerializeField]
    GameObject prefabitem10;
    GameObject objetoCreado10;

    [SerializeField]
    GameObject prefabitem11;
    GameObject objetoCreado11;

    [SerializeField]
    GameObject prefabitem12;
    GameObject objetoCreado12;

    [SerializeField]
    GameObject prefabitem13;
    GameObject objetoCreado13;

    [SerializeField]
    GameObject prefabitem14;
    GameObject objetoCreado14;


    bool object1 = false;
    bool object2 = false;
    bool object3 = false;
    bool object4 = false;
    bool object5 = false;
    bool object6 = false;
    bool object7 = false;
    bool object8 = false;
    bool object9 = false;
    bool object10 = false;
    bool object11 = false;
    bool object12 = false;
    bool object13 = false;
    bool object14 = false;
    bool Seleccion = false;

    void Update()
    {


        Seleccion =!Seleccion;

        // Llamamos al método de selección cuando el usuario hace clic con el botón izquierdo del ratón (botón 0)
        if (Input.GetMouseButtonDown(0))
        {

          if (Seleccion == true)
          { 
            SelectObject();

          }

        }


        if (object1)
        {
            objetoCreado.SetActive(false);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                objetoCreado.transform.position = hit.point;

            }
            objetoCreado.SetActive(true);

            objetoCreado.transform.Rotate(Input.mouseScrollDelta * 16);

            if(Input.GetMouseButtonDown(0))
            {

                objetoCreado = null; // reinicia para permitir crear otro objeto
                object1 = false;  // desactivar el modo de la bollean


            }

        }

        if (object2)
        {
            objetoCreado2.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado2.transform.position = hit.point;


            }
            objetoCreado2.SetActive(true);
            objetoCreado2.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado2 = null; // reinicia para permitir crear otro objeto
                object2 = false;  // desactivar el modo de la bollean


            }

        }

        if (object3)
        {
            objetoCreado3.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado3.transform.position = hit.point;


            }

            objetoCreado3.SetActive(true);
            objetoCreado3.transform.Rotate(Input.mouseScrollDelta * 16);


            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado3 = null; // reinicia para permitir crear otro objeto
                object3 = false;  // desactivar el modo de la bollean


            }


        }

        if (object4)
        {
            objetoCreado4.SetActive(false);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado4.transform.position = hit.point;


            }
            objetoCreado4.SetActive(true);
            objetoCreado4.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado4 = null; // reinicia para permitir crear otro objeto
                object4 = false;  // desactivar el modo de la bollean


            }


        }

        if (object5)
        {

            objetoCreado5.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado5.transform.position = hit.point;


            }

            objetoCreado5.SetActive(true);
            objetoCreado5.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado5 = null; // reinicia para permitir crear otro objeto
                object5 = false;  // desactivar el modo de la bollean


            }

        }

        if (object6)
        {

           objetoCreado6.SetActive(false);
           Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           RaycastHit hit;
       


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado6.transform.position = hit.point;


            }
            objetoCreado6.SetActive(true);
            objetoCreado6.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado6 = null; // reinicia para permitir crear otro objeto
                object6 = false;  // desactivar el modo de la bollean


            }


        }

        if (object7)
        {

            objetoCreado7.SetActive(false);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado7.transform.position = hit.point;


            }
            objetoCreado7.SetActive(true);
            objetoCreado7.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado7 = null; // reinicia para permitir crear otro objeto
                object7 = false;  // desactivar el modo de la bollean


            }


        }



        if (object8)
        {
            objetoCreado8.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado8.transform.position = hit.point;


            }

            objetoCreado8.SetActive(true);
            objetoCreado8.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado8 = null; // reinicia para permitir crear otro objeto
                object8 = false;  // desactivar el modo de la bollean


            }


        }

        if (object9)
        {

            objetoCreado9.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado9.transform.position = hit.point;


            }

            objetoCreado9.SetActive(true);
            objetoCreado9.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado9 = null; // reinicia para permitir crear otro objeto
                object9 = false;  // desactivar el modo de la bollean


            }


        }
        if (object10)
        {
            objetoCreado10.SetActive(false);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado10.transform.position = hit.point;


            }

            objetoCreado10.SetActive(true);
            objetoCreado10.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado10 = null; // reinicia para permitir crear otro objeto
                object10 = false;  // desactivar el modo de la bollean


            }


        }
        if (object11)
        {
            objetoCreado11.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado11.transform.position = hit.point;


            }
            objetoCreado11.SetActive(true);
            objetoCreado11.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado11 = null; // reinicia para permitir crear otro objeto
                object11 = false;  // desactivar el modo de la bollean


            }


        }


        if (object12)
        {
            objetoCreado12.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado12.transform.position = hit.point;


            }
            objetoCreado12.SetActive(true);
            objetoCreado12.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado12 = null; // reinicia para permitir crear otro objeto
                object12 = false;  // desactivar el modo de la bollean


            }


        }

        if (object13)
        {
            objetoCreado13.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado13.transform.position = hit.point;


            }

            objetoCreado13.SetActive(true);
            objetoCreado13.transform.Rotate(Input.mouseScrollDelta * 16);

            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado13 = null; // reinicia para permitir crear otro objeto
                object13 = false;  // desactivar el modo de la bollean


            }


        }

        if (object14)
        {
            objetoCreado14.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;


            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado14.transform.position = hit.point;


            }

            objetoCreado14.SetActive(true);
            objetoCreado14.transform.Rotate(Input.mouseScrollDelta * 16);

            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado14 = null; // reinicia para permitir crear otro objeto
                object14 = false;  // desactivar el modo de la bollean


            }


        }



    }


    void SelectObject()
    {


        if (Seleccion == true)
        {
            // Crear un rayo que comienza en la posición de la cámara y va en la dirección de la cámara
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;  // Esta variable almacenará la información sobre lo que golpeó el rayo

            // Hacemos el raycast y comprobamos si tocamos algo


            if (Physics.Raycast(ray, out hit, raycastDistance)&& hit.collider.GetComponent<rotación>())
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


    public void creacion1()
    {

      prefabitem1.SetActive(true);

             

    }

    public void Cesta()
    {

        object1 = true;
        objetoCreado = Instantiate(prefabitem1, Vector3.zero, Quaternion.identity);
        //GameObject objInstanciado = objetoCreado.gameObject;
        //Destroyer des = objInstanciado.GetComponent<Destroyer>();
        BotonCrear.SetActive(false);
    }
    public void Carro()
    {

        object2 = true;
        objetoCreado2 = Instantiate(prefabitem2, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }

    public void Puerta()
    {

        object3 = true;
        objetoCreado3 = Instantiate(prefabitem3, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }
    public void PuertaValla()
    {

        object4 = true;
        objetoCreado4 = Instantiate(prefabitem4, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }


    public void Nevera()
    {

        object5 = true;
        objetoCreado5 = Instantiate(prefabitem5, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }
    public void Caja()
    {

        object6 = true;
        objetoCreado6 = Instantiate(prefabitem6, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);

    }

    public void Estante()
    {

        object7 = true;
        objetoCreado7 = Instantiate(prefabitem7, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }
    public void Estante2()
    {

        object8 = true;
        objetoCreado8 = Instantiate(prefabitem8, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }
    public void Cajera()
    {

        object9 = true;
        objetoCreado9 = Instantiate(prefabitem9, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }
    public void Congelador()
    {

        object10 = true;
        objetoCreado10 = Instantiate(prefabitem10, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }

    public void Pared()
    {

        object11 = true;
        objetoCreado11 = Instantiate(prefabitem11, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }

    public void Valla()
    {

        object12 = true;
        objetoCreado12 = Instantiate(prefabitem12, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }
    public void Ventana()
    {

        object13 = true;
        objetoCreado13 = Instantiate(prefabitem13, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);


    }

    public void Frutera()
    {

        object14 = true;
        objetoCreado14 = Instantiate(prefabitem14, Vector3.zero, Quaternion.identity);
        BotonCrear.SetActive(false);

    }

}
