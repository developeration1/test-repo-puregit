using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCtrl : MonoBehaviour
{
  private TimerCtrl timerRef;
  private ScoreCtrl scoreRef;
  private TargetManagerCtrl tarManRef;
  private ParticleSystem partRef;

  private void Start()
  {
    //timerRef = new TimerCtrl();
    timerRef = GameObject.Find("Timer").GetComponent<TimerCtrl>();
    scoreRef = GameObject.Find("Score").GetComponent<ScoreCtrl>();
    tarManRef = GameObject.Find("Targets").GetComponent<TargetManagerCtrl>();
    partRef = GameObject.Find("CoinExplosion").GetComponent<ParticleSystem>();
  }
  private void OnMouseDown()
  {
    Debug.Log("Clicked " + gameObject.name);
    if (timerRef.GetTimer() > 0)
    {
      partRef.Play();
      timerRef.AddTime(5f);
      scoreRef.ScoreAdd(1);
      tarManRef.RandomTargetGenerator();
      gameObject.SetActive(false);
    }
  }
}
