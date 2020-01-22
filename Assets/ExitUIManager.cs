using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitUIManager : MonoBehaviour
{
    public void OnClickExitButton()
    {
        Debug.Log("Click Exit Button");
        Application.Quit();
    }
}
