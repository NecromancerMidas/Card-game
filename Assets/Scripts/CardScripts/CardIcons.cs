using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.CardScripts{
    public class CardIcons : MonoBehaviour
    {

        public GameObject Coin;
        public GameObject Fist;
        public GameObject TopRow;
        public GameObject BottomRow;

        public void PlaceImages(int attack, int money)
        {
            if (money >= attack)
            {
                AddIcon(money, true,Coin);
                AddIcon(attack,false,Fist);
              
            }
            else
            {
                AddIcon(attack, true,Fist);
                AddIcon(money, false,Coin);
                
            }


        }

        
    /*    public void AddIcon(int number,bool topRow,GameObject icon)
        {
            for (int i = 0; i < number; i++)
            { 
            *//*   var newicon = Instantiate(icon,new Vector3(i*2.0f,topRow ? 1.3f : 0,0), Quaternion.identity);*//*
            var newicon = Instantiate(icon, transform);
            if (number > 1) newicon.transform.localPosition += new Vector3(icon == Fist ? -4.0f : -2.0f, 0 , 0);
            newicon.transform.localPosition += new Vector3(icon == Coin ? i*3.0f : i * 6.0f, topRow ? 1.3f : 0);

            }
        }*/
    public void AddIcon(int number, bool topRow, GameObject icon)
    {
        for (int i = 0; i < number; i++)
        {
            if (topRow)
            {
                Instantiate(icon, TopRow.transform);
            }
            else
            {
                Instantiate(icon, BottomRow.transform);
            }
        }
    }

    }
}
