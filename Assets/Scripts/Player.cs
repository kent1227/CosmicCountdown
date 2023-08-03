using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private int moveSpeed = 3;

    //CircleCollider2D cc;

    public Dictionary<CollectableType, int> collectables;

    // Start is called before the first frame update
    void Start()
    {
        //cc = GetComponent<CircleCollider2D>();
        collectables = new Dictionary<CollectableType, int>();
        for (int i=0; i<Enum.GetNames(typeof(CollectableType)).Length; i++)
        {
            collectables.Add((CollectableType)i, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(horizontal, vertical, 0f).normalized * moveSpeed;

        transform.position += move * Time.fixedDeltaTime;

    }

    public void AddCollectable(CollectableType c)
    {
        int current = collectables[c];
        collectables[c] = current + 1;
    }

}
