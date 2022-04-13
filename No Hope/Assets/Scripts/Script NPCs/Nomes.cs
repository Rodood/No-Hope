using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Nomes : MonoBehaviour
{
    [SerializeField] private GameObject texto;
    public NPCConversation nomes;

    private void OnMouseEnter()
    {
        texto.SetActive(true);
    }

    private void OnMouseOver()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        texto.transform.position = mousePos;
        if (Input.GetMouseButtonDown(0))
        {
            ConversationManager.Instance.StartConversation(nomes);
        }

    }

    private void OnMouseExit()
    {
        texto.SetActive(false);
    }
}
