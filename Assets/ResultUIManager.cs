using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene을 사용하기 위해 필요!

public class ResultUIManager : MonoBehaviour
{
    public void OnClickResultButton()
    {
        Debug.Log("Click Result Button");
        SceneManager.LoadScene("EndScene");
    }
}
