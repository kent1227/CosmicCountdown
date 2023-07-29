using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{

    public int maximum;
    public int current = 0;
    public Image mask;

    Player player;

    public CollectableTypes collectable;

    // Start is called before the first frame update
    void Start()
    {
        player = FindFirstObjectByType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        current = player.collectables[collectable];
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
    }
}
