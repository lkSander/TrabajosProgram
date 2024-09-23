using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicio7_6 : MonoBehaviour
{
    // Start is called before the first frame update
    //.Programa que muestre los números desde num(positivo y serializado por el Inspector)  hasta - num utilizando las estructuras for y while 
    [SerializeField] int numPositivo;
    int cuenta = 0;

    void Start()
    {
        if (numPositivo < 0)
        {
            numPositivo = numPositivo * -1;
        }
        for (int i = numPositivo; i <= (-1*numPositivo); i--) 
        {
            Debug.Log(i);   
        }
        while(cuenta<=numPositivo&& cuenta >= (numPositivo*-1))
        {
            cuenta=numPositivo;
            Debug.Log(cuenta);
            cuenta--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
