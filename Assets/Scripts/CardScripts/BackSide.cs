using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackSide : MonoBehaviour
{
    public Image img;

    public void ToggleBackside(bool showbackside)
    {
        img.enabled = showbackside;
    }

    public void Awake()
    {
        img.enabled = false;
    }
}
