using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaFecha : MonoBehaviour
{

    private void Start()
    {
        GetComponent<Collider2D>().enabled = false;
    }

    private void Fecha()
    {
        if(Cutscene.instance.comecoCutscene == true)
        {
            GetComponent<Collider2D>().enabled = true;
        }
    }
}
