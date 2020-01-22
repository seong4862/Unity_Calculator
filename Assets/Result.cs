using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text result;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("시작");
        result.text = PlayerPrefs.GetString("Result");
        Debug.Log("결과 : " + PlayerPrefs.GetString("Result","N/A"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
