using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_2 : MonoBehaviour
{

    //Desarrolla un programa que lea un nombre por el Inspector y muestre por consola:  “Bienvenido de nuevo, <nombre_introducido>”. 
    [SerializeField] string nombre = "";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bienvenido de nuevo, " + nombre + ("."));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
