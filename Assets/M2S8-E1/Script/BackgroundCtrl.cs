using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCtrl : MonoBehaviour
{
  public TimerCtrl timeRef;
  private void OnMouseDown()
  {
    timeRef.MinusTime(0.25f);
  }
}
