using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
public class Ejercicio7_12 : MonoBehaviour
{
    //Crea un m�todo llamado �SumarTodosLosNumeros� al que se le pasen dos n�meros enteros cualquiera por par�metro de entrada.
    //    El m�todo sumar� todos los n�meros  comprendidos entre estos dos(ambos inclusive) y devolver� a su salida la suma calculada.

    // Start is called before the first frame update

    
    

    void Start()
    {
        int resultadoSuma=SumarTodosLosNumeros(2, 10);
        Debug.Log(resultadoSuma);
    }

    // Update is called once per frame
   int SumarTodosLosNumeros(int num1, int num2)
    {

        int suma = 0;
        if (num1>num2)
        {
            for (int contar = num2; contar == num1; contar++)
            {
                Debug.Log(contar);
                suma = suma + contar;
            }
        }
        if (num1 < num2)
        {
            for (int contar = num1; contar == num2; contar++)
            {
                Debug.Log(contar);
                suma = suma + contar;
            }
        }

        return suma;
    }
}
