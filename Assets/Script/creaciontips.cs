using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creaciontips : MonoBehaviour
{

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

    // Start is called before the first frame update
    void Start()
    {



        objetoCreado = Instantiate(prefabitem1, Vector3.zero, Quaternion.identity);
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





    }

    // Update is called once per frame
    void Update()
    {






        
    }


          public void creacion1()
          {

             prefabitem1.SetActive(true);

             

          }










}
