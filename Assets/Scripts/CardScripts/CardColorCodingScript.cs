using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.CardScripts
{
    public class CardColorCodingScript : MonoBehaviour
    {
        public Outline[] Outlines = new Outline[4];
        public Image img;
        public void SetColorCode(string type){
            foreach (var outline in Outlines)
            {
                Color32 color;
                switch (type)
                {
                    
                    case "Economy":
                       color = new Color32(255, 232, 45, 255);
                        outline.effectColor = color;
                       img.color = color;
                       break;
                    case "Attack":
                        color = new Color32(255, 0, 8, 255);
                        outline.effectColor = color;
                        img.color = color;
                        break;
                    case "Attack/Economy":
                        color = new Color32(255, 151, 0, 255);
                        outline.effectColor = color;
                        img.color = color;
                        break;
                }
            }
         

        }

     
    }
}
