using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{
    public static Chave instance;

    public GameObject texto;
    private Vector2 target;
    [SerializeField] private float speed;
    public bool chave = false;

    private void Awake()
    {
        texto.SetActive(false);
        instance = this;
    }

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        if (GameObject.Find("Alavanca Chave").GetComponent<Alvo>().puxar == true)
        {
            {
                Vector2 target = new Vector2(4, -1);
                transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
                chave = true;
            }
        }
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
    }

    private void OnMouseExit()
    {

        texto.SetActive(false);
    }

}
