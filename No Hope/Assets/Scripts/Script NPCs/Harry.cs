using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harry : MonoBehaviour
{
    public static Harry instance;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 movimento;
    [SerializeField] private float Velocidade;
    [SerializeField] private Animator anim;
    private Vector2 alvo;
    [SerializeField] private float perspectiveScale;
    [SerializeField] private float scaleRatio;
    public bool morre = false;
    

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        MudarPerspectiva();
    }

    public void Animacoes()
    {
        /*anim.SetFloat("Horizontal", movimento.x);
        anim.SetFloat("Vertical", movimento.y);
        anim.SetFloat("Velocidade", movimento.sqrMagnitude);*/
        anim.SetTrigger("HarryMorre");
    }

    private void Movimento()
    {
        // if ()
        {

        }
        //Vector2 alvo = new Vector2(4, -1);
        //transform.position = Vector2.MoveTowards(transform.position, alvo, Time.deltaTime * Velocidade);
    }

    private void MudarPerspectiva()
    {
        Vector3 scale = transform.localScale;
        scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
    }
}
