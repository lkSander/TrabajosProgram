using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{

    //    Escribe un programa que declare una variable entera �vidas� y as�gnale un valor  cualquiera.A continuaci�n, realiza las siguientes operaciones con la variable(siguiendo el orden descrito). A cada paso, ve mostrando su valor por consola: 
    //Primero, incrementar �vidas� en 77. 
    //Despu�s, decrementarla en 3. 
    //Por �ltimo, cuadruplicar su valor.

    int vidas = 20;
    int vidasDiferencia = 0; 

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Vidas: " + vidas);
        vidas = vidas + 77;
        Debug.Log("Vidas: " + vidas);
        vidas = vidas - 3;
        Debug.Log("Vidas: " + vidas);
        vidas = vidas * 4;
        Debug.Log("Vidas: " + vidas);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
