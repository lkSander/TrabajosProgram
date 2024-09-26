using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaVida : MonoBehaviour
{

    //    Crea una clase llamada SistemaDeVida e incl�yela en tus personajes.La clase tendr� las siguientes propiedades: 
    //Vida inicial(Serializada)
    //Vida actual(Sin serializar)
    //Al empezar el juego, nuestro personaje ha de empezar con lo establecido en �Vida Inicial�.
    //Tendr� dos m�todos:
    //float RecibirCura(float cantidad): se a�ade una cantidad de cura en las vidas de nuestro personaje y devuelve la vida actual tras su suma. Si la cura introducida es negativa, no se har� nada y se devolver� un -1.
    //float RecibirDanho(float danho): se resta cierta cantidad de vida y devuelve la vida actual. Si el personaje se queda sin vidas, se devolver� un 0. Si la cantidad introducida es negativa, no se har� nada y se devolver� un -1.
  
   [SerializeField] float vidaInicial;

    private float vidaActual;

    



    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaInicial;
       vidaActual= RecibirCura(4);
        vidaActual= RecibirDanho(8);
    }

    // Update is called once per frame
   public float RecibirCura(float cantidad)
   {

        if(cantidad  < 0)
        {
            vidaActual = -1;
        }
       else
        {
            vidaActual = vidaActual + cantidad;
        }
        
    return vidaActual; 
   }      

    public float RecibirDanho(float danho)
    {
        vidaActual = vidaInicial - danho;
        if( vidaActual>=0)
        {

            vidaActual=0;
        }
        if(danho < 0)
        {
            vidaActual = -1;    
        }

        return vidaActual;


    }





}
