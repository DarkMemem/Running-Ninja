using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTap : MonoBehaviour
{
    private Player pl;

    public void Start()
    {
        pl = FindObjectOfType<Player>();
    }
    public void OnTaps()
    {
        pl.MovePlayer();
    }
}
