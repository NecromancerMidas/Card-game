using Assets.Scripts.CardFunctionalities;
using Assets.Scripts.CardMarket;
using Assets.Scripts.CardScripts;
using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiscardDropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Discard Discard;
    
    public CardMarket Market;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (Dragging.DraggedItem.GetComponentInParent<Player>()) return;
        var cost = Dragging.DraggedItem.GetComponent<DisplayCard>().CardCost;
        if (Discard.GetComponentInParent<Player>().Buy(cost))
        {
            Discard.DiscardedCards.Add(Dragging.DraggedItem);
            Dragging.DraggedItem.GetComponent<CanvasGroup>().blocksRaycasts = true;
            Dragging.DraggedItem.GetComponentInParent<CardMarket>().RemoveItem(Dragging.DraggedItem);
        }
        Dragging.DraggedItem = null;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
