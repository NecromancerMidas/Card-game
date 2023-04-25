using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Assets.Scripts.CardScripts;
using UnityEngine;

namespace Assets.Scripts.CardMarket
{


    public class CardMarket : MonoBehaviour
    {
        public BasicStack StackAttack;
        public BasicStack StackMoney;
        public GameObject BasicAttack;
        public GameObject BasicMoney;
        public MarketShop MarketShop;

        public void RemoveItem(GameObject item)
        {
            if (StackAttack.cards.Contains(item))
            {
                StackAttack.cards.Remove(item);
                return;
            }
            if (StackMoney.cards.Contains(item))
            {
                StackMoney.cards.Remove(item);
                return;
            }
            if (MarketShop.Market.Contains(item))
            {
                MarketShop.Market.Remove(item);
                return;
            } ;

        }

        public GameObject ReturnHighestCostCard(string type, int canAfford)
        {

            var cardtoreturn = StackMoney.ReturnLastFromStack();
            var highestcost = 0;
            foreach (var card in MarketShop.Market)
            {
                var cost = card.GetComponent<DisplayCard>().CardCost;
                if (cost == 0)
                {
                    return card;
                }
                if (cost > highestcost && cost <= canAfford)
                {
                    cardtoreturn = card;
                    highestcost = cost;
                }
            }
            if (cardtoreturn == StackMoney.ReturnLastFromStack() && type == "Attack")
            {
                return StackAttack.ReturnLastFromStack();
            }

            return cardtoreturn;

        }
        // Start is called before the first frame update
        void Start()
        {
            StackMoney.BuildStack(BasicMoney);
            StackAttack.BuildStack(BasicAttack);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
