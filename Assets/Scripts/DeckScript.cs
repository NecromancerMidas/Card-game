using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using Assets.Scripts.CardFunctionalities;
using Assets.Scripts.CardScripts;
using UnityEditor;
using UnityEngine;
using Random = System.Random;


namespace Assets.Scripts
{



    public class DeckScript : MonoBehaviour
    {

        public List<GameObject> Deck = new List<GameObject>();
        public DeckVisual DeckVisual;
        public Hand Hand;
        public GameObject StartMoneyCard;
        public GameObject StartAttackCard;
        public DeckVisual2 DeckVisual2;
        public bool IsTurn;
        public void PopulateStarterDeck()
        {
            for (int i = 8; i > 0; i--)
            {
                Deck.Add(Instantiate(StartMoneyCard,transform));
            }

            for (int i = 2; i > 0; i--)
            {
                Deck.Add(Instantiate(StartAttackCard,transform));
            }
            /*Deck.AddRange(Enumerable.Repeat(Instantiate(StartMoneyCard),8));*/
            /*Deck.AddRange(Enumerable.Repeat(Instantiate(StartAttackCard),2));*/
            /*Deck.AddRange(Enumerable.Repeat(CardDb.Cards[1],8));
            Deck.AddRange(Enumerable.Repeat(CardDb.Cards[2],2));*/
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

        public void ReshuffleDiscard(Discard discard)
        {
            Deck = discard.SendDiscard();
            discard.DiscardReshuffle();
            foreach (var card in Deck)
            {
                card.transform.SetParent(transform, false);
            }
            Shuffle();
        }

        public void DrawTop()
        {
           Deck.Remove(Deck[Deck.Count - 1]);

        }

      
        
       void Start()
       {
          
       }

       void Update()
       {
           foreach (var card in Deck)
           {
               card.GetComponent<DisplayCard>()._indeck = true;
               card.GetComponent<MouseOverCard>().enabled = false;
               card.GetComponent<Dragging>().enabled = false;
           }
          /* DeckVisual.AddCardBack(Deck.Count);
           DeckVisual2.AddCardBack(Deck.Count);*/
       }



    }
}
