using System;
using Assets.Scripts.CardScripts;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts
{

    public class HandOpponent : Hand
    {


      
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
      public new void Update()
        {
            foreach (var card in CardsInHand)
            {
                card.GetComponent<DisplayCard>()._indeck = true;
            }
            
        }
    }
}