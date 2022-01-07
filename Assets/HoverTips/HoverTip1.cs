using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverTip1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string tipToShow;
    public void OnPointerEnter(PointerEventData eventData)
    {
        HoverTipManager1.OnMouseHover(tipToShow, Input.mousePosition);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverTipManager1.OnMouseLoseFocus();
    }
}
