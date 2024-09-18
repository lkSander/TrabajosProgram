using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    // Start is called before the first frame update

    //Cada 10 niveles, un Pokémon aprende un ataque diferente.Necesitamos saber cuándo  llega a dichos niveles. 
    //    Para ello, desarrolla un programa que lea un número entero por el Inspector (nivel) y muestre si el número es múltiplo de 10.  
    [SerializeField] float nivel;

    void Start()
    {
        if(nivel % 10==0)
        {
            Debug.Log("El nivel del Pokemon es multiplo de 10, va a Digievolu...perdón, va a evolucionar.");
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
