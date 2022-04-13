using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleJogador : MonoBehaviour
{
    public static ControleJogador instance;

    public enum Estatus
    {
        Explorando,
        Conversando,
        Pausa,
        Morto,
        Cai
    }

    [SerializeField] private Rigidbody2D rb;
    private Vector2 movimento;
    [SerializeField] private float Velocidade;
    [SerializeField] private LayerMask camadaInteracao;
    private Vector2 alvo;
    [SerializeField] private float perspectiveScale;
    [SerializeField] private float scaleRatio;
    RaycastHit2D hitInfo;
    [SerializeField] private Animator anim;
    public bool andar = true;
    public Estatus EstadoAtual;
    private Vector2 posAtual;
    public bool cai = false;


    private void Awake()
    {
        instance = this;
        EstadoAtual = Estatus.Explorando;
    }

    private void Update()
    {
        Estado();
        MudarPerspectiva();
        PointClick();
        Animacoes();
    }

    private void FixedUpdate()
    {
        Movimento();
    }

    private void Inputs()
    {
        if(andar == true)
        {
            movimento.x = Input.GetAxisRaw("Horizontal");
            movimento.y = Input.GetAxisRaw("Vertical");
        }
    }

    void PointClick()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Ray2D ray2d = new Ray2D (mousePos, Vector2.zero);
        hitInfo = Physics2D.Raycast(ray2d.origin, ray2d.direction, 1000f, camadaInteracao);


        if (!hitInfo) return;

        switch (hitInfo.collider.gameObject.tag)
        {
            case "Item":
                InteracaoItem();
                break;

            case "Alavanca":
                InteracaoAlavanca();
                break;
        }

        
    }

    private void InteracaoItem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Item: " + hitInfo.collider.gameObject.name);
        }
    }

    public void InteracaoAlavanca()
    {
        if(Input.GetMouseButtonDown(0))
        {
           
        }

        
    }

    private void Movimento()
    {
        rb.velocity = movimento * Velocidade;
    }

    public void Estado()
    {
        switch (EstadoAtual)
        {
            case Estatus.Explorando:
                Inputs();
                break;
            case Estatus.Conversando:
                break;
            case Estatus.Morto:
                MenuController.instance.MenuMorte();
                break;
            case Estatus.Pausa:
                break;
            case Estatus.Cai:
                Cair();
                Inputs();
                break;
            default:
                break;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        alvo = transform.position;
    }

    private void MudarPerspectiva()
    {
        Vector3 scale = transform.localScale;
        scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
    }

    private void Animacoes()
    {
        anim.SetFloat("Horizontal", movimento.x);
        anim.SetFloat("Vertical", movimento.y);
        anim.SetFloat("Velocidade", movimento.sqrMagnitude);
    }

    public void IniciaDialogo()
    {
        EstadoAtual = Estatus.Conversando;
        movimento = Vector2.zero;
    }

    public void TerminaDialogo()
    {
        EstadoAtual = Estatus.Explorando;
    }

    public void Pause()
    {
        EstadoAtual = Estatus.Pausa;
        movimento = Vector2.zero;
    }

    public void Cair()
    {
        if (cai == true)
        {
            Vector2 posAtual = new Vector2((float)-3.6, (float)-0.33);
            transform.position = Vector2.MoveTowards(transform.position, posAtual, Time.deltaTime * Velocidade);
        }

        if (cai == false)
        {
            EstadoAtual = Estatus.Explorando;
        }
    }

    public void ParaPause()
    {
        EstadoAtual = Estatus.Explorando;
    }
}
