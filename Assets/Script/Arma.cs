using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEditor.Search;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Arma : MonoBehaviour
{

    //8.3. Crea un cuadrado a modo de arma en cada uno de tus personajes. Crea una clase llamada Arma y as�ciala con dichos gameObjects.
    //    Incluye en dicha clase las siguientes propiedades:
    //Danho minimo(Serializada)
    //Danho m�ximo(Serializada)
    //Capacidad Total(Serializada)
    //Si es autom�tica(o no) (Serializada)
    //Munici�n actual


    //Al empezar el juego, nuestra arma ha de empezar con tanta munici�n como indique la capacidad total del arma.
    //Incluye los siguientes m�todos:
    //UtilizarArma() : Simplemente decrementamos su munici�n en 1 siempre y cuando nos quede munici�n.En ese caso, devolveremos un 0. Si no nos queda munici�n en el arma, devolveremos un -1.
    //RecargarArma(): Simplemente ponemos en nuestra arma tanta munici�n como capacidad total tenga el arma, siempre y cuando no est� ya totalmente cargada. En el caso de haber hecho una carga satisfactoria, devolveremos un 0, si no, un -1.

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
