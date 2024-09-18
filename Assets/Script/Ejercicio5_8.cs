using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{

    //Desarrolla un programa que lea tres números enteros H, M, S 
    //    por el Inspector que contienen hora, minutos y segundos respectivamente, y 
    //    comprueba si la hora(con minutos y segundos) que surge de su combinación es 
    //    una hora válida.Por ejemplo, una  hora inválida sería: 25:89:13. Si el formato es correcto, 
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
                    Debug.Log("El número de segundos es incorrecto.");
                }


            }
            else
            {
                Debug.Log("El número de minutos es incorrecto.");
            }


        }
        else
        {
            Debug.Log("El número de horas es incorrecto.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
