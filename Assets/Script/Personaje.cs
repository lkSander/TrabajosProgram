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

//    //8.1. Crear una clase Personaje, con propiedades privadas nombre, vida y experiencia. Crear tambi�n el m�todo float CalcularNivel()
//    //para calcular el nivel de un personaje aplicando la siguiente ecuaci�n: LVL = EXP / 1000 y que lo devuelva a su salida.Genera dos c�psulas que sirvan como instancia de dicha clase.
//Referencia a los personajes desde el GameManager y genera en este un m�todo nuevo, PrepararPersonajes(), el cual ser� ejecutado al pulsar Espacio.
//En dicho m�todo, para cada personaje da valor a sus propiedades nombre y vida (piensa c�mo acceder a ellas adecuadamente) y ejecuta su m�todo CalcularNivel(), mostrando sus niveles por consola.Una vez ejecutado este m�todo, enc�rgate de que no se pueda volver a ejecutar.Puedes apoyarte en una variable tipo bool, por ejemplo �yaEjecutado


//8.4. A�ade en tu clase Personaje un par de propiedades nuevas:
//Enemigo (Hace referencia al otro personaje en escena)
//Mi Sistema de vidas (hace referencia al sistema de vidas correspondiente).
//Mi Arma (hace referencia al arma de nuestro personaje)


//A�adamos controles a nuestros personajes:
//Haz que pulsando una tecla (a tu elecci�n), nuestro personaje pueda recibir una cura a partir de su sistema de vidas. Serializa una instancia de la clase KeyCode para que cada personaje tenga su propia tecla.
//Haz que pulsando otra tecla (a tu elecci�n), nuestro personaje haga da�o a su enemigo. Lo har� a partir de su arma. Serializa una instancia de la clase KeyCode para que cada personaje tenga su propia tecla.
//Para ello, ejecuta el m�todo UtilizarArma() de tu arma, y despu�s haz que el enemigo Reciba Da�o pasando por par�metro un valor randomizado entre el m�nimo y el m�ximo da�o del arma. Esto se har� siempre y cuando el m�todo UtilizarArma() devuelva un 0 (uso exitoso)
//En el caso de que devuelva un -1, sacaremos un mensaje del tipo �Reload!!!�
//Por lo tanto, haz que pulsando otra tecla (a tu elecci�n), nuestro personaje recargue su arma. Ante una carga fallida (dato de vuelta = -1), muestra un mensaje del tipo �Arma ya cargada�.


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
