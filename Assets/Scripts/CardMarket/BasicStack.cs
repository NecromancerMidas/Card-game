using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.CardFunctionalities;
using TMPro;
using TMPro.Examples;
using UnityEngine;

namespace Assets.Scripts.CardMarket
{


    public class BasicStack : MonoBehaviour

    {
        
        public List<GameObject> cards;
        public TMP_Text CardCounter;

        public void BuildStack(GameObject card)
        {

            {
                for (int i = 0; i < 12; i++)
                {
                    cards.Add(Instantiate(card, transform));
                }
            }
        }

        public void RemoveFromStack(GameObject card)
        {
            cards.Remove(card);
        }
        public GameObject ReturnLastFromStack()
        {
            if(cards.Count == 0) return null;
            return cards.Last();
            

        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            foreach (var card in cards)
            {
                if (card != cards.Last())
                {
                    card.GetComponent<Dragging>().enabled = false;
                    card.GetComponent<MouseOverCard>().enabled = false;
                }
                else
                {
                    card.GetComponent<Dragging>().enabled = true;
                    card.GetComponent<MouseOverCard>().enabled = true;
                }

                CardCounter.text = cards.Count.ToString();
            }
        }
    }
}
