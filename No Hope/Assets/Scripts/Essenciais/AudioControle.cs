using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControle : MonoBehaviour
{
    public static AudioControle instance;
    [SerializeField] private AudioSource somMenu;
    [SerializeField] private AudioSource somJogo;
    [SerializeField] private AudioSource somHarry;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    public void SomMenu()
    {
        somMenu.Play();
    }

    public void StopSomMenu()
    {
        somMenu.Stop();
    }

    public void SomJogo()
    {
        somJogo.Play();
    }

    public void StopSomJogo()
    {
        somJogo.Stop();
    }

    public void SomHarry()
    {
        somHarry.Play();
    }

    public void StopSomHarry()
    {
        somHarry.Stop();
    }
}
