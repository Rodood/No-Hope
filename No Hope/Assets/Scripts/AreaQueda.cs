using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaQueda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("Player"))
        {
            ControleJogador.instance.cai = false;
        }
    }
}
