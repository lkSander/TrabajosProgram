using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //8.1 Referencia a los personajes desde el GameManager y genera en este un método nuevo, PrepararPersonajes(), el cual será ejecutado al pulsar Espacio.

    // Start is called before the first frame update
    [SerializeField] private Personaje Link;
    [SerializeField] private Personaje Zelda;

    private bool calculoHecho = false;
    void Start()
    {
        Input.GetKeyDown(KeyCode.Escape);
        {
            PrepararPersonajes();
        }
        
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
