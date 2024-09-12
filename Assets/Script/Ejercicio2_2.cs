using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_2 : MonoBehaviour
{

    //Variables
    int vida = 2;
    float exp = 22f;
    char carac = 'a';

    float resultadoSuma = 0f;
    float resultadoResta = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vidas: " + vida + " Exp: " + exp);

        resultadoSuma = vida + exp;
        resultadoResta = exp - vida;

        Debug.Log("Resultado de la suma: " + resultadoSuma + " Resultado de la Resta: " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
