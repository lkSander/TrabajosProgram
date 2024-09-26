using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.Analytics;
using UnityEngine.WSA;
using Unity.Burst.Intrinsics;
using UnityEngine.Rendering.VirtualTexturing;

public class Personaje : MonoBehaviour

//    //8.1. Crear una clase Personaje, con propiedades privadas nombre, vida y experiencia. Crear también el método float CalcularNivel()
//    //para calcular el nivel de un personaje aplicando la siguiente ecuación: LVL = EXP / 1000 y que lo devuelva a su salida.Genera dos cápsulas que sirvan como instancia de dicha clase.
//Referencia a los personajes desde el GameManager y genera en este un método nuevo, PrepararPersonajes(), el cual será ejecutado al pulsar Espacio.
//En dicho método, para cada personaje da valor a sus propiedades nombre y vida (piensa cómo acceder a ellas adecuadamente) y ejecuta su método CalcularNivel(), mostrando sus niveles por consola.Una vez ejecutado este método, encárgate de que no se pueda volver a ejecutar.Puedes apoyarte en una variable tipo bool, por ejemplo “yaEjecutado


//8.4. Añade en tu clase Personaje un par de propiedades nuevas:
//Enemigo (Hace referencia al otro personaje en escena)
//Mi Sistema de vidas (hace referencia al sistema de vidas correspondiente).
//Mi Arma (hace referencia al arma de nuestro personaje)


//Añadamos controles a nuestros personajes:
//Haz que pulsando una tecla (a tu elección), nuestro personaje pueda recibir una cura a partir de su sistema de vidas. Serializa una instancia de la clase KeyCode para que cada personaje tenga su propia tecla.
//Haz que pulsando otra tecla (a tu elección), nuestro personaje haga daño a su enemigo. Lo hará a partir de su arma. Serializa una instancia de la clase KeyCode para que cada personaje tenga su propia tecla.
//Para ello, ejecuta el método UtilizarArma() de tu arma, y después haz que el enemigo Reciba Daño pasando por parámetro un valor randomizado entre el mínimo y el máximo daño del arma. Esto se hará siempre y cuando el método UtilizarArma() devuelva un 0 (uso exitoso)
//En el caso de que devuelva un -1, sacaremos un mensaje del tipo “Reload!!!”
//Por lo tanto, haz que pulsando otra tecla (a tu elección), nuestro personaje recargue su arma. Ante una carga fallida (dato de vuelta = -1), muestra un mensaje del tipo “Arma ya cargada”.


{
    //VARIABLES ATRIBUTOS O PROPIEDADES
   private string nombre;
    private float vida;
    private float experiencia;
    private Personaje enemigo;

    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    //FUNCIONALIDADES

    void Start()
    {
        Movimiento();
    }
    public float CalcularNivel()
    {
        float LVL = experiencia / 1000;
        return LVL;    
    }
     void Movimiento()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            //SistemaVida.RecibirCura(float cantidad);

        }







    }
   

}
