using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.SearchService;
using UnityEngine;

public class Planet : MonoBehaviour
{

    public string planetName;
    public string sceneName;

    public List<Transform> collectableLocations;

    public GameObject boxPrefab;

    [Range(0f, 6f)]
    public int maxCollectables;

    private int currentCollectables = 0;

    // Start is called before the first frame update
    void Start()
    {
        List<Transform> temp = new List<Transform>();
        while (currentCollectables < maxCollectables)
        {
            temp = collectableLocations.ToList();
            foreach (var loc in temp)
            {
                if (currentCollectables < maxCollectables)
                {
                    if (Random.value >= 0.5f)
                    {
                        Instantiate(boxPrefab, loc);
                        collectableLocations.Remove(loc);
                        currentCollectables++;
                    }
                }
                else
                {
                    break;
                }
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum PlanetType
{
    Volcanic,
    Rocky,
    Lush,
    Icy
}
