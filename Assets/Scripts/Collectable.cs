using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    private Player player;

    public CollectableTypes type;

    // Start is called before the first frame update
    void Start()
    {
        player = FindFirstObjectByType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.AddCollectable(type);
            Destroy(gameObject);
        }
    }

}

public enum CollectableTypes
{
    Fuel,
    Thrusters,
    Crystals,
    Computers,
    Processors,
    AlloyPlates
}