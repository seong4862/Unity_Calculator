using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cal : MonoBehaviour
{
    public Text label;
    int _num1 = 0;
    bool _second = false;
    bool _isPlus = false;
    bool _isMinus = false;
    bool _isMultiply = false;
    bool _isDivision = false;

    // 숫자 버튼 눌렀을 때
    public void Onclicked_Num(int num)
    {
        if (_second == false)
        {
            if (label.text == "0")
            {
                label.text = num.ToString();
            }
            else
            {
                label.text += num;
            }
        }
        else
        {
            label.text = num.ToString();
            _second = false;
        }
    }

    // C 버튼 눌렀을 때
    public void Onclicked_C()
    {
        label.text = "0";
    }

    // + 버튼 눌렀을 때
    public void Onclicked_P()
    {
        _num1 = int.Parse(label.text);
        Debug.Log("숫자 1 : " + _num1);
        _isPlus = true;
        _second = true;
    }

    // - 버튼 눌렀을 때
    public void Onclicked_M()
    {
        _num1 = int.Parse(label.text);
        Debug.Log("숫자 1 : " + _num1);
        _isMinus = true;
        _second = true;
    }

    // * 버튼 눌렀을 때
    public void Onclicked_MP()
    {
        _num1 = int.Parse(label.text);
        Debug.Log("숫자 1 : " + _num1);
        _isMultiply = true;
        _second = true;
    }

    // / 버튼 눌렀을 때
    public void Onclicked_D()
    {
        _num1 = int.Parse(label.text);
        Debug.Log("숫자 1 : " + _num1);
        _isDivision = true;
        _second = true;
    }
    // = 버튼 눌렀을 때
    public void Onclicked_E()
    {
        int _num2 = int.Parse(label.text);
        int last = 0;

        if (_isPlus == true) last = _num1 + _num2;
        else if (_isMinus == true) last = _num1 - _num2;
        else if (_isMultiply == true) last = _num1 * _num2;
        else last = _num1 / _num2;

        label.text = last.ToString();

        string r;
        r = label.text.ToString();
        PlayerPrefs.SetString("Result", r);
        Debug.Log("check : " + PlayerPrefs.GetString("Result"));
    }
}
