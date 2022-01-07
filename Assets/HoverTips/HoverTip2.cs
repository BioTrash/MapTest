using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTip2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string tipToShow;
    public void OnPointerEnter(PointerEventData eventData)
    {
        HoverTipManager2.OnMouseHover(tipToShow, Input.mousePosition);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverTipManager2.OnMouseLoseFocus();
    }
}
