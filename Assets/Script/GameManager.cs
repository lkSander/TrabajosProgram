using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Personaje Link;
    [SerializeField] private Personaje Zelda;

    private bool calculoHecho = false;
    void Start()
    {
        PrepararPersonajes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PrepararPersonajes()
    {
       // Link.Vida = SistemaVida.VidaInicial;
        Link.Experiencia = 2000;
        Link.Nombre = "Link";

        Zelda.Vida = 100;
        Zelda.Experiencia = 20000;
        Zelda.Nombre = "Zelda";

        if (calculoHecho == false)
        {
            Link.CalcularNivel();
            Zelda.CalcularNivel();
            calculoHecho = true;
        }
    }
}
