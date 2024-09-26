using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update

    //    Crea un método llamado “Convertir” que sirva como conversor de euros a dólares y viceversa.Tendrá dos parámetros de entrada: 
    //        cantidad (tipo float) y moneda(tipo string).  El método será capaz de hacer la conversión en función al tipo de moneda introducido
    //        y  devolverá a su salida la conversión calculada.
    //Ejecuta este método con valores de ejemplo desde el Start() y muestra el resultado que devuelve por consola.

    float diferenciaDolar = 1.11f;


    void Start()
    {
        float dinero = Convertir(7, "dolares");

        Debug.Log("La conversión da como resultado: "+ dinero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Convertir(float cantidad, string moneda)
    {
        if( moneda== "dolares")
        {
            float euros= cantidad*1/ diferenciaDolar;

            return euros;
        }
        else 
        {

            float dolares = diferenciaDolar * cantidad / 1;
            return dolares;
        }
        

    }
}
