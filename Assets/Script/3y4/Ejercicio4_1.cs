using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using static UnityEditor.PlayerSettings;
public class Ejercicio4_1 : MonoBehaviour
{
    //    Crea una aplicaci�n que nos calcule el �rea de un c�rculo, cuadrado o tri�ngulo.Crea un  m�todo por cada figura para calcular cada �rea.
    //        Cada uno de estos m�todos tendr�n como  par�metros de entrada los datos necesarios (medidas) para calcular dichas �reas.Cada m�todo devolver� el resultado del �rea.
    //    Ejecuta estos m�todos con valores de ejemplo desde el Start() y muestra el resultado que devuelven por consola.
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
        Debug.Log("El �readel c�rculo es " + resultadoCirculo + ". El �rea del tri�ngulo es " + resultadoTriangulo+ ". El �rea del cuadrado es "+ resultadoCuadrado + ".");
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
