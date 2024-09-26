using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
public class Ejercicio5_7 : MonoBehaviour
{
    // Start is called before the first frame update
    //En un combate por turnos de hasta 3 jugadores, se desea saber qué orden se va a  establecer en sus turnos de ataque.
    //    Atacará primero el de mayor velocidad.Para ello, desarrolla un programa que calcule el mayor de tres números enteros 
    //    (las diferentes  velocidades) dados por el Inspector.

    [SerializeField] int velocidad1, velocidad2, velocidad3;
    


    void Start()
    {
        if (velocidad1 > velocidad2 && velocidad2 > velocidad3)
        {
            Debug.Log("El más rápido es el: " + velocidad1);
            if(velocidad2 > velocidad3)
            {
                Debug.Log("El segundo es el: "+  velocidad2);
                Debug.Log("El tercero es el: " + velocidad3);
            }
            else
            {
                Debug.Log("El segundo es el: " + velocidad3);
                Debug.Log("El tercero es el: "+ velocidad2);
            }
        }

        else if (velocidad2 > velocidad1 && velocidad1 > velocidad3)
        {
            Debug.Log("El más rápido es el: " + velocidad2);
            if (velocidad1 > velocidad3)
            {
                Debug.Log("El segundo es el: " + velocidad1);
                Debug.Log("El tercero es el: " + velocidad3);
            }
            else
            {
                Debug.Log("El segundo es el: " + velocidad3);
                Debug.Log("El tercero es el: " + velocidad1);
            }
        }
        else if (velocidad3 > velocidad2 && velocidad2 > velocidad1)
        {
            Debug.Log("El más rápido es el: " + velocidad3);
            if (velocidad2 > velocidad1)
            {
                Debug.Log("El segundo es el: " + velocidad2);
                Debug.Log("El tercero es el: " + velocidad1);
            }
            else
            {
                Debug.Log("El segundo es el: " + velocidad1);
                Debug.Log("El tercero es el: " + velocidad2);
            }
        }









    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
