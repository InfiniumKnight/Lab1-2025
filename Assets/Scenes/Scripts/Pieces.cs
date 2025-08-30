using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Pieces : MonoBehaviour
{
    public Sprite[] sprites;

    [SerializeField]
    ChessPieces chessPieces = new ChessPieces();

    SpriteRenderer spriteRenderer;

    private int pieceNumber;

    public enum ChessPieces
    { 
        Rook,
        Bishop,
        Knight,
        Queen,
        King,
        Pawn
    }

    [ColorUsage(false, true)]
    public Color colorUsage;

    void Start() 
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        spriteRenderer.sprite = sprites[pieceNumber];
        spriteRenderer.color = colorUsage;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;

        switch (chessPieces)
        { 
            case ChessPieces.Rook:
                Gizmos.DrawLine(new Vector2(transform.position.x - 7, transform.position.y), new Vector2(transform.position.x + 7, transform.position.y));
                Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y + 7), new Vector2(transform.position.x, transform.position.y - 7));
                pieceNumber = 0;
                break;
                
            case ChessPieces.Bishop:
                Gizmos.DrawLine(new Vector2(transform.position.x - 7, transform.position.y + 7), new Vector2(transform.position.x + 7, transform.position.y - 7));
                Gizmos.DrawLine(new Vector2(transform.position.x + 7, transform.position.y + 7), new Vector2(transform.position.x - 7, transform.position.y - 7));
                pieceNumber = 1;
                break;

            case ChessPieces.Knight:
                Gizmos.DrawLine(new Vector2(transform.position.x - 2, transform.position.y), new Vector2(transform.position.x + 2, transform.position.y));
                Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y + 2), new Vector2(transform.position.x, transform.position.y - 2));

                Gizmos.DrawLine(new Vector2(transform.position.x - 2, transform.position.y - 1), new Vector2(transform.position.x - 2, transform.position.y + 1));

                Gizmos.DrawLine(new Vector2(transform.position.x - 1, transform.position.y - 2), new Vector2(transform.position.x + 1, transform.position.y - 2));

                Gizmos.DrawLine(new Vector2(transform.position.x + 2, transform.position.y - 1), new Vector2(transform.position.x + 2, transform.position.y + 1));

                Gizmos.DrawLine(new Vector2(transform.position.x - 1, transform.position.y + 2), new Vector2(transform.position.x + 1, transform.position.y + 2));
                pieceNumber = 2;
                break;

            case ChessPieces.Queen:
                Gizmos.DrawLine(new Vector2(transform.position.x - 7, transform.position.y), new Vector2(transform.position.x + 7, transform.position.y));
                Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y + 7), new Vector2(transform.position.x, transform.position.y - 7));

                Gizmos.DrawLine(new Vector2(transform.position.x - 7, transform.position.y + 7), new Vector2(transform.position.x + 7, transform.position.y - 7));
                Gizmos.DrawLine(new Vector2(transform.position.x + 7, transform.position.y + 7), new Vector2(transform.position.x - 7, transform.position.y - 7));
                pieceNumber = 3;
                break;

            case ChessPieces.King:
                Gizmos.DrawLine(new Vector2(transform.position.x - 1, transform.position.y), new Vector2(transform.position.x + 1, transform.position.y));
                Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y + 1), new Vector2(transform.position.x, transform.position.y - 1));

                Gizmos.DrawLine(new Vector2(transform.position.x - 1f, transform.position.y + 1f), new Vector2(transform.position.x + 1f, transform.position.y - 1f));
                Gizmos.DrawLine(new Vector2(transform.position.x + 1f, transform.position.y + 1f), new Vector2(transform.position.x - 1f, transform.position.y - 1f));
                pieceNumber = 4;
                break;

            case ChessPieces.Pawn:
                Gizmos.DrawLine(new Vector2(transform.position.x, transform.position.y), new Vector2(transform.position.x, transform.position.y + 2));
                pieceNumber = 5;
                break;
        }    
    }
}
