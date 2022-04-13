using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class MorteHarry : MonoBehaviour
{
    public static MorteHarry instance;
    public NPCConversation apareceChave;
    public bool morre = false;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        Cena();
    }

    private void Cena()
    {
       if(Cutscene.instance.comecoCutscene == true && morre == false)
        {
            ControleJogador.instance.IniciaDialogo();
            Jacob.instance.IniciaDialogo();
            ConversationManager.Instance.StartConversation(apareceChave);
            morre = true;
        }
    }

    public void FinalizaDialogo()
    {
        ControleJogador.instance.TerminaDialogo();
        Jacob.instance.TerminaDialogo();
    }
}
