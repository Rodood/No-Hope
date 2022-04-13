using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AreaDrop : MonoBehaviour
{
    public static AreaDrop instance;
    public bool cena = false;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    private void Update()
    {
        Cabeca();
    }

    public void Cabeca()
    {
        if(cena == true)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
