using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.Analytics;
using UnityEngine.WSA;

public class Personaje : MonoBehaviour

//    //8.1. Crear una clase Personaje, con propiedades privadas nombre, vida y experiencia. Crear tambi�n el m�todo float CalcularNivel()
//    //para calcular el nivel de un personaje aplicando la siguiente ecuaci�n: LVL = EXP / 1000 y que lo devuelva a su salida.Genera dos c�psulas que sirvan como instancia de dicha clase.
//Referencia a los personajes desde el GameManager y genera en este un m�todo nuevo, PrepararPersonajes(), el cual ser� ejecutado al pulsar Espacio.
//En dicho m�todo, para cada personaje da valor a sus propiedades nombre y vida (piensa c�mo acceder a ellas adecuadamente) y ejecuta su m�todo CalcularNivel(), mostrando sus niveles por consola.Una vez ejecutado este m�todo, enc�rgate de que no se pueda volver a ejecutar.Puedes apoyarte en una variable tipo bool, por ejemplo �yaEjecutado




{
    //VARIABLES ATRIBUTOS O PROPIEDADES
   private string nombre;
    private float vida;
    private float experiencia;

    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    //FUNCIONALIDADES
    public float CalcularNivel()
    {
        float LVL = experiencia / 1000;
        return LVL;    
    }
     
   

}
