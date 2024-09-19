using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    //Programa que muestre los números del 1 al 100 utilizando la estructura while 
    int num;
    void Start()
    {
        while(num<100 && num>=1)
        {

            Debug.Log("Programar me desespera...num: " + num);
            num++;


        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
