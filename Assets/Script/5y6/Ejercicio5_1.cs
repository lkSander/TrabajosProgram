using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Ejercicio5_1 : MonoBehaviour
{
    // Start is called before the first frame update

    //En un videojuego, necesitamos decir que la batalla est� re�ida si ambos personajes  tienen exactamente los 
    //    mismos puntos de vida.Para ello, desarrolla un programa que lea dos n�meros enteros por el Inspector(las dos vidas) y compruebe si son iguales.
    [SerializeField] int vidaJugador1, vidaJugador2;

    void Start()
    {
        if (vidaJugador1 == vidaJugador2)
        {
            Debug.Log("�La batalla est� muy re�ida!");

        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
