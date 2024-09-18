using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;
using UnityEngine.XR;
public class Ejercicio4_2 : MonoBehaviour
{
//    Crea un método llamado “ConstruirNombre” que reciba por parámetros de entrada  los datos de una persona:
//        nombre, apellido1, apellido2, edad.Estos datos han de ser combinados dentro del método para que este devuelva 
//        a su salida un texto con toda la información de la persona.Por ejemplo: “La persona se llama Pepe Rodríguez Jiménez y  tiene 20 años”.
//Ejecuta este método con valores de ejemplo desde el Start() y muestra el resultado que devuelve por consola.



    // Start is called before the first frame update
    void Start()
    {
        string nombreCompleto = ConstruirNombre("Sander ", "Alcott", " Kyle");
        Debug.Log(nombreCompleto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string ConstruirNombre(string nombre, string apellido1, string apellido2)
    {
        string nombreCompleto= nombre + apellido1 + apellido2;
        return nombreCompleto;
    }

}
