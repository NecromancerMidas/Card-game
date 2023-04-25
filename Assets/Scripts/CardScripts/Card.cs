using UnityEngine;

namespace Assets.Scripts.CardScripts
{
    [System.Serializable]
    public class Card
    {
        public int Id { get; private set; }
        public int CardCost;
        public string Type;
        public string Name { get; }
        public int Attack;
        public int Money;
        public string Description { get; }
        public Sprite Sprite;
        public string Rarity;


        public Card(int id ,string type,int cardCost, string name, int attack, int money, string description, Sprite sprite,string rarity)

        {
            Id = id;
            Type = type;
            CardCost = cardCost;
            Name = name;
            Attack = attack;
            Money = money;
            Description = description;
            Sprite = sprite;
            Rarity = rarity;
        }
        

        public void ChangeId(int id)
        {
            Id = id;
        }

       

    }
}
