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

//    //8.1. Crear una clase Personaje, con propiedades privadas nombre, vida y experiencia. Crear también el método float CalcularNivel()
//    //para calcular el nivel de un personaje aplicando la siguiente ecuación: LVL = EXP / 1000 y que lo devuelva a su salida.Genera dos cápsulas que sirvan como instancia de dicha clase.
//Referencia a los personajes desde el GameManager y genera en este un método nuevo, PrepararPersonajes(), el cual será ejecutado al pulsar Espacio.
//En dicho método, para cada personaje da valor a sus propiedades nombre y vida (piensa cómo acceder a ellas adecuadamente) y ejecuta su método CalcularNivel(), mostrando sus niveles por consola.Una vez ejecutado este método, encárgate de que no se pueda volver a ejecutar.Puedes apoyarte en una variable tipo bool, por ejemplo “yaEjecutado




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
