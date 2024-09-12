using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using static UnityEngine.EventSystems.EventTrigger;

public class Ejercicio1_1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola, Mundo");
        Debug.Log("Este es el primer videojuego de Laura");
        Debug.Log("Estoy aprendiendo C#");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame"); //Al estar escrito en el bloque UPDATE, que sucede cada frame, el mensaje se repite de forma infinita hasta que pausemos.
    }
}
