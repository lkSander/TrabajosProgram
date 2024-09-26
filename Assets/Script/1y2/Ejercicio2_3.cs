using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;
public class Ejercicio2_3 : MonoBehaviour
{
    int vida = 8;
    float exp = 40f;

    float resultadoProducto = 0f;
    float resultadoCociente = 0f;
    float resultadoResto = 0f;
    float resultadoDobleVida = 0f;
    float resultadoTripleExp = 0f;
 


    // Start is called before the first frame update
    void Start()
    {
        resultadoCociente = vida / exp;
        resultadoProducto = vida * exp;
        resultadoResto = vida % exp;
        resultadoDobleVida = vida * 2;
        resultadoTripleExp = exp * 3;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
