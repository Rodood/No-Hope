using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JacóMata : MonoBehaviour
{
    public void InicioDialogo()
    {
        Jacob.instance.TerminaDialogo();
    }

    public void Cutscene()
    {
        Jacob.instance.IniciaDialogo();
    }
}
