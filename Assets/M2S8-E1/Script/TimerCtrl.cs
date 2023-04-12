using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCtrl : MonoBehaviour
{
  public float startTime = 10f;
  public TextMeshProUGUI timerText;
  private float actualTime;
 
  // Start is called before the first frame update
  void Start()
  {
    actualTime = startTime;
  }

  // Update is called once per frame
  void Update()
  {
    if (actualTime > 0)
    {
      actualTime -= Time.deltaTime;
    }
    else
    {
      actualTime = 0;
    }

    timerText.text = actualTime.ToString("0.00");
  }
  public void AddTime(float timeToAdd)
  {
    actualTime += timeToAdd;
  }
  public void MinusTime(float timeToQuit)
  {
    if (actualTime - timeToQuit > 0)
    {
      actualTime -= timeToQuit;
    }
    else
    {
      actualTime = 0;
    }
  }
  public float GetTimer()
  {
    return actualTime;
  }

  public void TimerReset()
  {
    actualTime = startTime;
  }
}
