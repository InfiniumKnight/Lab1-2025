using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Chessboard : MonoBehaviour
{
    private Vector2 horizontalBegin = new Vector2(0, 0);
    private Vector2 horizontalEnd = new Vector2(8, 0);

    private Vector2 verticalBegin = new Vector2(0, 0);
    private Vector2 verticalEnd = new Vector2(0, 8);

    //private bool done = false;


    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawLine(new Vector2(0, 0), new Vector2(8, 0));
        Gizmos.DrawLine(new Vector2(0, 1), new Vector2(8, 1));
        Gizmos.DrawLine(new Vector2(0, 2), new Vector2(8, 2));
        Gizmos.DrawLine(new Vector2(0, 3), new Vector2(8, 3));
        Gizmos.DrawLine(new Vector2(0, 4), new Vector2(8, 4));
        Gizmos.DrawLine(new Vector2(0, 5), new Vector2(8, 5));
        Gizmos.DrawLine(new Vector2(0, 6), new Vector2(8, 6));
        Gizmos.DrawLine(new Vector2(0, 7), new Vector2(8, 7));
        Gizmos.DrawLine(new Vector2(0, 8), new Vector2(8, 8));

        Gizmos.DrawLine(new Vector2(0, 0), new Vector2(0, 8));
        Gizmos.DrawLine(new Vector2(1, 0), new Vector2(1, 8));
        Gizmos.DrawLine(new Vector2(2, 0), new Vector2(2, 8));
        Gizmos.DrawLine(new Vector2(3, 0), new Vector2(3, 8));
        Gizmos.DrawLine(new Vector2(4, 0), new Vector2(4, 8));
        Gizmos.DrawLine(new Vector2(5, 0), new Vector2(5, 8));
        Gizmos.DrawLine(new Vector2(6, 0), new Vector2(6, 8));
        Gizmos.DrawLine(new Vector2(7, 0), new Vector2(7, 8));
        Gizmos.DrawLine(new Vector2(8, 0), new Vector2(8, 8));

        /*if (done == false)
        {
            for (int i = 0; i < 8; i++)
            {
                Gizmos.DrawLine(new Vector2(0,i), new Vector2(8,i));
                Gizmos.DrawLine(new Vector2(i,0), new Vector2(i,8));

                horizontalBegin.y += 1;
                horizontalEnd.y += 1;
                verticalBegin.x += 1;
                verticalEnd.x += 1;
            }
            done = true;
            Debug.Log(horizontalBegin.y);
        }*/
    }

}
