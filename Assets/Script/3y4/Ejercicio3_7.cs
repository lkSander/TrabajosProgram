using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{


    //Se desea desarrollar un programa para calcular el área de visión de un enemigo.
    //    Dicha  área tiene forma de un cono o triángulo. Programa que lea por el Inspector la base y 
    //    la  altura de un triángulo cualquiera y que calcule el área de dicho triángulo, almacenando este 
    //    dato en una nueva variable.Después, mostrar el contenido de esta variable por consola. 

    [SerializeField] float baseTriangulo;    
    [SerializeField] float alturaTriangulo;
    float areaTriangulo = 0;




    // Start is called before the first frame update
    void Start()
    {
        areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Debug.Log("El área del triángulo es " + areaTriangulo + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
