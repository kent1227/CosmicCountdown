using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public static class UITweening
{
    
    public static void ScaleX(RectTransform t, float scaleFactor)
    {
        t.DOScaleX(scaleFactor, 0.5f);
    }

    public static void ScaleY(RectTransform t, float scaleFactor)
    {
        t.DOScaleY(scaleFactor, 0.5f);
    }

}
