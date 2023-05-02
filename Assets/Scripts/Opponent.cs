using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Assets.Scripts.CardFunctionalities;
using UnityEngine;
using Assets.Scripts.CardMarket;
using Assets.Scripts.CardScripts;

namespace Assets.Scripts
{


    public class Opponent : Player
    {
        public CardMarket.CardMarket Market;
        public GameObject PlayArea;
        public new void SetTurn()
        {
            IsTurn = !IsTurn;
            
        }
        public string ReturnTypeToGet()
        {
            var allCards = Deck.Deck.Concat(Hand.CardsInHand.Concat(Discard.DiscardedCards)).ToList();
          
            var countAttack = allCards.Count(c => c.GetComponent<DisplayCard>().card.Type.Contains("Attack"));
            var countMoney = allCards.Count(c => c.GetComponent<DisplayCard>().card.Type.Contains("Economy"));
            var result = (int)Math.Round(((double)countMoney / (double)allCards.Count) * 100);
            
            if (result > 65)
            {
                return "Attack";
            }
            return "Money";
        }

        public void Play()
        {
            var cardToPLay = Hand.CardsInHand.Last();
            cardToPLay.GetComponent<PlayCard>().Play(this);
            cardToPLay.transform.SetParent(PlayArea.transform, false);
            cardToPLay.GetComponentInParent<DropZone>().PlayedCards.Add(cardToPLay);
            Hand.CardsInHand.Remove(cardToPLay);
            if (Hand.CardsInHand.Count == 0)
            {
                CancelInvoke("Play");
                InvokeRepeating("Shop",3,1);
            }
        }
       public void BotPlay()
        {
            
                InvokeRepeating("Play", 3, 1);
            
            
        }

        public void Shop()
        {

            var type = ReturnTypeToGet();
            if (Money < Market.ReturnHighestCostCard(type,Money).GetComponent<DisplayCard>().CardCost)
            {
                CancelInvoke("Shop");
                OnButtonClickTest();
            }
            else
            {
              var card = Market.ReturnHighestCostCard(type,Money);
              Buy(card.GetComponent<DisplayCard>().CardCost);
              Discard.DiscardedCards.Add(card);
              card.GetComponentInParent<CardMarket.CardMarket>().RemoveItem(card);
              transform.SetParent(Discard.transform, false);
            }
        }
        // Start is called before the first frame update
        new void Start()
        {
            Deck.PopulateStarterDeck();
            Health = 30;
            Deck.Shuffle();
            DrawStartingHand();
        }

        // Update is called once per frame
       new void Update()
       {
           base.Update();
            if (IsTurn)
            {
                IsTurn = false;
                BotPlay();

            }
        }
    }
}
