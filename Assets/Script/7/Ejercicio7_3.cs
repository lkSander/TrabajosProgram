using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    // Start is called before the first frame update
    int num =100;

    //Programa que muestre los números del 100 al 1 utilizando la estructura while 
    void Start()
    {
        while (num < 100 && num>=1)
        {
            Debug.Log(num);
            num--;

        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
