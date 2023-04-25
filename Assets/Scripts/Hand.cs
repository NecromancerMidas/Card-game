using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.CardFunctionalities;
using Assets.Scripts.CardScripts;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    public class Hand : MonoBehaviour
    {
        public List<GameObject> CardsInHand;
        /*public GameObject Card;*/

        public void Draw(GameObject card)
        {
            /* var drawnCard = Instantiate(Card, transform);
             drawnCard.GetComponent<DisplayCard>().Id = card.Id;*/
            /*  CardsInHand.Add(drawnCard);*/
            CardsInHand.Add(card);
            card.transform.SetParent(transform, false);

        }

        public int NumberOfCardsToDraw()
        {
            return 5 - CardsInHand.Count <= 0 ? 0 : 5 - CardsInHand.Count;
        }


        public void Update()
        {
            var turn = transform.GetComponentInParent<Player>().IsTurn;
           
            foreach (var card in CardsInHand)
            {
                card.GetComponent<MouseOverCard>().enabled = true;
                card.GetComponent<DisplayCard>()._indeck = false;
                card.GetComponent<Dragging>().enabled = turn;

            }
        }
    }

}
