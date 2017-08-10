using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class _Manager : MonoBehaviour {

    public Text textShow;//屏幕显示
    private String temp = "";//获取字符的中间变量
    private String lastNum = "";   
    private String secondNum = "";
    private String sign = "";
    private Double result = 0;



    //方法：获取点击数字并且显示到屏幕上
    private string getString (string num)
    {

        temp += num;
        secondNum += num;
        if (sign == "=")
        {
            clear();
            temp += num;
            secondNum += num;
        } 
       else if (num == "+" || num == "-" || num == "*" || num == "/")
        {
            sign = num;
            lastNum = textShow.text;
            secondNum = "";
        }

        
        

        
        return temp;
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
        //lastNum = textShow.text;
        textShow.text = getString("+");
        //secondNum = "";
        //sign = "+";

        //Debug.Log(lastNum);
    }
    public void getMinus()
    {
        //lastNum = textShow.text;
        textShow.text = getString("-");
        //secondNum = "";
        //sign = "-";
    }
    public void getMultiply()
    {
        //lastNum = textShow.text;
        textShow.text = getString("*");
        //secondNum = "";
        //sign = "*";
    }
    public void getDivide()
    {
        //lastNum = textShow.text;
        textShow.text = getString("/");
        //secondNum = "";
        //sign = "/";
    }
    #endregion
    //计算结果
    public void equal()
    {

        Debug.Log(lastNum);
        Debug.Log(secondNum);
        switch (sign)
        {    
            case "+":
                result = Convert.ToDouble(lastNum) + Convert.ToDouble(secondNum);
                break;
            case "-":
                result = Convert.ToDouble(lastNum) - Convert.ToDouble(secondNum);
                break;
            case "*":
                result = Convert.ToDouble(lastNum) * Convert.ToDouble(secondNum);
                break;
            case "/":
                result = Convert.ToDouble(lastNum) / Convert.ToDouble(secondNum);
                break;

        }
        textShow.text = result.ToString();
        sign = "=";




    }
    //清空全部数据
    public void clear()
    {
        textShow.text = "";
        temp = "";
        lastNum = "";
        secondNum = "";
        sign = "";
        result = 0;
    }

}
