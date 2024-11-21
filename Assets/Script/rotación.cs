using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class rotación : MonoBehaviour
{

    [SerializeField]
  LeanTweenType tipoAnimacion;

    [SerializeField]
    GameObject selectedObject;
    public float movementEjeX = 1;
    public float movementEjeY;
    public float movementEjeZ = 1;
    public float fastmovement = 1.5f;
    bool Seleccion = false;
    public float raycastDistance = 100f;

        [SerializeField]
      GameObject BotonEscalar;
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
        [SerializeField]
      GameObject Sphere;
        [SerializeField]
     GameObject ButtonEscalarMass;
        [SerializeField]
     GameObject ButtonEscalarMenoss;
    private float scale;
    
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
             //   Sphere.SetActive(true);

                // Imprimir el nombre del objeto seleccionado en la consola
                Debug.Log("Seleccionaste el objeto: " + selectedObject.name);


                // Aquí puedes hacer algo con el objeto seleccionado, por ejemplo cambiar su color:
                // para ponerlo con colores selectedObject.GetComponent<Renderer>().material.color = Color.blue;

                //selectedObject.GetComponent<Renderer>().material.color = Color.blue;

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
           Debug.Log("MovimientoIZQUIERDA");

        }


    }

    public void MovimientoDRC()
    {
        if(ButtonDEREC.activeSelf)
        { 

           selectedObject.transform.Translate(1f, 0f, 0f);
           Debug.Log("MovimientoDERECHA");

        }

    }

    public void MovimientoABA()
    {
        if (ButtonABAJ.activeSelf)
        {

            selectedObject.transform.Translate(0f, 0f, -1f);
            Debug.Log("MovimientoABAJO");

        }


    }

    public void MovimientoArri()
    {
        if (ButtonARRIB.activeSelf)
        {

            selectedObject.transform.Translate(0f, 0f, 1f);
            Debug.Log("MovimientoArriBA");

        }

    }

    public void Eliminar()
    {
        // setloop(-1f);
       // LeanTween.scale(selectedObject, Vector3.zero, 2f).setEase(tipoAnimacion).setOnComplete(() =>
       // {

        //});
        ButtonInfo.SetActive(true);
        if (ButtonEliminar.activeSelf)
        {
            // La escala va de un punto A a un Punto B 
            LeanTween.scale(selectedObject, Vector3.zero, 0.5f).setEase(tipoAnimacion).setOnComplete(() =>
            {
                Destroy(selectedObject);
                Debug.Log("Se Elimino");
                ButtonInfo.SetActive(false);

            });

            // Lo dejo aqui por si no me funciona un experimento

            //Destroy(selectedObject);
            //Debug.Log("Se Elimino");
            //ButtonInfo.SetActive(false);


        }

    }

    // Quiero que se agrande solo en 3 posiciones por que no me interesa que un objeto este mucho mas grande que el mapa ya que puede inplementar Errores Ya sea al escalar el tamaño


     public void EscalarMas()
     {
     
        if (ButtonEscalarMass.activeSelf)
        {

            LeanTween.scale(selectedObject, new Vector3(9f, 9f, 9f), 3f).setEase(tipoAnimacion);

        }


     }
    public void EscalarMass()
    {

        if (ButtonEscalarMass.activeSelf)
        {

            LeanTween.scale(selectedObject, new Vector3(14f, 14f, 14f), 3f).setEase(tipoAnimacion);

        }


    }
    public void EscalarMasss()
    {

        if (ButtonEscalarMass.activeSelf)
        {

            LeanTween.scale(selectedObject, new Vector3(18f, 18f, 18f), 3f).setEase(tipoAnimacion);

        }


    }
    public void EliminarMenoss()
    {


        if (ButtonEscalarMenoss.activeSelf)
        {


            LeanTween.scale(selectedObject, new Vector3(7f, 7f, 7f), 3f).setEase(tipoAnimacion);



        }




    }

    public void EliminarMenosss()
    {


        if (ButtonEscalarMenoss.activeSelf)
        {


            LeanTween.scale(selectedObject, new Vector3(5f, 5f, 5f), 3f).setEase(tipoAnimacion);



        }




    }
    public void EliminarMenossss()
    {


        if (ButtonEscalarMenoss.activeSelf)
        {


            LeanTween.scale(selectedObject, new Vector3(3f, 3f, 3f), 3f).setEase(tipoAnimacion);



        }




    }
}