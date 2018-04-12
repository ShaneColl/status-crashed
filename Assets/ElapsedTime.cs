using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ElapsedTime : MonoBehaviour
{
    public static int timeE = 0;
    public Text elapsedText;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("GainTime");
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)timeE % 60 < 10)
        {
            elapsedText.text = ("Time Elapsed: 0" + (int)timeE / 60 + ":0" + (int)timeE % 60);
        }
        else
        {
            elapsedText.text = ("Time Elapsed: 0" + (int)timeE / 60 + ":" + (int)timeE % 60);
        }

        if (TimeOfCollision.isCollision == true)
        {
            StopCoroutine("GainTime");
        }
    }

    IEnumerator GainTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeE++;
        }
    }
}