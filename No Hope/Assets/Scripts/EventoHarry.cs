using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoHarry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioControle.instance.StopSomMenu();
        AudioControle.instance.StopSomJogo();
        AudioControle.instance.SomHarry();
    }


}
