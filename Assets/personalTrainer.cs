using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personalTrainer : MonoBehaviour
{
    public string servicio;
    public int horas;
    int precio;
    float precioDescuento;
    void Start()
    {

        if (servicio == "Cardio" && horas <= 6 && horas > 0)
        {
            precio = horas * 1000;

        }

        else if (servicio == "Fuerza" && horas <= 6 && horas > 0)
        {
            precio = horas * 1500;
        }

        else if (servicio == "Recreativo" && horas <= 6 && horas > 0)
        {
            precio = horas * 2500;
        }

        else
        {
            Debug.Log("Horas o Servicio incorrectos");
        }

        if (horas == 6)
        {
            precioDescuento = precio * 0.9f ;
        }


        Debug.Log(servicio);
        Debug.Log(horas);
        Debug.Log(precio);
        Debug.Log(precioDescuento);

    }


}
