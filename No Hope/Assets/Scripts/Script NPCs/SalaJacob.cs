using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalaJacob : MonoBehaviour
{

    [SerializeField] private GameObject personagem;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Cena();
        PersonDes();
    }

    private void Cena()
    {
        if(Cutscene.instance.comecoCutscene == true)
        {
            GetComponent<Collider2D>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    public void PersonDes()
    {
        if (Harry.instance.morre == true)
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }
}
