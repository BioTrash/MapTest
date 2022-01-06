using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoverTipManager : MonoBehaviour
{
    public TextMeshProUGUI tipText;
    public RectTransform tipWindow;

    public static Action <string, Vector2> OnMouseHover;
    public static Action OnMOuseLoseFocus;

    private void OnEnable()
    {
        OnMouseHover += ShowTip;
        OnMOuseLoseFocus += HideTip;
    }

    private void OnDisable()
    {
        OnMouseHover -= ShowTip;
        OnMOuseLoseFocus -= HideTip;
    }
    void Start()
    {
        HideTip();
    }

    private void ShowTip(string tip, Vector2 mousePos)
    {
        tip = "Test, Te-e-st, T-e-e-e-st\n TEEEEEEEEEEEEEST";
        tipText.text = tip;
        tipWindow.sizeDelta = new Vector2(tipText.preferredWidth > 600 ? 600 : tipText.preferredWidth, tipText.preferredHeight);

        tipWindow.gameObject.SetActive(true);
        tipWindow.transform.position = new Vector2(mousePos.x, mousePos.y);
    }

    private void HideTip()
    {
        tipText.text = default;
        tipWindow.gameObject.SetActive(false);
    }
}
