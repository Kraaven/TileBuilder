using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Selector : MonoBehaviour
{
    public GameObject Selected;
    public GameObject Tree;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Mouse.current.position.value;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);

            
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Tile")
                {
                    Selected.GetComponent<SpawnCube>().ToggleSelection();
                    Selected = hit.collider.gameObject;
                    Selected.GetComponent<SpawnCube>().ToggleSelection();
                }
                else
                {
                    hit.collider.gameObject.GetComponent<ActionObject>().Interact();
                }
                
            }
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (Selected.GetComponent<SpawnCube>().Occupied == false)
            {
                Debug.Log(Selected.GetComponent<SpawnCube>().ID.ToString());
                Selected.GetComponent<SpawnObject>().spawnObject(Tree);
            }

        }
    }
}
