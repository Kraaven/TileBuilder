using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.SetParent(GameObject.FindGameObjectWithTag("Board").transform,false);
        gameObject.transform.Rotate(0,Random.Range(0,4)*90,0);
    }

}
