﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Load_art : MonoBehaviour
{
    public string url;

    private IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;

        Texture2D tex = www.texture;
        GetComponent<Image>().sprite = Sprite.Create((Texture2D)tex, new Rect(0, 0, 90, 50), Vector2.zero);
    }
}
