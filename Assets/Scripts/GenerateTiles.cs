using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class GenerateTiles : MonoBehaviour
{
    public int tilesize = 2;
    public GameObject tile;
    public GameObject Player;
    private void Start()
    {
        Instantiate(tile, new Vector3(0, 0, 0), Quaternion.identity);
        GenTiles(tilesize);
        Collider[] tiles = Physics.OverlapBox(transform.position,new Vector3(0.1f,0.1f,0.1f));
        tiles[0].GetComponent<SpawnCube>().ToggleSelection();
        Player.GetComponent<Selector>().Selected = tiles[0].gameObject;
    }

    private void GenTiles(int size)
    {
        int iter = -1 * (size - 1);
        Vector3 currentpos = transform.position;
        for (int i = iter; i < size; i+=1)
        {
            for (int j = iter; j < size; j+=1)
            {
                if (i == size - 1 || j == size -1  || i == -1*(size-1) || j == -1*(size-1))
                {
                    Instantiate(tile, new Vector3(currentpos.x + i*2, currentpos.y,currentpos.z + j*2 ), Quaternion.identity);
                }
                
                
            }
        }
    }

    public void IncreaseSize()
    {
        tilesize++;
        GenTiles(tilesize);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            IncreaseSize();
        }
    }
}
