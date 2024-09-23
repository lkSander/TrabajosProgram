using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
public class Ejercicio7_5 : MonoBehaviour
{

    //Programa que muestre los números desde 1 hasta numero(variable con valor positivo y serializada por el Inspector) 
    //    utilizando la estructura while. Después, haz lo mismo utilizando la estructura for.

    [SerializeField]int numMaximo;
    int numCuenta = 1;

    // Start is called before the first frame update
    void Start()
    {
        while( numCuenta>= 1 && numCuenta<= numMaximo)
        {
            Debug.Log(numCuenta);
            numCuenta++;


        }

        for(int i = 1; i <= numMaximo; i++)
        {

            Debug.Log(numCuenta);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
