using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Manager : MonoBehaviour {

    public Text textShow;
    private string getText = "";

    

    //方法：获取点击数字并且显示到屏幕上
    private string getString (string num)
    {
        
        getText += num;
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

    public void getAdd ()
    {
        textShow.text = getString("+");
    }
    public void getMinus()
    {
        textShow.text = getString("-");
    }
    public void getMultiply()
    {
        textShow.text = getString("*");
    }
    public void getDivide()
    {
        textShow.text = getString("/");
    }
    void show()
    {

    }

}
