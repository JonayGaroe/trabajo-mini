using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDestroy : MonoBehaviour
{


    [SerializeField]
    private GameObject selectioPrefab;

    private GameObject newSelection;

    public bool isSelected;


        private void OnMouseDown()
        {
        
            if (newSelection == null)
            {
                 newSelection = Instantiate (selectioPrefab,transform.position, Quaternion.identity);
                newSelection.transform.SetParent(gameObject.transform);
                newSelection.SetActive(false);


            }

            isSelected = !isSelected;
            
            if (isSelected)
            {






                 newSelection.SetActive(true);
            }

             else 
             { 
                newSelection?.SetActive(false);






             }


        }
}
