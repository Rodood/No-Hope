using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruxa : MonoBehaviour
{
    [SerializeField] private GameObject texto;
    private Vector2 target;
    [SerializeField] private float speed;
    [SerializeField] private AudioSource somBruxa;

    private void Awake()
    {
        texto.SetActive(false);
        transform.position = new Vector2(-2, 2);
    }

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        if (GameObject.Find("Alavanca").GetComponent<Alvo>().puxar == true)
        {
            {
                speed = 2f;
                Vector2 target = new Vector2(-2, 6);
                transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
                somBruxa.Play();
            }
        }

        if (GameObject.Find("Alavanca").GetComponent<Alvo>().puxar == false)
        {
            {
                speed = 10f;
                Vector2 target = new Vector2(-2, 2);
                transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * speed);
                
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
