using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    // Start is called before the first frame update

    //Programa que lea dos números por el Inspector y muestre el resultado de la división del 
    // primero por el segundo.Se debe comprobar previamente que el divisor no puede ser cero

    [SerializeField] float num1, num2;


    void Start()
    {
        if (num2 != 0)
        {
            float respuestaFinal= num1/ num2;
            Debug.Log("La división da " + respuestaFinal + ".");


        }
        else
        {
            Debug.Log("No se puede dividir entre cero");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
