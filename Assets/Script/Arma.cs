using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEditor.Search;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Arma : MonoBehaviour
{

    //8.3. Crea un cuadrado a modo de arma en cada uno de tus personajes. Crea una clase llamada Arma y asóciala con dichos gameObjects.
    //    Incluye en dicha clase las siguientes propiedades:
    //Danho minimo(Serializada)
    //Danho máximo(Serializada)
    //Capacidad Total(Serializada)
    //Si es automática(o no) (Serializada)
    //Munición actual


    //Al empezar el juego, nuestra arma ha de empezar con tanta munición como indique la capacidad total del arma.
    //Incluye los siguientes métodos:
    //UtilizarArma() : Simplemente decrementamos su munición en 1 siempre y cuando nos quede munición.En ese caso, devolveremos un 0. Si no nos queda munición en el arma, devolveremos un -1.
    //RecargarArma(): Simplemente ponemos en nuestra arma tanta munición como capacidad total tenga el arma, siempre y cuando no esté ya totalmente cargada. En el caso de haber hecho una carga satisfactoria, devolveremos un 0, si no, un -1.

    [SerializeField] private float danhoMinimo;
    [SerializeField] private float danhoMaximo;
    [SerializeField] private float capacidadTotal;
                     private float municion;
    [SerializeField] private bool automatica = false;

    void Start()
    {
        municion = capacidadTotal;
        municion=UtilizarArma();
        municion= RecargarArma();
    }
    float UtilizarArma()
    {

        if (municion > 0)
        {
            return municion--;
        }
        if(municion<0)
        {
            return municion = -1;
        }
        else
        {
            return municion = 0;
        }
    }
    float RecargarArma()
    {
        float recarga;
        if(municion>= capacidadTotal)
        {

            municion= capacidadTotal;
            return recarga = -1;

        }
        else
        {
            recarga = capacidadTotal;
            return recarga = 0;
        }
       
    }
}
