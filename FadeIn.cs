﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
 
    public RawImage BackFadeIn;

    private void Awake()
    {
        OnFadeIn();
    }

    public void OnFadeIn()
    {
        // fades the image out when you click
        StartCoroutine(FadeImage(true));
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime * 0.3f)
            {
                // set color with i as alpha
                BackFadeIn.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime * 0.3f)
            {
                // set color with i as alpha
                BackFadeIn.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
