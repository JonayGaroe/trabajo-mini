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

       [SerializeField]
    GameObject GameObject;

      [SerializeField]
    GameObject InformacionCrear;

         [SerializeField]
    GameObject InformacionCrearla;
    [SerializeField]
    GameObject InformacionMover;

    [SerializeField]
    GameObject InformacionRotar;
    [SerializeField]
    GameObject BotonEscalar;
    [SerializeField]
    GameObject InformarEscalar;


    public void ClickEnBotonCrear()
    {


        BotonCrear.SetActive(true);
        InformacionCrear.SetActive(false);
        InformacionCrearla.SetActive(true);

    }

    public void ClickEnTienda()
    {

        BotonCrear.SetActive(false);

    }

    public void ClickEnMover()
    {


        BotonMover.SetActive(true);
        InformacionMover.SetActive(true);

    }

    public void ClickEnOk()
    {

        InformacionMover.SetActive(false);
        BotonMover.SetActive(false);
        BotonGirar.SetActive(false);
        InformacionRotar.SetActive(false);
        InformacionCrear.SetActive(true);
        BotonEscalar.SetActive(false);
        InformarEscalar.SetActive(false);
    }
    public void BotonEscalars()
    {

        BotonEscalar.SetActive(true);
        InformarEscalar.SetActive(true);
        BotonCrear.SetActive(false);
    }




    public void BotonGiratorio()
    {

        InformacionRotar.SetActive(true);
        BotonGirar.SetActive(true);

    }


}
