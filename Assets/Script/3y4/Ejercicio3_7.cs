using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{


    //Se desea desarrollar un programa para calcular el �rea de visi�n de un enemigo.
    //    Dicha  �rea tiene forma de un cono o tri�ngulo. Programa que lea por el Inspector la base y 
    //    la  altura de un tri�ngulo cualquiera y que calcule el �rea de dicho tri�ngulo, almacenando este 
    //    dato en una nueva variable.Despu�s, mostrar el contenido de esta variable por consola. 

    [SerializeField] float baseTriangulo;    
    [SerializeField] float alturaTriangulo;
    float areaTriangulo = 0;




    // Start is called before the first frame update
    void Start()
    {
        areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Debug.Log("El �rea del tri�ngulo es " + areaTriangulo + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
