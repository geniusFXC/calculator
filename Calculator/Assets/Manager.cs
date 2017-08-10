using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Manager : MonoBehaviour 
{
    public Text show;//显示器
    private double result = 0;//结果
    public static string last = "";//上一个数字
    //变量最好开始就赋值，不然后来可能会出现引用空对象的情况；
    public static string num = "";//这个数字
    public static string sign = "";//运算符标志
    public static string flag = "";//等于标志
    

	void Start () 
	{
        
	}
	
	void Update () 
	{
        //try
        //{
        //    Operation();
        //}
        //catch (InvalidCastException e)
        //{
        //    print("操作不正确！" + e.Message);
        //}
        Operation();

	}


    void Operation()//运算
    {
        if ("=" == flag)
        {
            switch (sign)
            {
                case "+":
                    result = Convert.ToDouble(last) + Convert.ToDouble(num);
                    show.text = result.ToString();
                    break;
                case "-":
                    result = Convert.ToDouble(last) - Convert.ToDouble(num);
                    show.text = result.ToString();
                    break;
                case "*":
                    result = Convert.ToDouble(last) * Convert.ToDouble(num);
                    show.text = result.ToString();
                    break;
                case "/":
                    result = Convert.ToDouble(last) / Convert.ToDouble(num);
                    show.text = result.ToString();
                    break;
            }
            num = result.ToString();
            flag = "";
            sign = "";
        }

    }
}
