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
    
    public int ID;
    // Start is called before the first frame update
    private void Start()
    {
        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Board").transform,false);
        ID = Random.Range(0, 1000);
    }

    public void ToggleSelection()
    {
        selected = !selected;
        switch (selected)
        {
            case true:
                gameObject.transform.GetChild(0).GetComponent<Renderer>().material = sel;
                Debug.Log("Selected");
                break;
            case false:
                gameObject.transform.GetChild(0).GetComponent<Renderer>().material = unsel;
                Debug.Log("UnSelected");
                break;
                
        }
    }
}
