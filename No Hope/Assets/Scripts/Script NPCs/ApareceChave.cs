using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ApareceChave : MonoBehaviour
{
    public NPCConversation apareceChave;
    private bool flag = false;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && flag == true)
        {
            ConversationManager.Instance.StartConversation(apareceChave);
        }

    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        flag = true;
    }

    private void OnCollisionExit2D(Collision2D outro)
    {
        flag = false;
    }
}
