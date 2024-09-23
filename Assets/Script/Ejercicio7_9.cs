using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Ejercicio7_9 : MonoBehaviour
{
    // Start is called before the first frame update
    //Programa que muestre los múltiplos de 3 desde 1 hasta num(entero serializado)
    [SerializeField] int numMax;
    int numContar;

    void Start()
    {
        for (int numContar = 3; numContar <= numMax; numContar = numContar+3)
        {
            Debug.Log(numContar);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
