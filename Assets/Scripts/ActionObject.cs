using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ActionObject : MonoBehaviour
{
    public bool CanDestroy = false;
    public bool CanClick = false;

    public GameObject OnTile;

    public void Start()
    {
        OnTile = GameObject.Find("Player").GetComponent<Selector>().Selected;
    }

    public void Interact()
    {
        if (CanClick)
        {
            OnTile.GetComponent<SpawnCube>().Occupied = false;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
