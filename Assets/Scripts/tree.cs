using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(Grow());
    }

    private void Update()
    {
        
    }

    IEnumerator Grow()
    {
        for (int i = 0; i < 99; i++)
        {
            gameObject.transform.localScale += new Vector3(1, 1, 1);
            yield return new WaitForSeconds(0.07f);
        }
        
    }
}
