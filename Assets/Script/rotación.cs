using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class rotación : MonoBehaviour
{

    public float movementEjeX = 1;
    public float movementEjeY;
    public float movementEjeZ = 1;
    public float fastmovement = 1.5f;
    //  bool Mover = false;
    // bool mover1 = false;
    // bool mover2 = false;    
    // bool mover3 = false;

    // Start is called before the first frame update

    void Start()
    {






    }




    // Update is called once per frame
    void Update()
    {
      /* 
        if (Mover == true)
        {

       
            movementEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * fastmovement;
            transform.Translate(movementEjeX, 0f, 0f);
            Debug.Log("MovimientoIZQ");
            Mover = false;



        }

        if (mover1 == true)
        {


            movementEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * fastmovement;
            transform.Translate(movementEjeX, movementEjeY, movementEjeZ);
            Debug.Log("MovimientoDRC");
            mover1 = false;



        }

        if (mover2 == true)
        {

        

            movementEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * fastmovement;
            transform.Translate(0f, movementEjeY, movementEjeZ);
            Debug.Log("MovimientoArri");
            mover2 = false;
        }



        if (mover3 == true)
        {


            movementEjeZ = Input.GetAxis("Vertical") * Time.deltaTime * fastmovement;
            transform.Translate(movementEjeX, movementEjeY, movementEjeZ);
            Debug.Log("MovimientoArri");
            mover3 = false; 

        }



        */

    }
    public void Rotate()
    { 
        
     transform.Rotate(0f,8f,0f);
     Debug.Log("Esta Rotando");



    }

    public void MovimientoIZQ()
    {

        //Mover = true;
        transform.Translate(-1f, 0f, 0f);
        Debug.Log("MovimientoIZQ");



    }

    public void MovimientoDRC()
    {

        //mover1 = true;
        transform.Translate(1f, 0f, 0f);
        Debug.Log("MovimientoDRC");


    }

    public void MovimientoABA()
    {

       // mover2 = true;
        transform.Translate(0f, 0f, -1f);
        Debug.Log("MovimientoABA");



    }

    public void MovimientoArri()
    {

        //mover3 = true;
        transform.Translate(0f, 0f, 1f);
        Debug.Log("MovimientoArri");


    }



}
