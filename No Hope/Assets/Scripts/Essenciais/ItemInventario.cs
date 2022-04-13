using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemInventario : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform localOrigem;
    private int posicaoInv;
    [SerializeField] private AudioSource somDrag;
    
    private bool foiUtilizado = false;
   
    public void OnBeginDrag(PointerEventData eventData)
    {
        localOrigem = transform.parent;
        posicaoInv = transform.GetSiblingIndex();
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        somDrag.Play();

        transform.SetParent(transform.parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }



    public void OnEndDrag(PointerEventData eventData)
    {
        if (foiUtilizado)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.SetParent(localOrigem);
            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
    }

    public void UtilizaItem(bool _valor)
    {
        foiUtilizado = _valor;
    }
}
