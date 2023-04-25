using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite[] CardFaces;
    public Sprite CardBack;

    public int CardIndex;



    public void ToggleFace(bool showFace)
    {
        spriteRenderer.sprite = showFace ? CardFaces[CardIndex] : CardBack;
    }

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

}
