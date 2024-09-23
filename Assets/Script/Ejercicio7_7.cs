using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    // Start is called before the first frame update
    //Programa que lea dos números serializados y muestre todos los números desde el  menor hasta el mayor.

    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
       
        if (num1 > num2)
        {
            for (int i = num2; i <= num1; i++)
            {
                Debug.Log(i);

            }

        }
        else if (num2 > num1)
        {
            for (int i = num1; i <= num2; i++)
            {
                Debug.Log(i);

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
