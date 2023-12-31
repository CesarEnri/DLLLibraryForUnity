using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TMPro;
using UnityEngine;

public class ReadyCCode : MonoBehaviour
{
    [SerializeField] private TMP_InputField firstNumberInput;
    [SerializeField] private TMP_InputField secondNumberInput;
    [SerializeField] private TextMeshProUGUI sum;
    [SerializeField] private TextMeshProUGUI randomNumberText;
    [SerializeField] private TextMeshProUGUI cppText;
    [SerializeField] private TextMeshProUGUI isCppText;
    [SerializeField] private TextMeshProUGUI pointerText;
    
    [DllImport("DLLForUnityProject.dll")]
    public static extern int getRandomNumber();

    [DllImport("DLLForUnityProject.dll")]
    public static extern int sumNumbers(int a,int b);

    [DllImport("DLLForUnityProject.dll")]
    public static extern void FillString(StringBuilder myString, int length);
    
    [DllImport("DLLForUnityProject.dll")]
    public static extern bool isThisCpp();
  
    [DllImport("DLLForUnityProject.dll")]
    public static extern int getPointer();

    private void Start()
    {
        var randomNumber = getRandomNumber();
        Debug.Log( randomNumber);

        var pointer = getPointer();
        Debug.Log(pointer);

    }

    public void GetPointer()
    {
        int c = getPointer();
        Debug.Log(c.ToString());
    }

    public void GetStringFromNativeCode()
    {
        StringBuilder str = new StringBuilder(100);
        FillString(str, str.Capacity);
        string myString = str.ToString();

        cppText.text = "C++ says: "+ myString;
    }

    public void GetBoolFromNativeCode()
    {
        isCppText.text = "Is this code from c++ : " + isThisCpp();
    }

    public void GetSumNumbersFromNativeCode()
    {   
        int FirstNumber = Convert.ToInt32(firstNumberInput.text);
        int SecondNumber = Convert.ToInt32(secondNumberInput.text);

        sum.text = "= "+ sumNumbers(FirstNumber, SecondNumber).ToString();
    }

    public void GetRandomNumberFromNative()
    {
        randomNumberText.text = "Random Number = "+ getRandomNumber().ToString();
    }
    public void GetPointerFromNative()
    {
        pointerText.text = "Pointer from c++ : " + getPointer().ToString();
    }
    
}
