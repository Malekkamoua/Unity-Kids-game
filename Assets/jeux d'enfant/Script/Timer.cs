using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    
    public float timeStart = 10;
    public Text textBox;

    void Start()
    {
        textBox.text = timeStart.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();

        if (timeStart < 0)
        {
            timeStart = 0;
            textBox.text = Mathf.Round(timeStart).ToString();

            print("timeup");
        }
    }
}
