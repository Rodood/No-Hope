using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ArnoldInicio : MonoBehaviour
{
    public NPCConversation myConversation;
    public bool DialogoFinalizado;

    private void Start()
    { 
        ControleJogador.instance.IniciaDialogo();
        ConversationManager.Instance.StartConversation(myConversation);

    }

    public void FinalizaDialogo()
    {
        ControleJogador.instance.TerminaDialogo();
    }
}
