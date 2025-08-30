using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public Vector3[] house = { new Vector3(0, 0, 0), new Vector3(1, 0, 0), new Vector3(1, 0, 0), new Vector3(1, 1, 0), new Vector3(1, 1, 0), new Vector3(0.5f, 2, 0), new Vector3(0.5f, 2, 0), new Vector3(0, 1, 0), new Vector3(0, 1, 0), new Vector3(0, 0, 0) };

    void Start()
    {

    }

    // Update is called once per frame
    void OnDrawGizmos()
    {
        Gizmos.DrawLineList(house);
    }
}