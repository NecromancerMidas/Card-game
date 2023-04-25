using Assets.Scripts.CardFunctionalities;
using Assets.Scripts.CardScripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MarketShop : MonoBehaviour
{
    public List<GameObject> Market;
    public GameObject MarketDeck;

    public void FillMarket()
    {
        for (int i = NumberOfCardsToDraw(); i > 0; i--)
        {



            var marketDeck = MarketDeck.GetComponent<MarketDeck>();
            Market.Add(marketDeck.Deck.Last());
            marketDeck.GetComponent<MarketDeck>().RemoveDrawn();
            Market.Last().transform.SetParent(transform, false);
        }
    }
    public int NumberOfCardsToDraw()
    {
        return 5 - Market.Count <= 0 ? 0 : 5 - Market.Count;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var card in Market)
        {
            
            card.GetComponent<MouseOverCard>().enabled = true;
            card.GetComponent<DisplayCard>()._indeck = false;
            card.GetComponent<Dragging>().enabled = true;
        }
    }
}
