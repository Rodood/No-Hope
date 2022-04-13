using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Teste : MonoBehaviour
{
    public static Teste instance;

    public void Cabeca()
    {
        AreaDrop.instance.cena = true;
    }

    public void FinalizaDialogo()
    {
        Harry.instance.morre = true;
    }
}
