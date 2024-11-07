using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour

{

    [SerializeField]
    ToDestroy[] objectsToDestroy;


    // Start is called before the first frame update
    void Start()
    {

        objectsToDestroy = FindObjectsOfType<ToDestroy>();


    }

    // Update is called once per frame
 
         public void DestroySelectedObjects()
         {
            foreach (ToDestroy guy in objectsToDestroy) 
            {

                if(guy != null && guy.isSelected)
                {
              
                     Destroy(guy.gameObject);
    
                }
            }

         }
}







