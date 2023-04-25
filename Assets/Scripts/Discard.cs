using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts;
using Assets.Scripts.CardFunctionalities;
using Assets.Scripts.CardScripts;
using Unity.VisualScripting;
using UnityEngine;

public class Discard : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> DiscardedCards;
    public DropZone PlayArea;


    public void AddToDiscard()
    {
        for (int i = PlayArea.ListNumber(); i > 0 ; i--)
        {
            PlayArea.PlayedCards.First().transform.SetParent(transform,false);
            DiscardedCards.Add(PlayArea.PlayedCards.First());

            PlayArea.Discard();
        }
        
    }

    public List<GameObject> SendDiscard()
    {
        var sentDiscard = new List<GameObject>();
        foreach (var card in DiscardedCards)
        {
            sentDiscard.Add(card);
        }
        return sentDiscard;
    }

    public void DiscardReshuffle()
    {
        for (int i = DiscardedCards.Count(); i > 0; i--)
        {
            DiscardedCards.Remove(DiscardedCards.Last());
        }
    }
    void Update()
    {
        foreach (var card in DiscardedCards)
        {
            card.transform.SetParent(transform,false);
            card.GetComponent<MouseOverCard>().enabled = false;
            card.GetComponent<Dragging>().enabled = false;
        }
    }
}
