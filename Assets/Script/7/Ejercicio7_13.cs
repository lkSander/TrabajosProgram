using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Ejercicio7_13 : MonoBehaviour
{
    // Start is called before the first frame update
//    7.13.Crea un método que reciba por parámetro de entrada un número entero.Este método nos indicará si es o no un número primo. Debe devolver true si es primo sino false. 
//Un número primo es aquel que solo puede dividirse entre 1 y sí mismo.Por ejemplo: 25  no es primo, ya que 25 es divisible entre 5, sin embargo, 17 si es primo.

    void Start()
    {
       bool primo= IndicadorNumPrimo(6);
        if(primo== true)
        {
            Debug.Log("El número es primo");

        }
        else
        {
            Debug.Log("El número no es primo");
        }
       
    }

    // Update is called once per frame
    bool IndicadorNumPrimo(int num)
    {

        if(num%2==1 && num%5==1 && num%3==1)
        {
            return true;
        }
        else if (num % 2 == 0 || num % 5 == 0 || num % 3== 0)
        {

            return false;
        }
        else
        {
            return false;
        }
    }
    //Me explotó la cabeza así que lo dejé así.
}
