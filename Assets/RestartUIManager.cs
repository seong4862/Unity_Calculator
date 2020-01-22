using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartUIManager : MonoBehaviour
{
    public void OnClickRestartButton()
    {
        Debug.Log("Click Restart Button");
        SceneManager.LoadScene("CalculatorScene");
    }
}
