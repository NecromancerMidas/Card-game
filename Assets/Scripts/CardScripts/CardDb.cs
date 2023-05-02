using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.CardScripts
{
    public class CardDb : MonoBehaviour
    {
        public static List<Card> Cards;
        public void Awake()
        {
            Cards = new List<Card>()
            {
                new Card(0, "Economy", 0, "", 0, 0, "",
                    Resources.Load<Sprite>("DogeCoin"),"Common"),
                new Card(1, "Economy", 0, "Doge Coin", 0, 1, "Not worth much.",
                    Resources.Load<Sprite>("DogeCoin"),"Common"),
                new Card(2, "Attack", 0, "Do a lot of damage?", 1, 0, "Just a damage",
                    Resources.Load<Sprite>("Well yes"),"Common"),
                new Card(3, "Economy", 2, "Two Doge Coins", 0, 2, "Double the worth, just as useless.",
                    Resources.Load<Sprite>("TwoDogeCoins"),"Common"),
                new Card(4, "Attack", 2, "Mock Opponent", 2, 0, "He really got you there huh?",
                    Resources.Load<Sprite>("soy-soyboy"),"Common"),
                new Card(5,"Attack",4,"Send to MW2Lobby",3,0,"Force opponent to hear unspeakable things!",
                    Resources.Load<Sprite>("MW2Lobby"),"Uncommon"),
                new Card(6,"Attack/Economy",4,"Print Money",1,2,"Inflation what could possibly go wrong",
                    Resources.Load<Sprite>("PrintMoney"),"Uncommon"),
                new Card(7,"Attack/Economy",3,"That One Friend",2,1,"There is always that one friend.",
                Resources.Load<Sprite>("FistFistDerp"),"Uncommon"),
                new Card(8,"Economy",5,"Triple Doge Coin",0,3,"How many times must I say it, it's worthless.",
                    Resources.Load<Sprite>("Worthless"),"Uncommon"),
                new Card(9,"Economy",0,"Friendly Danny",0,2,"Two coins, for free? How nice.",
                    Resources.Load<Sprite>("DannyCoinVito"),"Rare"),
                new Card(10,"Attack",8,"Et tu Brute?",5,0,"You too Brutus?",
                    Resources.Load<Sprite>("EtTuBrute"),"Rare"),
                new Card(11,"Attack/Economy",8,"Purracy",1,5,"Miss.Spangles, returns with a haul! But the pun hurts.",
                    Resources.Load<Sprite>("Purracy"),"Epic"),
                new Card(12,"Attack",6,"Attack Enjoyer",7,0,"You go enjoy those attacks, enemy sure won't.",
                    Resources.Load<Sprite>("AttackEnjoyer"),"Epic"),
                new Card(13,"Economy",10,"Midas Touch",0,9,"Did you just put yourself in the game? YES.",
                    Resources.Load<Sprite>("MidasTouch"),"Legendary"),
                new Card(14,"Attack",15,"No Bitches?",9,0,"You really had to do him like that?",
                    Resources.Load<Sprite>("NoBitches"),"Legendary"),

            };
        }



    }
}
