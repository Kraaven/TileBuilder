using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    public GameObject Selected;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
            Vector3 mousePosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(mousePosition);

           
            Debug.Log("Shot");
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                
                Selected.GetComponent<SpawnCube>().ToggleSelection();
                Selected = hit.collider.gameObject.transform.parent.gameObject;
                Selected.GetComponent<SpawnCube>().ToggleSelection();
                
            }
        }
    }
}
