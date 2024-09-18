using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;
public class Ejercicio4_1 : MonoBehaviour
{
    //    Crea una aplicación que nos calcule el área de un círculo, cuadrado o triángulo.Crea un  método por cada figura para calcular cada área.
    //        Cada uno de estos métodos tendrán como  parámetros de entrada los datos necesarios (medidas) para calcular dichas áreas.Cada método devolverá el resultado del área.
    //    Ejecuta estos métodos con valores de ejemplo desde el Start() y muestra el resultado que devuelven por consola.
    //? Circulo: (radio^2)*PI 
    //? Triangulo: (base * altura) / 2 
    //? Cuadrado: lado* lado
    float numPi = 3.1418f;

    // Start is called before the first frame update
    void Start()
    {
       float resultadoCirculo = AreaCirculo(7);
        float resultadoTriangulo = AreaTriangulo(8, 9);
        float resultadoCuadrado = AreaCuadrdo(9);
        Debug.Log("El áreadel círculo es " + resultadoCirculo + ". El área del triángulo es " + resultadoTriangulo+ ". El área del cuadrado es "+ resultadoCuadrado + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float AreaCirculo(float radio)
    {
        float areaCirculo= (radio*radio)/numPi;   

        return areaCirculo;
    }
    float AreaTriangulo(float altura, float basse)
    {
        float areaTriangulo=(basse*altura)/2;
        return areaTriangulo;

    }
    float AreaCuadrdo(float lado)
    {
        float areaCuadrdo = lado * lado;

            return areaCuadrdo;


    }





}
