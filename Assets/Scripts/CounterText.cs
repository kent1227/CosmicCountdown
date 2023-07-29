using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CounterText : MonoBehaviour
{


    TextMeshProUGUI counterText;

    public ProgressBar progressBar;

    int max;
    int current;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        max = progressBar.maximum;
    }

    // Update is called once per frame
    void Update()
    {
        current = progressBar.current;
        counterText.text = string.Format("{0}/{1}", current, max);
    }
}
