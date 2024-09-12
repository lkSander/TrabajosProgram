using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
public class Ejercicio2_6 : MonoBehaviour
{
    //Un jugador tiene tres puntuaciones cualesquiera en un videojuego.
    //    Cada una de ellas  representada por un número entero.Desarrolla un programa que muestre las tres puntuaciones y su media.

    int eneimgosMuertos = 22;
    int monedas = 120;
    int aldeanosSalvados = 12;
    float mediaPuntuacion = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mediaPuntuacion= (eneimgosMuertos+monedas+aldeanosSalvados)/3;
        Debug.Log("Media de Puntuación: "+ mediaPuntuacion);
    }
}
