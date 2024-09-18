using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    // Start is called before the first frame update
    //.Programa que lea un número entero por el Inspector y compruebe si es un número comprendido entre '0' y '9'. 

    [SerializeField] int num;

    void Start()
    {
        if(num >= 0 && num<9)
        {
            Debug.Log("El número está comprendido entre el 0 y el 9");

        }
        else
        {
            Debug.Log("No se comprende entre el 0 y el 9");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
