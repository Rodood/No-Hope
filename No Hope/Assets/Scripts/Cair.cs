using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cair : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Player"))
        {
            ControleJogador.instance.cai = true;
            ControleJogador.instance.EstadoAtual = ControleJogador.Estatus.Cai;
        }
    }
}
