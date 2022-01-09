using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public TextMeshProUGUI Date;
    public int year = 2420;
    public int month = 1;
    public float day;

    private void Start()
    {
        Timer();
    }
    private void Timer()
    {
        switch (month)
        {
            case 1:
                if (day >= 31)
                {
                    month = 2;
                    day = 1;
                }
                break;
            case 2:

                if (day >= 28)
                {
                    month = 3;
                    day = 1;
                }
                break;
            case 3:

                if (day >= 31)
                {
                    month = 4;
                    day = 1;
                }
                break;
            case 4:

                if (day >= 30)
                {
                    month = 5;
                    day = 1;
                }
                break;
            case 5:

                if (day >= 31)
                {
                    month = 6;
                    day = 1;
                }
                break;
            case 6:

                if (day >= 30)
                {
                    month = 7;
                    day = 1;
                }
                break;
            case 7:

                if (day >= 31)
                {
                    month = 8;
                    day = 1;
                }
                break;
            case 8:

                if (day >= 30)
                {
                    month = 9;
                    day = 1;
                }
                break;
            case 9:

                if (day >= 31)
                {
                    month = 10;
                    day = 1;
                }
                break;
            case 10:

                if (day >= 30)
                {
                    month = 11;
                    day = 1;
                }
                break;
            case 11:

                if (day >= 31)
                {
                    month = 12;
                    day = 1;
                }
                break;
            case 12:

                if (day >= 31)
                {
                    month = 1;
                    day = 1;
                    year++;
                }
                break;
        }

        Date.text = "Year: " + year + " Month: " + Convert.ToString(month) + " Day: " + Convert.ToString(Math.Round(day));
    }

    private void Update()
    {
        day += Time.deltaTime;

        Timer();
    }
}
