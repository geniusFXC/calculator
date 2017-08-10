﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class _Manager : MonoBehaviour {

    public Text textShow;//屏幕显示
    private string getText = "";//获取字符的中间变量
    private String lastNum = "";
    
    private string secondNum = "";



    //方法：获取点击数字并且显示到屏幕上
    private string getString (string num)
    {
       
        getText += num;
        secondNum += num;
        return getText;
    }

 
  
    #region Get Number
    public void getNumber1 ()
    {
        textShow.text = getString("1");


    }
    public void getNumber2()
    {
        textShow.text = getString("2");


    }
    public void getNumber3()
    {
        textShow.text = getString("3");


    }
    public void getNumber4()
    {

        textShow.text = getString("4");

    }
    public void getNumber5()
    {

        textShow.text = getString("5");

    }
    public void getNumber6()
    {

        textShow.text = getString("6");

    }
    public void getNumber7()
    {

        textShow.text = getString("7");

    }
    public void getNumber8()
    {

        textShow.text = getString("8");

    }
    public void getNumber9()
    {

        textShow.text = getString("9");

    }
    public void getNumber0()
    {

        textShow.text = getString("0");

    }




    #endregion

    #region GetOpt
    public void getAdd ()
    {
        lastNum = textShow.text;
        textShow.text = getString("+");
        secondNum = "";

        //Debug.Log(lastNum);
    }
    public void getMinus()
    {
        lastNum = textShow.text;
        textShow.text = getString("-");
    }
    public void getMultiply()
    {
        lastNum = textShow.text;
        textShow.text = getString("*");
    }
    public void getDivide()
    {
        lastNum = textShow.text;
        textShow.text = getString("/");
    }
    #endregion

    public void equal()
    {
        //Debug.Log(secondNum);
        Double result = Convert.ToDouble(lastNum) + Convert.ToDouble(secondNum);
        textShow.text = result.ToString();
    }

}
