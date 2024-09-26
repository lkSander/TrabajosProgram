using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Ejercicio7_8 : MonoBehaviour
{
    // Start is called before the first frame update
    // Programa que lea dos números serializados y muestre los números pares entre ellos.

    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
        if(num1 % 2== 0 && num1>num2)
        {
            for(int i = num1; i <= num2; i= i-2)
            {
                Debug.Log(i);
            }
        }
        else if(num1 % 2== 0 && num1<num2)
        {
            for (int i = num1; i >= num2; i = i + 2)
            {
                Debug.Log(i);
            }
        }
        else if (num1 % 2== 1 && num1 > num2)
        {
            num1 = num1 - 1;
            for (int i = num1; i <= num2; i = i - 2)
            {
                Debug.Log(i);
            }

        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
