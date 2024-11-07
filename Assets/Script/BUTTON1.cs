using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BUTTON1 : MonoBehaviour
{
    [SerializeField]
    GameObject BotonCrear;

    [SerializeField]
    GameObject BotonGirar;

    [SerializeField]
    GameObject BotonMover;

    [SerializeField]
    GameObject BotonEliminar;

    GameObject objetotiendas;
    //movimientos
    public float movementEjeX;
    public float movementEjeY;
    public float movementEjeZ;
    public float speedMovement = 1.5f;

    public float rotationSpeed = 100f; // Velocidad de rotación en grados por segundo
    public Vector3 rotationAxis = Vector3.up; // Eje de rotación, por defecto es el eje Y
    [SerializeField]
    GameObject GameObject;

    [SerializeField]
    GameObject item1;

    [SerializeField]
    GameObject item2;

    [SerializeField]
    GameObject item3;

    [SerializeField]
    GameObject item4;

    [SerializeField]
    GameObject item5;

    [SerializeField]
    GameObject item6;

    [SerializeField]
    GameObject item7;

    [SerializeField]
    GameObject item8;

    [SerializeField]
    GameObject item9;


    [SerializeField]
    GameObject item10;

    [SerializeField]
    GameObject item11;

    [SerializeField]
    GameObject item12;

    [SerializeField]
    GameObject item13;

    [SerializeField]
    GameObject item14;



    //Rotacion
    // [SerializeField]
    //float speedRotate = 1.0f;
    // private float rotate;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickEnBotonCrear()
    {
        BotonCrear.SetActive(true);
            

    }

    public void ClickEnTienda()
    {
        BotonCrear.SetActive(false);

    }

    public void ClickEnMover()
    {

        BotonMover.SetActive(true);



    }

    public void ClickEnOk()
    {

        BotonMover.SetActive(false);
        BotonGirar.SetActive(false);
    }

    public void ClickEnIzquier()
    {

    }

    public void ClickEnDerech()
    {



    }

    public void ClickEnArri()
    {





    }

    public void ClickEnAbaj()
    {



    }

   // public void BotonElimin()
  //  {
        
       // {
       //     Destroy(gameObject);    
       // objetotiendas = GameObject.Find ("ObjetoTienda");
        //Destroy(objetotiendas, (float)1);

            // Para que se eliminen todos a la vez 
            //  Destroy (this.gameObject, (float)1);
     //   }
   // }


    public void BotonRotate()
    {

        /* transform.Rotate(0f, speedRotate, 0f);
         // LeanTween.moveZ(Rojo, 0f, 0f).setEase(LeanTweenType.easeInQuad);



         objetotiendas = GameObject.Find("ObjetoTienda");
         Vector3 movement = new Vector3();
         movement.z = Input.GetAxis("Vertical");
         movement.z += speedRotate * Time.deltaTime;
        */
                 objetotiendas = GameObject.Find("ObjetoTienda");
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);


    }

    public void BotonGiratorio()
    {

       BotonGirar.SetActive(true);

    }

    public void Item1()
    {


        item1.SetActive(true);
        BotonCrear.SetActive(false);

    }


    public void Item2()
    {

        item2.SetActive(true);
        BotonCrear.SetActive(false);

    }

    public void Item3()
    {

        item3.SetActive(true);
        BotonCrear.SetActive(false);
    }


    public void Item4()
    {

        item4.SetActive(true);
        BotonCrear.SetActive(false);
    }



    public void Item5()
    {

        item5.SetActive(true);
        BotonCrear.SetActive(false);
    }


    public void Item6()
    {

        item6.SetActive(true);
        BotonCrear.SetActive(false);
    }

    public void Item7()
    {

        item7.SetActive(true);
        BotonCrear.SetActive(false);
    }



    public void Item8()
    {

        item8.SetActive(true);
        BotonCrear.SetActive(false);
    }

    public void Item9()
    {

       item9.SetActive(true);
        BotonCrear.SetActive(false);
    }


    public void Item10()
    {

        item10.SetActive(true);
        BotonCrear.SetActive(false);
    }


    public void Item11()
    {

        item11.SetActive(true);
        BotonCrear.SetActive(false);
    }


    public void Item12()
    {

        item12.SetActive(true);
        BotonCrear.SetActive(false);
    }

    public void Item13()
    {

        item13.SetActive(true);
        BotonCrear.SetActive(false);
    }


    public void Item14()
    {

        item14.SetActive(true);
        BotonCrear.SetActive(false);
    }



}
