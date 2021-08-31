using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public const string saveSeparator = "//";

    public Button Button0, Button1, Button2, Button3;

    private void Start()
    {
        Button btn = Button0.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);

        Button btn1 = Button1.GetComponent<Button>();
        btn1.onClick.AddListener(OnClick1);

        Button btn2 = Button2.GetComponent<Button>();
        btn2.onClick.AddListener(OnClick2);

        Button btn3 = Button3.GetComponent<Button>();
        btn3.onClick.AddListener(OnClick3);
    }
    private void OnClick()
    {
        transform.position = new Vector3(Convert.ToSingle(2028.5), 0);

        if (File.Exists(Application.dataPath + "/SaveTxt/save.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/SaveTxt/save.txt");
            string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

            PublicLoad Load = new PublicLoad();

            Load.RawM.text = content[0];
            Load.EnergyP.text = content[1];
            Load.PopG.text = content[2];
        }
        else
        {
            PublicSave Save = new PublicSave();

            File.WriteAllText(Application.dataPath + "/SaveTxt/save.txt", Save.saveStringReal);
        }
    }

    private void OnClick1()
    {
        transform.position = new Vector3(Convert.ToSingle(2028.5), 0);

        if (File.Exists(Application.dataPath + "/SaveTxt/save1.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/SaveTxt/save1.txt");
            string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

            PublicLoad Load = new PublicLoad();

            Load.RawM.text = content[0];
            Load.EnergyP.text = content[1];
            Load.PopG.text = content[2];
        }
        else
        {
            PublicSave Save = new PublicSave();

            File.WriteAllText(Application.dataPath + "/SaveTxt/save1.txt", Save.saveStringReal);
        }
    }

    private void OnClick2()
    {
        transform.position = new Vector3(Convert.ToSingle(2028.5), 0);

        if (File.Exists(Application.dataPath + "/SaveTxt/save2.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/SaveTxt/save2.txt");
            string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

            PublicLoad Load = new PublicLoad();

            Load.RawM.text = content[0];
            Load.EnergyP.text = content[1];
            Load.PopG.text = content[2];
        }
        else
        {
            PublicSave Save = new PublicSave();

            File.WriteAllText(Application.dataPath + "/SaveTxt/save2.txt", Save.saveStringReal);
        }
    }

    private void OnClick3()
    {
        transform.position = new Vector3(Convert.ToSingle(2028.5), 0);

        if (File.Exists(Application.dataPath + "/SaveTxt/save3.txt"))
        {
            string saveString = File.ReadAllText(Application.dataPath + "/SaveTxt/save3.txt");
            string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

            PublicLoad Load = new PublicLoad();

            Load.RawM.text = content[0];
            Load.EnergyP.text = content[1];
            Load.PopG.text = content[2];
        }
        else
        {
            PublicSave Save = new PublicSave();

            File.WriteAllText(Application.dataPath + "/SaveTxt/save3.txt", Save.saveStringReal);
        }
    }
}
