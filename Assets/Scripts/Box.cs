using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    public PlanetType planetType;

    private Player player;

    private Collectable collectable;

    // Start is called before the first frame update
    void Start()
    {
        player = FindFirstObjectByType<Player>();
        collectable = gameObject.AddComponent<Collectable>();
        collectable.type = GetCollectable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.AddCollectable(collectable.type);
            Destroy(gameObject);
        }
    }

    private CollectableType GetCollectable()
    {
        CollectableType c;
        float random = Random.value;
        switch (planetType)
        {
            case PlanetType.Volcanic:
                if (random >= 0.5)
                {
                    c = CollectableType.Thrusters; break;
                }
                else if (random >= 0.2) 
                {
                    c = CollectableType.Processors; break;
                }
                else
                {
                    c = CollectableType.Crystals; break;
                }
            case PlanetType.Rocky:
                if (random >= 0.5)
                {
                    c = CollectableType.Fuel; break;
                }
                else if (random >= 0.2)
                {
                    c = CollectableType.AlloyPlates; break;
                }
                else
                {
                    c = CollectableType.Processors; break;
                }
            case PlanetType.Lush:
                if (random >= 0.5)
                {
                    c = CollectableType.AlloyPlates; break;
                }
                else if (random >= 0.2)
                {
                    c = CollectableType.Computers; break;
                }
                else
                {
                    c = CollectableType.Fuel; break;
                }
            case PlanetType.Ice:
                if (random >= 0.5)
                {
                    c = CollectableType.Crystals; break;
                }
                else if (random >= 0.2)
                {
                    c = CollectableType.Thrusters; break;
                }
                else
                {
                    c = CollectableType.Computers; break;
                }
            default:
                {
                    c = CollectableType.Fuel; break;
                }
        }
        return c;
    }
}
