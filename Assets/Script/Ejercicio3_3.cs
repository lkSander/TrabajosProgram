using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{

    //Desarrolla un programa que lee un n�mero entero por el Inspector y almacena el doble y el triple de ese n�mero en otras dos variables.
    //    Despu�s, mostrar el contenido de estas dos �ltimas variables por consola.

    [SerializeField] int numeroEntero;
    int doble = 0;
    int triple = 0;


    // Start is called before the first frame update
    void Start()
    {
        doble = numeroEntero * 2;
        triple = numeroEntero * 3;

        Debug.Log("El doble es: " + doble + " y el triple es: " + triple + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
