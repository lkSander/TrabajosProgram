using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Ejercicio7_11 : MonoBehaviour
{
    //Mostrar la tabla de multiplicar de un número entero cualquiera.
    [SerializeField] float num1;
    

    // Start is called before the first frame update
    void Start()
    {
        for (float contar = 0; contar == num1 * 10; contar= contar + num1)
        {
            Debug.Log(contar);


        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
