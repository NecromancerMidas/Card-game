using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class DeckVisual : MonoBehaviour
    {
        public GameObject CardBack;
        public List<GameObject> CardBacks;


        public void AddCardBack(int count)
        {
            var NumberofCardbacks = count / 5;
            for (int i = 0; i <= NumberofCardbacks; i++)
            {
                if(i >= CardBacks.Count && CardBacks.Count != 11)
                {
                    CardBacks.Add(Instantiate(CardBack, transform));
                }
            }


            for (int i = 0; i <= CardBacks.Count; i++)
            {

                if (CardBacks.Count * 5 > count)
                {

                    Destroy(CardBacks.Last());
                    CardBacks.RemoveAt(CardBacks.Count - 1);


                }
            }
        }
    }
            
}

