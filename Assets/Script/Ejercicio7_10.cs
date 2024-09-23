using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.UIElements;

public class Ejercicio7_10 : MonoBehaviour
{
    // Start is called before the first frame update
    //Programa que lea dos números serializados e indique todos los números entre  los dos leídos.
    //    Además, se indicará si estos números son positivos o negativos y pares o  impares


    [SerializeField] int num1, num2;
    int numContar = 0;
    void Start()
    {


        if (num1 < 0)
        {
            Debug.Log("El primer número es positivo");
        }
        else
        {
            Debug.Log("El primer número es negativo");
        }
        if (num2 < 0)
        {
            Debug.Log("El segundo número es positivo");
        }
        else
        {
            Debug.Log("El segundo número es negativo");
        }

        if (num1 % 2 == 0)
        {
            Debug.Log("El primer número es par");

        }
        else
        {
            Debug.Log("El primer número es impar");

        }
        if (num2 % 2 == 0)
        {

            Debug.Log("El segundo número es par");
        }
        else
        {
            Debug.Log("El segundo número es impar");

        }


        if (num1>num2)

        {

            for (int numContar = num2; num2 >= num1; numContar++)
            {


                Debug.Log(numContar);




            }



        }
        
        else if (num1<num2)

        {

            for (int numContar = num1; num1 >= num2; numContar++)
            {


                Debug.Log(numContar);




            }



        }
        else
        {
            Debug.Log(num1);
        }











        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
