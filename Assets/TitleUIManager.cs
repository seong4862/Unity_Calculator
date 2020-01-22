using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene을 사용하기 위해 필요!

public class TitleUIManager : MonoBehaviour
{
   public void OnClickStartButton()
    {
        Debug.Log("Click Start Button");
        SceneManager.LoadScene("CalculatorScene");
    }
}
