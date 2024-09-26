using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using Unity.VisualScripting;
using UnityEngine;
public class Ejercicio3_5 : MonoBehaviour
{
    //Se desea desarrollar un programa para calcular el área de visión de un enemigo.
    //    Dicha  área tiene forma de circunferencia.Para ello, desarrolla un programa que lea por el 
    //    Inspector el radio de una circunferencia y calcule la longitud y el área de la  circunferencia, 
    //    almacenando estos dos datos en dos variables.Después, mostrar el  contenido de estas dos variables 
    //    por consola.Longitud de la circunferencia = 2 * PI * Radio, Área de la circunferencia = PI * Radio ^ 2

    [SerializeField] float radioCircunferencia;
    float areaCircunferencia = 0;
    float longitudCircunferencia = 0;
  
    float numPi = 3.1417f;


    // Start is called before the first frame update
    void Start()
    {
        longitudCircunferencia= 2f *numPi * radioCircunferencia;
        areaCircunferencia = numPi * (radioCircunferencia* radioCircunferencia);

        Debug.Log("Longitud de la circunferencia: " + longitudCircunferencia+ " Área de la circunferencia: " + areaCircunferencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
