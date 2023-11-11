using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnCube : MonoBehaviour
{
    public Material  sel;
    public Material unsel;
    public bool selected = false;

    public bool Occupied;
    
    public int ID;
    // Start is called before the first frame update
    private void Start()
    {
        ID = Random.Range(0, 1000);
    }

    public void ToggleSelection()
    {
        selected = !selected;
        switch (selected)
        {
            case true:
                gameObject.GetComponent<Renderer>().material = sel;
                break;
            case false:
                gameObject.GetComponent<Renderer>().material = unsel;
                break;
                
        }
    }
}
