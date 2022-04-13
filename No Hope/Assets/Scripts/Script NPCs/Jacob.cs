using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jacob : MonoBehaviour
{
    public static Jacob instance;
    public enum Estatus
    {
        explorando,
        conversando,
        pausa
    }

    //[SerializeField] private Rigidbody2D rb;
    private Vector2 movimento;
    [SerializeField] private float Velocidade;
    [SerializeField] private Animator anim;
    [SerializeField] private float perspectiveScale;
    [SerializeField] private float scaleRatio;
    [SerializeField] private GameObject alvo;
    public Estatus EstadoAtual;
    [SerializeField] private AudioSource somFoice;
    


    private void Awake()
    {
        instance = this;
        EstadoAtual = Estatus.conversando;
    }

    private void Start()
    {
       
    }

    private void Update()
    {
        MudarPerspectiva();
        Estado();
    }

    public void Animacoes()
    {
        //anim.SetFloat("Horizontal", movimento.x);
        // anim.SetFloat("Vertical", movimento.y);
        // anim.SetFloat("Velocidade", movimento.sqrMagnitude);
        anim.SetTrigger("HarryMorre");
    }

    private void Movimento()
    {
        transform.position = Vector2.MoveTowards(transform.position, alvo.transform.position, Velocidade * Time.deltaTime);
    }

    private void MudarPerspectiva()
    {
        Vector3 scale = transform.localScale;
        scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
    }

    public void Estado()
    {
        switch (EstadoAtual)
        {
            case Estatus.explorando:
                Movimento();
                break;
            case Estatus.conversando:
                break;
            case Estatus.pausa:
                break;
            default:
                break;
        }
    }

    public void IniciaDialogo()
    {
        EstadoAtual = Estatus.conversando;
        movimento = Vector2.zero;
    }

    public void TerminaDialogo()
    {
        EstadoAtual = Estatus.explorando;
    }

    public void Pause()
    {
        EstadoAtual = Estatus.pausa;
        movimento = Vector2.zero;
    }

    public void ParaPause()
    {
        EstadoAtual = Estatus.explorando;
    }

    public void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("Player"))
        {
            Animacoes();
            somFoice.Play();
            ControleJogador.instance.EstadoAtual = ControleJogador.Estatus.Morto;
        }
    }
}
