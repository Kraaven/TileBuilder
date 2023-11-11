using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    public void spawnObject(GameObject Actionobject)
    {
        Vector3 pos = transform.position;
        Instantiate(Actionobject, new Vector3(pos.x,pos.y + 0.5f,pos.z), Quaternion.identity);
        gameObject.GetComponent<SpawnCube>().Occupied = true;
    }
}
