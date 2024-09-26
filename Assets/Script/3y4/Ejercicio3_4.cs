using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    //    Se desea desarrollar un programa que, dados unos puntos de experiencia de un  personaje, “EXP”, 
    //        se calcule el nivel en el que se encuentra, “LVL”. Para ello, lee por el 
    //        Inspector una cantidad cualquiera de puntos de experiencia, “EXP” y realiza la siguiente
    //operación para calcular el nivel del personaje: LVL = 32 + ( 9 * EXP / 5). Muestra dicho  nivel por consola.


    [SerializeField] int exp;
    int nivelPersonaje = 0;

    // Start is called before the first frame update
    void Start()
    {
        nivelPersonaje= 32 +(9*exp /5);
        Debug.Log("El nivel es: " + nivelPersonaje + ".");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
