using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Coletavel : MonoBehaviour
{
    [SerializeField] private GameObject itemInvPrefab;
    private bool flag = false;
    [SerializeField] private AudioSource somItem;
    public NPCConversation longe;


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && flag == true && Inv.instance.PossuiEspaco())
        {
            if(Inv.instance.espaco == true)
            {
                //Da ao jogador o item coletado
                Inv.instance.AdicionaItem(itemInvPrefab);

                somItem.Play();

                //destroi este item ou desativa
                Destroy(gameObject);

                GetComponent<Chave>().texto.SetActive(false);
                //GetComponent<Chave>().chave = true;
            }
        }

        if (Input.GetMouseButtonDown(0) && flag == false)
        {
            ConversationManager.Instance.StartConversation(longe);
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
