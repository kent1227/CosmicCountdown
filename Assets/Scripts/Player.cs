using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveTime = 0.1f;
    public LayerMask blockingLayer;

    private BoxCollider2D bc;
    private Rigidbody2D rb;
    private float inverseMoveTime;

    private Direction moveDir = Direction.None;
    private bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        inverseMoveTime = 1f / moveTime;
    }

    bool Move(int xDir, int yDir)
    {
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(xDir, yDir);

        return false;
    }

    IEnumerator SmoothMovement (Vector3 end)
    {
        float sqrRemainingDistance = (transform.position - end).sqrMagnitude;

        while (sqrRemainingDistance > float.Epsilon)
        {
            Vector3 newPosition = Vector3.MoveTowards(rb.position, end, inverseMoveTime * Time.deltaTime);
            rb.MovePosition(newPosition);
            sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveDir = Direction.Up;
            canMove = false;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDir = Direction.Down;
            canMove = false;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDir = Direction.Right;
            canMove = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDir = Direction.Left;
            canMove = false;
        }
        else
        {
            moveDir = Direction.None;
            canMove = true;
        }

        switch(moveDir)
        {
            case Direction.Up:
                Move(0, 1);
                break;

            case Direction.Down:

                break;

            case Direction.Left:

                break;

            case Direction.Right:

                break;

            case Direction.None: break;
        }
    }
}

public enum Direction
{
    None,
    Up,
    Right,
    Down,
    Left
}
