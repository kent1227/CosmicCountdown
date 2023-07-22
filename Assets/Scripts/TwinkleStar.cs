using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TwinkleStar : MonoBehaviour
{

    private float _interval;
    private float _startScale;
    private float _endScale;
    

    // Start is called before the first frame update
    void Start()
    {
        _startScale = Random.Range(0.6f, 0.8f);
        _endScale = Random.Range(1.2f, 1.4f);
        transform.localScale = new Vector3(_startScale, _startScale, 1);
        _interval = Random.Range(2f, 4f);
        transform.DOScale(new Vector3(_endScale, _endScale, 1f), _interval).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
