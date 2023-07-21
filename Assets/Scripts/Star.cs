using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using Random = UnityEngine.Random;

public class Star : MonoBehaviour
{
    private Action<Star> _killAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Init(Action<Star> killAction)
    {
        _killAction = killAction;
    }

    private void OnEnable()
    {
        transform.DOMoveX(-10, Random.Range(3f, 7f)).SetEase(Ease.Linear).OnComplete(TweenCompleted);
    }

    private void TweenCompleted()
    {
        _killAction(this);
    }

}
