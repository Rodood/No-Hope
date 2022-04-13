using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arnold : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Vector2 movimento;
    [SerializeField] private float Velocidade;
    [SerializeField] private Animator anim;
    private Vector2 alvo;
    [SerializeField] private float perspectiveScale;
    [SerializeField] private float scaleRatio;

    private void Awake()
    {
        
    }

    private void Update()
    {
        Animacoes();
        MudarPerspectiva();
        Movimento();
    }

    private void Animacoes()
    {
        anim.SetFloat("Horizontal", movimento.x);
        anim.SetFloat("Vertical", movimento.y);
        anim.SetFloat("Velocidade", movimento.sqrMagnitude);
    }

    private void Movimento()
    {
        //if(GetComponent<MorteHarry>().morre == true)
        {
            //Vector2 alvo = new Vector2((float)1.5, (float)-0.2);
            //transform.position = Vector2.MoveTowards(transform.position, alvo, Time.deltaTime * Velocidade);
        }
    }

    private void MudarPerspectiva()
    {
        Vector3 scale = transform.localScale;
        scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
    }
}
