using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Alvo : MonoBehaviour
{
    public NPCConversation longe;
    public GameObject alavanca;
    public bool puxar = false;
    [SerializeField] private GameObject texto;
    [SerializeField] private Animator an;
    private bool flag = false;
    [SerializeField] private AudioSource somAlav;


    private void Awake()
    {
        texto.SetActive(false);
    }

    private void OnMouseEnter()
    {
        texto.SetActive(true);
    }

    private void OnMouseOver()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        texto.transform.position = mousePos;
        if (Input.GetMouseButtonDown(0) && flag == true && Chave.instance.chave == false)
        {
            puxar = !puxar;
            an.SetBool("Ativar", puxar);
            somAlav.Play();
        }

        if (Input.GetMouseButtonDown(0) && flag == false && Chave.instance.chave == false)
        {
            ConversationManager.Instance.StartConversation(longe);
        }
    }


    private void OnMouseExit()
    {
        texto.SetActive(false);
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