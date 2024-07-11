using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalculateCAP : MonoBehaviour
{
    public AlphaNumerico alphaNumerico;
    public TextMeshProUGUI resultText;

    public void ResultVerification()
    {
        if (alphaNumerico.CAP == resultText.text)
        {
            print("Correcto");
        }
        else
        {
            print("Incorrecto");
        }
    }

    public void btnClear()
    {
        resultText.text = "";
    }

    public void btndigit7()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "7";
        }
        else
        {
            resultText.text = resultText.text + "7";
        }
    }

    public void btndigit8()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "8";
        }
        else
        {
            resultText.text = resultText.text + "8";
        }
    }

    public void btndigit9()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "9";
        }
        else
        {
            resultText.text = resultText.text + "9";
        }
    }

    public void btndigit4()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "4";
        }
        else
        {
            resultText.text = resultText.text + "4";
        }
    }

    public void btndigit5()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "5";
        }
        else
        {
            resultText.text = resultText.text + "5";
        }
    }

    public void btndigit6()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "6";
        }
        else
        {
            resultText.text = resultText.text + "6";
        }
    }

    public void btndigit3()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "3";
        }
        else
        {
            resultText.text = resultText.text + "3";
        }
    }

    public void btndigit2()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "2";
        }
        else
        {
            resultText.text = resultText.text + "2";
        }
    }

    public void btndigit1()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "1";
        }
        else
        {
            resultText.text = resultText.text + "1";
        }
    }

    public void btndigit0()
    {
        if (resultText.text == Convert.ToString("0"))
        {
            resultText.text = "0";
        }
        else
        {
            resultText.text = resultText.text + "0";
        }
    }
}
