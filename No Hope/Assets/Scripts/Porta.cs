using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Porta : MonoBehaviour, IDropHandler
{
    [SerializeField] private GameObject objetoDrop;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource somPorta;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag.name == objetoDrop.name)
        {
            animator.SetTrigger("Chave");
            GetComponent<Collider2D>().enabled = false;
            eventData.pointerDrag.GetComponent<ItemInventario>().UtilizaItem(true);
            somPorta.Play();
        }
    }

}
