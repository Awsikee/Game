using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour
{
    public GameObject p3;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "p")
        {
            Debug.Log("Collision detected");
            p3.GetComponent<Renderer>().enabled = false;
        }
    }
}

