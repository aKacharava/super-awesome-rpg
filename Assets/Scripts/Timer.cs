using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;

    private float startTime;

    private bool finished = false;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (finished)
            return;

		float time = Time.time - startTime;

        float minute = time / 60;
        //float second = time % 60;

        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds;

        Finish(minute);
	}

    void Finish(float time)
    {
        if(time >= 15)
        {
            finished = true;
            Application.Quit();
        }
    }
}
