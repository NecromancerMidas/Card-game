using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts;
using Assets.Scripts.CardFunctionalities;
using Assets.Scripts.CardScripts;
using Unity.VisualScripting;
using UnityEngine;using UnityEngine.EventSystems;

namespace Assets.Scripts.CardFunctionalities
{
    public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
    {
        // Start is called before the first frame update
        public List<GameObject> PlayedCards;
        public Hand Hand;
        public Player Player;
        public Player Opponent;
        public void OnDrop(PointerEventData pointerEvent)
        {
            if (Dragging.DraggedItem.GetComponentInParent<CardMarket.CardMarket>()) return;
            if (Dragging.DraggedItem.GetComponentInParent<MarketShop>()) return;
            PlayedCards.Add(Dragging.DraggedItem);
            Dragging.DraggedItem.GetComponent<PlayCard>().Play(Player);
            Dragging.DraggedItem.GetComponent<CanvasGroup>().blocksRaycasts = true;
            Hand.CardsInHand.Remove(Dragging.DraggedItem);
            Dragging.DraggedItem = null;
        }

        public void Discard()
        {
            PlayedCards.Remove(PlayedCards.First());
        }

        public int ListNumber()
        {
            return PlayedCards.Count;
        }

        public void OnPointerEnter(PointerEventData pointerEvent)
        {

        }

        public void OnPointerExit(PointerEventData pointerEvent)
        {

        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            foreach (var card in PlayedCards)
            {
                card.GetComponent<Dragging>().enabled = false;
                card.transform.SetParent(transform, false);
            }
        }
    }
}
