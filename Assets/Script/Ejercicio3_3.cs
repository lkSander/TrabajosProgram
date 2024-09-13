using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{

    //Desarrolla un programa que lee un número entero por el Inspector y almacena el doble y el triple de ese número en otras dos variables.
    //    Después, mostrar el contenido de estas dos últimas variables por consola.

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
