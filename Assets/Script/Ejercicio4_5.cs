using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Ejercicio4_5 : MonoBehaviour
{
    // Start is called before the first frame update

    //    Combina el ejercicio 4.1. y 4.3. de tal manera que una vez calculada el área de un triángulo/cuadrado/círculo, 
    //        dicho dato ahora lo utilicemos como una cantidad de monedas, usándolo como parámetro de entrada del método “Convertir”
    //Es decir, por ejemplo, si llamamos al método “CalcularCirculo”, y nos devuelve un  6, ese 6 nos valdría para establecer 
    //        la cantidad de dinero a convertir con el método “Convertir”
    //Ejecuta este método con valores de ejemplo desde el Start() y muestra el resultado que devuelve por consola.

    float numPi = 3.1418f;

    float diferenciaDolar = 1.11f;


    void Start()
    {
        //4.1
        float resultadoCirculo = AreaCirculo(7);
        float resultadoTriangulo = AreaTriangulo(8, 9);
        float resultadoCuadrado = AreaCuadrdo(9);
        Debug.Log("El áreadel círculo es " + resultadoCirculo + ". El área del triángulo es " + resultadoTriangulo + ". El área del cuadrado es " + resultadoCuadrado + ".");

        //4.3
        float dinero = Convertir(resultadoCuadrado, "dolares");
        dinero = Convertir(resultadoTriangulo, "dolares");
        dinero = Convertir(resultadoCirculo, "dolares");



        Debug.Log("La conversión da como resultado: " + dinero);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //4.1
    float AreaCirculo(float radio)
    {
        float areaCirculo = (radio * radio) / numPi;

        return areaCirculo;
    }
    float AreaTriangulo(float altura, float basse)
    {
        float areaTriangulo = (basse * altura) / 2;
        return areaTriangulo;

    }
    float AreaCuadrdo(float lado)
    {
        float areaCuadrdo = lado * lado;

        return areaCuadrdo;


    }
    //4.3
    float Convertir(float cantidad, string moneda)
    {
        if (moneda == "dolares")
        {
            float euros = cantidad * 1 / diferenciaDolar;

            return euros;
        }
        else
        {

            float dolares = diferenciaDolar * cantidad / 1;
            return dolares;
        }


    }
}
