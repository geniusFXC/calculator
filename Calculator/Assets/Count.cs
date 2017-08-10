using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Count : MonoBehaviour 
{
    public Text Show;

	
	void Start () 
	{
        //按钮调用函数时，不会执行脚本中的start函数，仅仅调用了那个脚本中的一个函数而已
	}
	
    //计数
    public void Get0()
    {
        Show.text += "0";
        Manager.num += "0";
    }
    public void Get1()
    {
        Show.text += "1";
        Manager.num += "1";
    }
    public void Get2()
    {
        Show.text += "2";
        Manager.num += "2";
    }
    public void Get3()
    {
        Show.text += "3";
        Manager.num += "3";
    }
    public void Get4()
    {
        Show.text += "4";
        Manager.num += "4";
    }
    public void Get5()
    {
        Show.text += "5";
        Manager.num += "5";
    }
    public void Get6()
    {
        Show.text += "6";
        Manager.num += "6";
    }
    public void Get7()
    {
        Show.text += "7";
        Manager.num += "7";
    }
    public void Get8()
    {
        Show.text += "8";
        Manager.num += "8";
    }
    public void Get9()
    {
        Show.text += "9";
        Manager.num += "9";
    }
    public void Dot()//输入.号
    {
        if("" != Manager.num)
        {
            if (!Manager.num.Contains("."))//不让.连续出现
            {
                Show.text += ".";
                Manager.num += ".";
            }
        }
    }

    /*
    String str1 = null; str引用为空

    String str2 = ""; str引用一个空串

    也就是null没有分配空间，""分配了空间，因此str1还不是一个实例化的对象，而str2已经实例化。

    注意因为null不是对象，""是对象。
    */

    public void Add()//加法
    {
        if ("" != Manager.num)
        {
            Manager.last = Manager.num;
            Show.text += "+";
            Manager.sign = "+";
            Manager.num = "";
        }
    }
    public void Minus()//减法
    {
        if ("" != Manager.num)
        {
            Manager.last = Manager.num;
            Show.text += "-";
            Manager.sign = "-";
            Manager.num = "";
        }
    }
    public void Multiply()//乘法
    {
        if ("" != Manager.num)
        {
            Manager.last = Manager.num;
            Show.text += "*";
            Manager.sign = "*";
            Manager.num = "";
        }
    }
    public void Divide()//除法
    {
        if ("" != Manager.num)
        {
            Manager.last = Manager.num;
            Show.text += "/";
            Manager.sign = "/";
            Manager.num = "";
        }
    }
    public void Equal()//等于
    {
        if ("" != Manager.num)
        {
            Manager.flag = "=";
        }

    }

    /*
     *SubString的用法：
     * 第一个参数是从字符串的第几个开始，第二个参数是长度
     * 如：
     * "abcdefg".substring(4,2) 
        返回的值为：ef 
        从字符串"abcdefg"中第4位开始取，取2位。 
     */
    public void Backspace()//退格
    {
        if ("" != Show.text)
        {
            string t = Show.text.Substring(Show.text.Length - 1, 1);
            if ("+" == t || "-" == t || "*" == t || "/" == t)//判断显示器上最后一个字符是数字还是运算符
            {
                Manager.sign = "";
            }
            else
            {

                if ("" == Manager.num)//当num被删完后跳向last，不然字符为空，删除就会超出字符串长度
                {
                    Manager.num = Manager.last;
                    Manager.num = Manager.num.Substring(0, Manager.num.Length - 1);
                }
                else
                {
                    Manager.num = Manager.num.Substring(0, Manager.num.Length - 1);
                }

            }
            Show.text = Show.text.Substring(0, Show.text.Length - 1);
        }
        
    }

    public void Clear()//清除
    {
        Manager.num = "";
        Manager.last = "";
        Manager.sign = "";
        Manager.flag = "";
        Show.text = "";
    }

}
