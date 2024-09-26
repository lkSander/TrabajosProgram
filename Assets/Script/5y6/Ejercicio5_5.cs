using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    // Start is called before the first frame update

    // Desarrolla un programa que lea el nivel de un personaje por el Inspector y calcule si es par o impar.
    [SerializeField] int vidaJugador;
    void Start()
    {
        if(vidaJugador % 2== 0)
        {
            Debug.Log("La vida del jugador es par.");
        }
        else
        {
            Debug.Log("La vida del jugador es impar.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
