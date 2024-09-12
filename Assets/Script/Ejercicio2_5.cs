using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;
public class Ejercicio2_5 : MonoBehaviour
{

  
    //int vidasInicialPlayer1 = 10;
    int vidasInicialPlayer2 = 12;
    //int vidasInicialPlayer3 = 8;
    //int vidasInicialPlayer4 = 18;

    int vidasPlayer1 = 10;
    int vidasPlayer2 = 12;
    int vidasPlayer3 = 8;
    int vidasPlayer4 = 18;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Vidas del Player1: " + vidasPlayer1 + "Vidas del Player2: " + vidasPlayer2 + "Vidas del Player3: " + vidasPlayer3 + "Vidas del Player4: " + vidasPlayer4);
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasInicialPlayer2;





    }
}
