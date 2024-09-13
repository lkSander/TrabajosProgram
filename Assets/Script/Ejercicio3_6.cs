using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{

    //Se desea desarrollar un juego de carreras y se han de calcular las velocidades de varios  vehículos
    //    .Para ello, desarrolla un programa que lea por el Inspector una velocidad medida en Km/h y la convierta a m/s, 
    //    almacenando este dato en una nueva variable.Después, mostrar el contenido de esta variable por consola.



    [SerializeField] float velocidadCocheKmH;
    float velocidadCocheMS = 0f;



    //// Start is called before the first frame update
    void Start()
    {
        velocidadCocheMS = velocidadCocheKmH / 3.6f;
        Debug.Log("La velocidad es " + velocidadCocheMS + "m/s.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
