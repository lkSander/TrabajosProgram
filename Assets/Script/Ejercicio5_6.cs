using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    // Start is called before the first frame update

    //Cada 10 niveles, un Pok�mon aprende un ataque diferente.Necesitamos saber cu�ndo  llega a dichos niveles. 
    //    Para ello, desarrolla un programa que lea un n�mero entero por el Inspector (nivel) y muestre si el n�mero es m�ltiplo de 10.  
    [SerializeField] float nivel;

    void Start()
    {
        if(nivel % 10==0)
        {
            Debug.Log("El nivel del Pokemon es multiplo de 10, va a Digievolu...perd�n, va a evolucionar.");
        }
        else
        {
            Debug.Log("No es multiplo de diez.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
