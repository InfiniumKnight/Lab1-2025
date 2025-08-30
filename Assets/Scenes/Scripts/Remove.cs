using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Remove : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    [ContextMenu("Reset Object")]
    void ResetObject()
    {
        DestroyImmediate(rb);
        transform.position = new Vector3(0, 0, 0);
    }
}
