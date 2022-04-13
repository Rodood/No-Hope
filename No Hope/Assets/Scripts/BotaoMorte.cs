using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoMorte : MonoBehaviour
{

    public void Recomeco()
    {
        MenuController.instance.CarregaMenuPrincipal();
        SceneManager.LoadScene(0);
    }
}
