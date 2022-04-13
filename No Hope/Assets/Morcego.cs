using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morcego : MonoBehaviour
{
    [SerializeField] private GameObject texto;

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
    }

    private void OnMouseExit()
    {
        texto.SetActive(false);
    }
}
