using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.CardScripts
{
    public class PlayCard : MonoBehaviour
    {
      

        public void Play(Player player)
        {
            Card card = transform.GetComponentInParent<DisplayCard>().card;
            transform.GetComponentInParent<DisplayCard>()._indeck = false;
            Debug.Log(card.Attack + " " + card.Money);
            player.Money += card.Money;
            player.Opponent.Health -= card.Attack;
        }
    }
}
