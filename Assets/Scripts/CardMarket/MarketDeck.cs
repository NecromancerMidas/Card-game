using Assets.Scripts.CardFunctionalities;
using Assets.Scripts.CardScripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class MarketDeck : MonoBehaviour
{
    public List<GameObject> CardDb;
    public List<GameObject> Deck;
    public MarketShop Shop;
    // Start is called before the first frame update


    public void PopulateMarketDeck()
    {
        foreach (var card in CardDb)
        {
            var amount = card.GetComponent<DisplayCard>().Rarity switch
            {
                "Uncommon" => 8,
                "Rare" => 5,
                "Epic" => 3,
                "Legendary" => 1,
                _ => 0
            };

            for (int i = 0; i < amount; i++)
            {
                    Deck.Add(Instantiate(card,transform));
            }
        }
        
    }

    public void RemoveDrawn()
    {
        Deck.Remove(Deck.Last());
    }
    
    public void Shuffle()
    {
        var shuffled = Deck;
        for (int i = 0; i < shuffled.Count; i++)
        {
            var random = new Random().Next(0, shuffled.Count);
            GameObject toBeShuffled = shuffled[i];
            shuffled[i] = shuffled[random];
            shuffled[random] = toBeShuffled;
        }
        Deck = shuffled;
    }


    void Start()
    {
        PopulateMarketDeck();
        Shuffle();
        Shop.FillMarket();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var card in Deck)
        {
            card.GetComponent<DisplayCard>()._indeck = true;
            card.GetComponent<MouseOverCard>().enabled = false;
            card.GetComponent<Dragging>().enabled = false;
        }
    }
}
