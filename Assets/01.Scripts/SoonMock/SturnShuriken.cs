using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SturnShuriken : MonoBehaviour, IShuriken
{
    public PlayerS player;
    public float delay;


    private void Awake()
    {
        player = FindObjectOfType<PlayerS>();
    }
    public void OnHIt()
    {
        StartCoroutine(Sturn());

    }
    IEnumerator Sturn()
    {
        player.isSturn = true;
        yield return new WaitForSeconds(delay);
        player.isSturn = false;
    }
}
