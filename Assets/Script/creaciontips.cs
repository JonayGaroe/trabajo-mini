using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creaciontips : MonoBehaviour
{

    [SerializeField]
    GameObject prefabitem1;
    GameObject objetoCreado;
 // botonloquequieras
 //serializefield gameobject
    

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
    // Start is called before the first frame update
    void Start()
    {

        //No Hace nada

        /*objetoCreado = Instantiate(prefabitem1, Vector3.zero, Quaternion.identity);
        objetoCreado2 = Instantiate(prefabitem2, Vector3.zero, Quaternion.identity);
        objetoCreado3 = Instantiate(prefabitem3, Vector3.zero, Quaternion.identity);
        objetoCreado4 = Instantiate(prefabitem4, Vector3.zero, Quaternion.identity);
        objetoCreado5 = Instantiate(prefabitem5, Vector3.zero, Quaternion.identity);
        objetoCreado6 = Instantiate(prefabitem6, Vector3.zero, Quaternion.identity);
        objetoCreado7 = Instantiate(prefabitem7, Vector3.zero, Quaternion.identity);
        objetoCreado8 = Instantiate(prefabitem8, Vector3.zero, Quaternion.identity);
        objetoCreado9 = Instantiate(prefabitem9, Vector3.zero, Quaternion.identity);
        objetoCreado10 = Instantiate(prefabitem10, Vector3.zero, Quaternion.identity);
        objetoCreado11 = Instantiate(prefabitem11, Vector3.zero, Quaternion.identity);
        objetoCreado12 = Instantiate(prefabitem12, Vector3.zero, Quaternion.identity);
        objetoCreado13 = Instantiate(prefabitem13, Vector3.zero, Quaternion.identity);
        objetoCreado14 = Instantiate(prefabitem14, Vector3.zero, Quaternion.identity);

        */



    }

    // Update is called once per frame
    void Update()
    {



        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (object1)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado.transform.position = hit.point;


            }

            objetoCreado.transform.Rotate(Input.mouseScrollDelta * 16);
            if(Input.GetMouseButtonDown(0))
            {

                objetoCreado = null; // reinicia para permitir crear otro objeto
                object1 = false;  // desactivar el modo de la bollean


            }


        }

        if (object2)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado2.transform.position = hit.point;


            }

            objetoCreado2.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado2 = null; // reinicia para permitir crear otro objeto
                object2 = false;  // desactivar el modo de la bollean


            }


        }

        if (object3)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado3.transform.position = hit.point;


            }

            objetoCreado3.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado3 = null; // reinicia para permitir crear otro objeto
                object3 = false;  // desactivar el modo de la bollean


            }


        }

        if (object4)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado4.transform.position = hit.point;


            }

            objetoCreado4.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado4 = null; // reinicia para permitir crear otro objeto
                object4 = false;  // desactivar el modo de la bollean


            }


        }
        if (object5)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado5.transform.position = hit.point;


            }

            objetoCreado5.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado5 = null; // reinicia para permitir crear otro objeto
                object5 = false;  // desactivar el modo de la bollean


            }








        }
        if (object6)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado6.transform.position = hit.point;


            }

            objetoCreado6.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado6 = null; // reinicia para permitir crear otro objeto
                object6 = false;  // desactivar el modo de la bollean


            }


        }

        if (object7)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado7.transform.position = hit.point;


            }

            objetoCreado7.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado7 = null; // reinicia para permitir crear otro objeto
                object7 = false;  // desactivar el modo de la bollean


            }


        }



        if (object8)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado8.transform.position = hit.point;


            }

            objetoCreado8.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado8 = null; // reinicia para permitir crear otro objeto
                object8 = false;  // desactivar el modo de la bollean


            }


        }

        if (object9)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado9.transform.position = hit.point;


            }

            objetoCreado9.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado9 = null; // reinicia para permitir crear otro objeto
                object9 = false;  // desactivar el modo de la bollean


            }


        }
        if (object10)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado10.transform.position = hit.point;


            }

            objetoCreado10.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado10 = null; // reinicia para permitir crear otro objeto
                object10 = false;  // desactivar el modo de la bollean


            }


        }
        if (object11)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado11.transform.position = hit.point;


            }

            objetoCreado11.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado11 = null; // reinicia para permitir crear otro objeto
                object11 = false;  // desactivar el modo de la bollean


            }


        }


        if (object12)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado12.transform.position = hit.point;


            }

            objetoCreado12.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado12 = null; // reinicia para permitir crear otro objeto
                object12 = false;  // desactivar el modo de la bollean


            }


        }

        if (object13)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado13.transform.position = hit.point;


            }

            objetoCreado13.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado13 = null; // reinicia para permitir crear otro objeto
                object13 = false;  // desactivar el modo de la bollean


            }


        }

        if (object14)
        {



            if (Physics.Raycast(ray, out hit))
            {


                objetoCreado14.transform.position = hit.point;


            }

            objetoCreado14.transform.Rotate(Input.mouseScrollDelta * 16);
            if (Input.GetMouseButtonDown(0))
            {

                objetoCreado14 = null; // reinicia para permitir crear otro objeto
                object14 = false;  // desactivar el modo de la bollean


            }


        }



    }


          public void creacion1()
          {

             prefabitem1.SetActive(true);

             

          }

    public void Cesta()
    {

        object1 = true;
        objetoCreado = Instantiate(prefabitem1, Vector3.zero, Quaternion.identity);


    }
    public void Carro()
    {

        object2 = true;
        objetoCreado2 = Instantiate(prefabitem2, Vector3.zero, Quaternion.identity);


    }

    public void Puerta()
    {

        object3 = true;
        objetoCreado3 = Instantiate(prefabitem3, Vector3.zero, Quaternion.identity);


    }
    public void PuertaValla()
    {

        object4 = true;
        objetoCreado4 = Instantiate(prefabitem4, Vector3.zero, Quaternion.identity);


    }


    public void Nevera()
    {

        object5 = true;
        objetoCreado5 = Instantiate(prefabitem5, Vector3.zero, Quaternion.identity);


    }
    public void Caja()
    {

        object6 = true;
        objetoCreado6 = Instantiate(prefabitem6, Vector3.zero, Quaternion.identity);


    }

    public void Estante()
    {

        object7 = true;
        objetoCreado7 = Instantiate(prefabitem7, Vector3.zero, Quaternion.identity);


    }
    public void Estante2()
    {

        object8 = true;
        objetoCreado8 = Instantiate(prefabitem8, Vector3.zero, Quaternion.identity);


    }
    public void Cajera()
    {

        object9 = true;
        objetoCreado9 = Instantiate(prefabitem9, Vector3.zero, Quaternion.identity);


    }
    public void Congelador()
    {

        object10 = true;
        objetoCreado10 = Instantiate(prefabitem10, Vector3.zero, Quaternion.identity);


    }

    public void Pared()
    {

        object11 = true;
        objetoCreado11 = Instantiate(prefabitem11, Vector3.zero, Quaternion.identity);


    }

    public void Valla()
    {

        object12 = true;
        objetoCreado12 = Instantiate(prefabitem12, Vector3.zero, Quaternion.identity);


    }
    public void Ventana()
    {

        object13 = true;
        objetoCreado13 = Instantiate(prefabitem13, Vector3.zero, Quaternion.identity);


    }

    public void Frutera()
    {

        object14 = true;
        objetoCreado14 = Instantiate(prefabitem14, Vector3.zero, Quaternion.identity);


    }

}
