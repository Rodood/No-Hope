using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena : MonoBehaviour
{
    public static Cena instance;
    public bool morre = false;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject && morre == false)
        {
            Jacob.instance.Animacoes();
            Harry.instance.Animacoes();
            morre = true;
        }
    }
}
