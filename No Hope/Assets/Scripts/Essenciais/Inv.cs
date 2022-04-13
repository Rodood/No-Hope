using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inv : MonoBehaviour
{
    public static Inv instance;
    public GameObject mochila;
    [SerializeField] private float limiteItens;
    public bool espaco = true;
      

    private List<GameObject> itensInv = new List<GameObject>();
    [SerializeField] private Transform localItens;


    private void Awake()
    {
        instance = this;
    }

    public void AdicionaItem(GameObject _item)
    {
        if (!PossuiEspaco())
        {
            return;
        }

        GameObject _itemNovo = Instantiate(_item, localItens);
        _itemNovo.name = _item.name;  
        itensInv.Add(_itemNovo);
        
    }

    public void RemoveItem(GameObject _item)
    {
        itensInv.Remove(_item);
    }

    public bool PossuiEspaco()
    {
        return itensInv.Count < limiteItens;
    }

    public void Inventario()
    {
        mochila.SetActive(!mochila.activeInHierarchy);
    }
}
