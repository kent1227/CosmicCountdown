using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    private Player player;

    public CollectableType type;

    // Start is called before the first frame update
    void Start()
    {
        player = FindFirstObjectByType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

public enum CollectableType
{
    Fuel,
    Thrusters,
    Crystals,
    Computers,
    Processors,
    AlloyPlates
}