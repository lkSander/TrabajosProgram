using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.UIElements;

public class Ejercicio7_10 : MonoBehaviour
{
    // Start is called before the first frame update
    //Programa que lea dos n�meros serializados e indique todos los n�meros entre  los dos le�dos.
    //    Adem�s, se indicar� si estos n�meros son positivos o negativos y pares o  impares


    [SerializeField] int num1, num2;
    int numContar = 0;
    void Start()
    {


        if (num1 < 0)
        {
            Debug.Log("El primer n�mero es positivo");
        }
        else
        {
            Debug.Log("El primer n�mero es negativo");
        }
        if (num2 < 0)
        {
            Debug.Log("El segundo n�mero es positivo");
        }
        else
        {
            Debug.Log("El segundo n�mero es negativo");
        }

        if (num1 % 2 == 0)
        {
            Debug.Log("El primer n�mero es par");

        }
        else
        {
            Debug.Log("El primer n�mero es impar");

        }
        if (num2 % 2 == 0)
        {

            Debug.Log("El segundo n�mero es par");
        }
        else
        {
            Debug.Log("El segundo n�mero es impar");

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
