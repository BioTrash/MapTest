using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class HoverTipManager : MonoBehaviour
{
    public const string saveSeparator = "//";
    public TextMeshProUGUI tipText;
    public RectTransform tipWindow;

    public static Action <string, Vector2> OnMouseHover;
    public static Action OnMouseLoseFocus;

    private void OnEnable()
    {
        OnMouseHover += ShowTip;
        OnMouseLoseFocus += HideTip;
    }

    private void OnDisable()
    {
        OnMouseHover -= ShowTip;
        OnMouseLoseFocus -= HideTip;
    }
    void Start()
    {
        HideTip();
    }

    private void ShowTip(string tip, Vector2 mousePos)
    {
        tip = "Wind Farm Complex:\n\n The followign complex converts 20% of the tile's potential energy into usable energy.";
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
