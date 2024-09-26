using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    // Start is called before the first frame update

    //    Haz un programa que, dependiendo del identificativo “tipo” que se le dé, genere un enemigo u otro.
    //Muestra por consola el daño y la vida del enemigo generado. 

    [SerializeField] int tipo, daño, vida;

    void Start()
    {

        if(tipo==1) 
        {
            daño = 350;
            vida = 650;
            Debug.Log("Se ha generado un enemigo de tipo "+ tipo+ " daño "+ daño+ " y vida "+  vida + ".");
        }
        else if(tipo==2) 
        {
            daño = 300;
            vida = 550;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " daño " + daño + " y vida " + vida + ".");
        }
       else  if(tipo==3) 
        {
            daño = 300;
            vida = 500;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " daño " + daño + " y vida " + vida + ".");
        }
        else if(tipo==4) 
        {
            daño = 310;
            vida = 460;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " daño " + daño + " y vida " + vida + ".");
        }
        else if(tipo==5) 
        {
            daño = 280;
            vida = 490;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " daño " + daño + " y vida " + vida + ".");
        }
        else
        {
            daño = 360;
            vida = 520;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " daño " + daño + " y vida " + vida + ".");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
