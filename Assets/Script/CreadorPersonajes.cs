using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    [SerializeField] Personaje link;
    
    
    void Start()
    {
        link.Vida = 100;
    }

    
}
