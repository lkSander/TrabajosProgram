using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{

    //Tenemos un personaje de un videojuego que farmea 7 unidades de oro por segundo.Representa este dato en una variable.
    //    Haz un programa que calcule el número total de  unidades de oro farmeadas en 4h.

    int oro = 0;





    // Start is called before the first frame update
    void Start()
    {
        oro = (3600 * 4) * 7; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
