using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
[CustomEditor(typeof(GameObject))]
public class BorderHandleEditor : Editor
{
    private GameObject[] objects;

    public void OnEnable()
    {
        objects = GameObject.FindGameObjectsWithTag("Pieces");
    }

    void OnSceneGUI()
    {
        if(Event.current.type == EventType.Repaint)
                Handles.DrawOutline(objects, Color.black, Color.red, 0.6f);
    }

}
