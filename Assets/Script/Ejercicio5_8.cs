using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{

    //Desarrolla un programa que lea tres n�meros enteros H, M, S 
    //    por el Inspector que contienen hora, minutos y segundos respectivamente, y 
    //    comprueba si la hora(con minutos y segundos) que surge de su combinaci�n es 
    //    una hora v�lida.Por ejemplo, una  hora inv�lida ser�a: 25:89:13. Si el formato es correcto, 
    //    muestra dicha hora por la consola.

    [SerializeField] int h, m, s;


    
    void Start()
    {

        if (h >=0 && h<24)
        {
            if(m>=0&& m<60)
            {
                if (s>=0 && s<60)
                {
                    Debug.Log("La hora es: "+ h+ ":"+m+":"+s);
                }
                else
                {
                    Debug.Log("El n�mero de segundos es incorrecto.");
                }


            }
            else
            {
                Debug.Log("El n�mero de minutos es incorrecto.");
            }


        }
        else
        {
            Debug.Log("El n�mero de horas es incorrecto.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
