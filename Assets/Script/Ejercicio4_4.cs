using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update

//    Crea un método con el cual dada una velocidad medida en Km/h, la convierta a metros/s y la devuelva.
//Ejecuta este método con valores de ejemplo desde el Start() y muestra el resultado que devuelve por consola.


    void Start()
    {
        float resultadoFinal = Conversor(3);
        Debug.Log(resultadoFinal+ " m/s.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Conversor(float cantidad)
    {
        float resultadoConversor = cantidad *1000 / 3600;
        return resultadoConversor;
    }
}
