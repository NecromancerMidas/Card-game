using TMPro;
using UnityEngine;

namespace Assets.Scripts.CardScripts
{
   public class CardCostText : MonoBehaviour
    {
        public TMP_Text cardCost;

        public void SetCardCostText(int cost)
        {
            cardCost.text = cost.ToString();

        }
    }
}
