using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterCtrl : MonoBehaviour
{
  public TextMeshProUGUI scoreText;
  public TimeCtrl timeReference;
  private int jumpCount = 0;

  private void Update() {
    if(timeReference.startTime <= 0){
      Debug.Log(jumpCount);
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      jumpCount++;
      scoreText.text = jumpCount.ToString();
      //Debug.Log(jumpCount);
    }
  }
}
