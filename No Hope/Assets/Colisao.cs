using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(ControleJogador.instance.EstadoAtual == ControleJogador.Estatus.Cai)
        {
            GetComponent<Collider2D>().enabled = false;
        }
        else
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
