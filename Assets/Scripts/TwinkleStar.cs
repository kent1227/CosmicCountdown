using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TwinkleStar : MonoBehaviour
{

    private float interval;
    private float startScale;
    private float endScale;
    

    // Start is called before the first frame update
    void Start()
    {
        startScale = Random.Range(0.8f, 1f);
        endScale = Random.Range(1.2f, 1.4f);
        transform.localScale = new Vector3(startScale, startScale, 1);
        interval = Random.Range(2f, 4f);
        transform.DOScale(new Vector3(endScale, endScale, 1f), interval).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
