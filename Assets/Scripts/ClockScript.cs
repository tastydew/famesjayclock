using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockScript : MonoBehaviour
{
    private DateTime currentTime;
    private int hours;
    private int minutes;
    private int seconds;

    private GameObject secondHand;
    private GameObject minuteHand;
    private GameObject hourHand;

    // Start is called before the first frame update
    void Start()
    {
        secondHand = GameObject.Find("SecondHand");
        minuteHand = GameObject.Find("MinuteHand");
        hourHand = GameObject.Find("HourHand");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = DateTime.Now;
        
        hours = currentTime.Hour;
        minutes = currentTime.Minute;
        seconds = currentTime.Second;

        secondHand.transform.eulerAngles = new Vector3(0, 0, (-seconds / 60f) * 360f);
        minuteHand.transform.eulerAngles = new Vector3(0, 0, (-minutes / 60f) * 360f);
        hourHand.transform.eulerAngles = new Vector3(0, 0, (-hours / 12f) * 360f);

    }
}
