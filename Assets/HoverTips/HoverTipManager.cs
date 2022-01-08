using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class HoverTipManager : MonoBehaviour
{
    public int Bld_Mat_Need;

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
        ResourceScriptLoad Load = new ResourceScriptLoad();

        int energy_Pro = Convert.ToInt32(Convert.ToInt32(Load.Energy_Pot.text) * 0.2);

        int bld_mat_need = energy_Pro / 10 * 5;

        Bld_Mat_Need = bld_mat_need;

        int bld_time = energy_Pro / 500 / 12;

        string not_Enough;

        if (bld_mat_need > Convert.ToInt32(Load.Bld_Mat.text))
        {
            not_Enough = "<color=red>You don't posses enough building material at the moment</color>";
        }
        else
        {
            not_Enough = null;
        }

        tip = "Wind Farm Complex:\n\nThe following complex converts 20% of the tile's potential energy into usable energy, in this case: <color=yellow>" + energy_Pro + "MW/h</color>\n\n" +
            "The Complex needs building material in order for construction to begin, in this case: <color=white>" + bld_mat_need + "Mt</color> of building material.\n\n" +
            "The construction time is dependant on the amount of usable energy being converted, bigger energy output means longer construction time, in this case: <color=white>" + bld_time + " years</color>\n\n" + not_Enough;

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
