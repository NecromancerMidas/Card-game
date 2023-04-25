using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public DeckScript Deck;
        public Hand Hand;
        public int Health;
        public TMP_Text HealthText;
        public Discard Discard;
        public bool IsTurn;
        public Player Opponent;
        public int Money;
        public TMP_Text MoneyText;
        public MarketShop MarketShop;

        public void DrawStartingHand()
        {
            for (int i = 5; i > 0; i--)
            {
                Hand.Draw(Deck.Deck.Last());
                Deck.DrawTop();
            }
        }
        public void OnButtonClickTest()
        {
            Discard.AddToDiscard();
            DrawToMax();
            ResetMoney();
            IsTurn = false;
            MarketShop.FillMarket();
            Opponent.SetTurn();
            
            
        }

        
        public void ResetMoney()
        {
            Money = 0;
        }

        public bool Buy(int cardCost)
        {
            if (Money < cardCost)
            {
                return false;
            }
            Money -= cardCost;
            return true;
        }
        public void SetTurn()
        {
            IsTurn = !IsTurn;
        }
        public void DrawToMax()
        {
            for (int i = Hand.NumberOfCardsToDraw(); i > 0; i--)
            {
                if (Deck.Deck.Count <= 0)
                {
                    Deck.ReshuffleDiscard(Discard);
                    
                }
                Hand.Draw(Deck.Deck.Last());
                Deck.DrawTop();
            }
        }
        public void Start()
        {
            Deck.PopulateStarterDeck();
            Health = 30;
            Money = 0;
            Deck.Shuffle();
            DrawStartingHand();
            IsTurn = true;


        }

        public void Update()
        {
            
            HealthText.text = Health.ToString();
            MoneyText.text = Money.ToString();
        }
        
    }


}
