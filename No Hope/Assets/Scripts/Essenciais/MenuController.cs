using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;

    public GameObject menuPrincipal;
    public GameObject menuPause;
    public GameObject menuMorte;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == SceneManager.GetSceneByBuildIndex(0).name)
        {
            InicializaMenu();
        }
    }

    private void Update()
    {
        MenuPause();
    }

    private void InicializaMenu()
    {
        menuPause.SetActive(false);
        menuMorte.SetActive(false);
        menuPrincipal.SetActive(true);
        AudioControle.instance.StopSomJogo();
        AudioControle.instance.StopSomHarry();
        AudioControle.instance.SomMenu();

    }

    public void MenuPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name != SceneManager.GetSceneByBuildIndex(0).name && ControleJogador.instance.EstadoAtual != ControleJogador.Estatus.Morto)
        {
            menuPause.SetActive(!menuPause.activeInHierarchy);
            if (menuPause.activeInHierarchy)
            {
                ControleJogador.instance.Pause();
                Jacob.instance.Pause();
                Inv.instance.mochila.SetActive(false);
            }
            else
            {
                ControleJogador.instance.ParaPause();
                Jacob.instance.ParaPause();
                Inv.instance.mochila.SetActive(true);
            }
        }
    }

    public void MenuMorte()
    {
        if(ControleJogador.instance.EstadoAtual == ControleJogador.Estatus.Morto && SceneManager.GetActiveScene().name != SceneManager.GetSceneByBuildIndex(0).name)
        {
            menuMorte.SetActive(true);

            if (menuMorte.activeInHierarchy)
            {
                Time.timeScale = 0f;
                Inv.instance.mochila.SetActive(false);
            }
        }
    }

    public void CarregaMenuPrincipal()
    {
        InicializaMenu();
        menuMorte.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void CarregaNovaCena(string _cena)
    {
        SceneManager.LoadScene(_cena);
    }
    public void BtnContinuar()
    {
        menuPause.SetActive(false);
        ControleJogador.instance.ParaPause();
        Jacob.instance.ParaPause();
        Inv.instance.mochila.SetActive(true);
    }

    public void BtnJogarNovamente()
    {
        ControleJogador.instance.EstadoAtual = ControleJogador.Estatus.Explorando;
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        menuMorte.SetActive(false);
        Time.timeScale = 1f;
    }
}
