using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
            // Get the mouse position in screen coordinates
            Vector3 mousePosition = Input.mousePosition;

            // Create a ray from the camera through the mouse position
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);

            // Perform the raycast
            Debug.Log("Shot");
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // If the ray hits a collider, do something
                Debug.Log("Hit object with ID: " + hit.collider.gameObject.transform.parent.GetComponent<SpawnCube>().ID);
                hit.collider.gameObject.transform.parent.GetComponent<SpawnCube>().ToggleSelection();


                // You can add more actions based on the hit information
            }
        }
    }
}
