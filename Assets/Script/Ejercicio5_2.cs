using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    // Start is called before the first frame update
    //Programa que lea dos números por el Inspector y compruebe si ambos dos son menores a 3. 

    [SerializeField] float num1, num2;
    void Start()
    {
        if(num1 <3 && num2 <3)
        {
            Debug.Log("Ambos son menores de 3.");
        }
        else if (num1<3 && num2>= 3)
        {
            Debug.Log("Uno de los dos no es menor de 3.");
        }
       else if (num2 < 3 && num1 >= 3)
       {
            Debug.Log("Uno de los dos no es menor de 3.");
       }
       else
       {
            Debug.Log("Los números son iguales o mayores de 3.");
       }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
