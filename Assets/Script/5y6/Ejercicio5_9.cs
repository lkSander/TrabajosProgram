using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    // Start is called before the first frame update

    //    Haz un programa que, dependiendo del identificativo �tipo� que se le d�, genere un enemigo u otro.
    //Muestra por consola el da�o y la vida del enemigo generado. 

    [SerializeField] int tipo, da�o, vida;

    void Start()
    {

        if(tipo==1) 
        {
            da�o = 350;
            vida = 650;
            Debug.Log("Se ha generado un enemigo de tipo "+ tipo+ " da�o "+ da�o+ " y vida "+  vida + ".");
        }
        else if(tipo==2) 
        {
            da�o = 300;
            vida = 550;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " da�o " + da�o + " y vida " + vida + ".");
        }
       else  if(tipo==3) 
        {
            da�o = 300;
            vida = 500;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " da�o " + da�o + " y vida " + vida + ".");
        }
        else if(tipo==4) 
        {
            da�o = 310;
            vida = 460;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " da�o " + da�o + " y vida " + vida + ".");
        }
        else if(tipo==5) 
        {
            da�o = 280;
            vida = 490;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " da�o " + da�o + " y vida " + vida + ".");
        }
        else
        {
            da�o = 360;
            vida = 520;
            Debug.Log("Se ha generado un enemigo de tipo " + tipo + " da�o " + da�o + " y vida " + vida + ".");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
