using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.CardFunctionalities
{
    public class MouseOverCard : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler, IPointerDownHandler
    {
        private Canvas tempCanvas;
        private Vector3 tempPosition;
        private GraphicRaycaster tempRaycaster;
        // Start is called before the first frame update
        void OnMouseOver()
        {
        
        }

        void OnMouseExit()
        {

        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            tempPosition = transform.localPosition;
            //If your mouse hovers over the GameObject with the script attached, output this message
            Debug.Log("Mouse is over GameObject.");
            tempCanvas = gameObject.AddComponent<Canvas>();
            tempCanvas.overrideSorting = true;
            tempCanvas.sortingOrder = 1;
            tempCanvas.additionalShaderChannels = AdditionalCanvasShaderChannels.TexCoord1;
            tempRaycaster = gameObject.AddComponent<GraphicRaycaster>();
            transform.localScale = new Vector3(1.7f, 1.7f);

            transform.position = new Vector3(transform.position.x, transform.position.y);

        }

        public void OnPointerExit(PointerEventData eventData)
        {
            //The mouse is no longer hovering over the GameObject so output this message each frame
            Debug.Log("Mouse is no longer on GameObject."); 
            transform.localScale = new Vector3(1.5f, 1.5f);
            Destroy(tempRaycaster);
            Destroy(tempCanvas);
            transform.localPosition = tempPosition;
        }
    

        public void OnPointerDown(PointerEventData eventData)
        {
           
        }
    }
}
