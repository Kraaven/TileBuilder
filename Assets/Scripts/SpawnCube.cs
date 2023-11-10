using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileID : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Board").transform,false);
    }
}
