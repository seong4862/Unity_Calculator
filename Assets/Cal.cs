using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cal : MonoBehaviour
{

    public Text label;
    public Text process;
    int _num = 0;
    int op = 0; // 기본, '+', '-', '*', '/' => 오류 : -1
    List<string> _pc = new List<string>();
    
    // '숫자' 버튼 눌렀을 때
    public void Onclicked_Num(int num)
    {
        label.text = num.ToString();
        _pc.Add(num.ToString());

        if(op == 0)
        {
            _num = num;
        }
        else
        {
            if (op == 1) _num += num;
            else if (op == 2) _num -= num;
            else if (op == 3) _num *= num;
            else
            {
                if (num == 0)
                {
                    label.text = "impossible";
                    _num = 0;
                    //다른 연산자(+, -, *, /) 키 막는 기능 추가
                }
                else _num /= num;
            }
            op = 0;
        }
    }

    // 'C' 버튼 눌렀을 때
    public void Onclicked_C()
    {
        label.text = "0";
        process.text = "";
        _num = 0;
        _pc.Clear();
    }

    /*------- 연산자 버튼을 눌렀을 때 -------*/
    
    // '+' 버튼 눌렀을 때
    public void Onclicked_P()
    {
        
        if(op == 0) _pc.Add("+");
        else _pc[_pc.Count - 1] = "+";

        string tmpt = null;
        foreach (string s in _pc)
        {
            tmpt += s;
        }

        process.text = tmpt;
        label.text = _num.ToString();

        Debug.Log("숫자 1 : " + _num + tmpt);
        op = 1;
    }

    // '-' 버튼 눌렀을 때
    public void Onclicked_M()
    {
        if(op == 0) _pc.Add("-");
        else _pc[_pc.Count - 1] = "-";

        string tmpt = null;
        foreach (string s in _pc)
        {
            tmpt += s;
        }

        process.text = tmpt;
        label.text = _num.ToString();

        Debug.Log("숫자 1 : " + _num);
        op = 2;

    }

    // '*' 버튼 눌렀을 때
    public void Onclicked_MP()
    {

        if(op == 0) _pc.Add("*");
        else _pc[_pc.Count - 1] = "*";

        string tmpt = null;
        foreach(string s in _pc)
        {
            tmpt += s;
        }

        process.text = tmpt;
        label.text = _num.ToString();

        Debug.Log("숫자 1 : " + _num);
        op = 3;
    }

    // '/' 버튼 눌렀을 때
    public void Onclicked_D()
    {

        if (op == 0) _pc.Add("/");
        else _pc[_pc.Count - 1] = "/";

        string tmpt = null;
        foreach (string s in _pc)
        {
            tmpt += s;
        }

        process.text = tmpt;
        label.text = _num.ToString();

        Debug.Log("숫자 1 : " + _num);
        op = 4;
    }
     
    /*------- 결과 출력 -------*/
    
    // '=' 버튼 눌렀을 때
    public void Onclicked_E()
    {
        label.text = _num.ToString();
        if(op == 0) _pc.Add("=");
        else _pc[_pc.Count - 2] = "=";

        string r;
        r = label.text.ToString();
        PlayerPrefs.SetString("Result", r);
        Debug.Log("check : " + PlayerPrefs.GetString("Result"));
    }
}
