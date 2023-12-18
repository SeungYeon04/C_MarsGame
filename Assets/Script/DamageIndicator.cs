using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageIndicator : MonoBehaviour
{
    public Image image;
    public float flashSpeed;

    private Coroutine coroutine;

    public void Flash() //어딘가에서 불 터트리면 
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }

        //터지고 
        image.enabled = true;
        image.color = Color.red;
        coroutine = StartCoroutine(FadeAway());
    }

    private IEnumerator FadeAway()
    {
        float startAlpha = 0.3f;
        float a = startAlpha;

        //일정 시간 동안 감소하겠다 
        while (a > 0.0f)
        {
            a -= (startAlpha / flashSpeed) * Time.deltaTime;
            image.color = new Color(1.0f, 0.0f, 0.0f, a);
            yield return null;
        }

        image.enabled = false;
    }
}