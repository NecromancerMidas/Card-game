using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.CardScripts
{
    public class DisplayCard : MonoBehaviour
    {
    
        public int Id;
        public Card card;
        public BackSide backside;
        private Image _cardback;
        public bool _indeck;
       public int CardCost;
       public string Rarity;
        public CardIcons CardIcons;
       public TMP_Text CardCostText;
        public TMP_Text Name;
        public TMP_Text Description;
        public Image sprite;
        public CardColorCodingScript CardOutline;



        public void ChangeCostBy(int change)
        {
            if (CardCost + change < 0)
            {
                CardCost = 0;
            }
            else CardCost += change;

            
        }

        
        

        void Start()
        {
            card = CardDb.Cards[Id];
            CardCost = card.CardCost;
            CardCostText.text = CardCost.ToString();
            Name.text = card.Name;
            Description.text = card.Description;
            CardIcons.PlaceImages(card.Attack,card.Money);
            sprite.sprite = card.Sprite;
            CardOutline.SetColorCode(card.Type);
        }

        void Update()
        {
            if(_indeck)backside.ToggleBackside(true);
            else backside.ToggleBackside(false);
        }


    }
}
