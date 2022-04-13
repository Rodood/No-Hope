using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public static Cutscene instance;

    public bool comecoCutscene = false;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter2D(Collider2D _outro)
    {
        if (_outro.gameObject.CompareTag("Player"))
        {
            comecoCutscene = true;
        }
    }
}
