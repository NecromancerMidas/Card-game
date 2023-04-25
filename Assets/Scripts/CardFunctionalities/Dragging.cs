using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.CardFunctionalities
{
    public class Dragging : MonoBehaviour, IDragHandler,IBeginDragHandler, IEndDragHandler
    {
        // Start is called before the first frame update
        public static GameObject DraggedItem;
        Transform _returnTo = null;
        private int _parentIndex;
        

        public void OnBeginDrag(PointerEventData eventData)
        {
            _returnTo = transform.parent;
            _parentIndex = transform.GetSiblingIndex();
            transform.SetParent(transform.parent.parent);
            GetComponent<CanvasGroup>().blocksRaycasts = false;
            DraggedItem = gameObject;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
            
        }

        public void OnEndDrag(PointerEventData eventData)
        {



            
                GetComponent<CanvasGroup>().blocksRaycasts = true;
                transform.SetParent(_returnTo, false);
                transform.SetSiblingIndex(_parentIndex);
                



        }
    }
}
