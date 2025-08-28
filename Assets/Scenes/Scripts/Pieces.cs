using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Pieces : MonoBehaviour
{
    //bools to replace with switch
    bool IsRook = false;
    bool IsBishop = false;
    bool IsKnight = false;
    bool IsQueen = false;
    bool IsKing = false;
    bool IsPawn = true;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        if (IsRook)
        {
            Gizmos.DrawLine(new Vector2(transform.position.x - 8, transform.position.y), new Vector2(transform.position.x + 8, transform.position.y));
            Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y + 8), new Vector2(transform.position.x, transform.position.y - 8));
        }
        else if (IsBishop)
        {
            Gizmos.DrawLine(new Vector2(transform.position.x - 7, transform.position.y + 7), new Vector2(transform.position.x + 7, transform.position.y - 7));
            Gizmos.DrawLine(new Vector2(transform.position.x + 7, transform.position.y + 7), new Vector2(transform.position.x - 7, transform.position.y - 7));
        }
        else if (IsKnight)
        {
            Gizmos.DrawLine(new Vector2(transform.position.x - 3, transform.position.y), new Vector2(transform.position.x + 3, transform.position.y));
            Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y + 3), new Vector2(transform.position.x, transform.position.y - 3));

            Gizmos.DrawLine(new Vector2(transform.position.x - 3, transform.position.y - 1), new Vector2(transform.position.x - 3, transform.position.y + 1));

            Gizmos.DrawLine(new Vector2(transform.position.x - 1, transform.position.y - 3), new Vector2(transform.position.x + 1, transform.position.y - 3));

            Gizmos.DrawLine(new Vector2(transform.position.x + 3, transform.position.y - 1), new Vector2(transform.position.x + 3, transform.position.y + 1));

            Gizmos.DrawLine(new Vector2(transform.position.x - 1, transform.position.y + 3), new Vector2(transform.position.x + 1, transform.position.y + 3));

        }
        else if (IsQueen)
        {
            Gizmos.DrawLine(new Vector2(transform.position.x - 8, transform.position.y), new Vector2(transform.position.x + 8, transform.position.y));
            Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y + 8), new Vector2(transform.position.x, transform.position.y - 8));

            Gizmos.DrawLine(new Vector2(transform.position.x - 7, transform.position.y + 7), new Vector2(transform.position.x + 7, transform.position.y - 7));
            Gizmos.DrawLine(new Vector2(transform.position.x + 7, transform.position.y + 7), new Vector2(transform.position.x - 7, transform.position.y - 7));
        }
        else if (IsKing)
        {
            Gizmos.DrawLine(new Vector2(transform.position.x - 1, transform.position.y), new Vector2(transform.position.x + 1, transform.position.y));
            Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y + 1), new Vector2(transform.position.x, transform.position.y - 1));

            Gizmos.DrawLine(new Vector2(transform.position.x - 1f, transform.position.y + 1f), new Vector2(transform.position.x + 1f, transform.position.y - 1f));
            Gizmos.DrawLine(new Vector2(transform.position.x + 1f, transform.position.y + 1f), new Vector2(transform.position.x - 1f, transform.position.y - 1f));
        }
        else if (IsPawn)
        {
            Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y), new Vector2(transform.position.x, transform.position.y - 2));
        }

    }
}
