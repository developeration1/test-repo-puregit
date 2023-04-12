using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCtrl : MonoBehaviour
{
  public float startTime;//90
  public TextMeshProUGUI timerText;
  // Start is called before the first frame update
  void Start()
  {
    timerText.text = startTime.ToString();//90
    //Tiempo actual mas tiempo del temporisador
    startTime = Time.time + startTime;
  }

  // Update is called once per frame
  void Update()
  {
    if (startTime > 0)
    {
      //tiempo del temporizador, restar el tiempo transcurrido
      startTime -= Time.deltaTime;
      timerText.text = startTime.ToString("0.0");
    }
  }
}
