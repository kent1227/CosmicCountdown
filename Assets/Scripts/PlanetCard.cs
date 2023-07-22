using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetCard : MonoBehaviour
{

    public Planet planet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Select()
    {
        SceneManager.LoadScene(planet.sceneName);
    }

    void Pass()
    {

    }
}
