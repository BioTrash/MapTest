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
    public Button Pause, First, Second, Third;
    public bool timeCheck_1st, timeCheck_2nd, timeCheck_3rd;
    public int year = 2420;
    public int month = 1;
    public float day;

    private void Start()
    {
        timeCheck_1st = false;
        timeCheck_2nd = false;
        timeCheck_3rd = false;

        Date.text = "Year: 2420 Month: 1 Day: 0";

        Button pause = Pause.GetComponent<Button>();
        pause.onClick.AddListener(Pause_Date);

        Button first = First.GetComponent<Button>();
        first.onClick.AddListener(First_Speed);

        Button second = Second.GetComponent<Button>();
        second.onClick.AddListener(Second_Speed);

        Button third = Third.GetComponent<Button>();
        third.onClick.AddListener(Third_Speed);
    }

    private void Pause_Date()
    {
        Date.text = "Year: " + year + " Month: " + Convert.ToString(month) + " Day: " + Convert.ToString(Math.Round(day));

        timeCheck_1st = false;
        timeCheck_2nd = false;
        timeCheck_3rd = false;
    }

    private void Third_Speed()
    {
        timeCheck_1st = false;
        timeCheck_2nd = false;
        timeCheck_3rd = true;
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

    private void Second_Speed()
    {
        timeCheck_1st = false;
        timeCheck_2nd = true;
        timeCheck_3rd = false;
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
    private void First_Speed()
    {
        timeCheck_1st = true;
        timeCheck_2nd = false;
        timeCheck_3rd = false;
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
        if (timeCheck_1st == true)
        {
            day += Time.deltaTime * 24;
            First_Speed();
        }
        else if (timeCheck_2nd == true)
        {
            day += Time.deltaTime * (24*4);
            Second_Speed();
        }
        else if (timeCheck_3rd == true)
        {
            day += Time.deltaTime * (24 * 16);
            Third_Speed();
        }
    }
}
