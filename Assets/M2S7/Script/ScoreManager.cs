using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
  public int score = 10;
  // Start is called before the first frame update
  void Start()
  {
    SetTextScore();
  }

  public void SetTextScore()
  {
    gameObject.GetComponent<TextMeshProUGUI>().text = score.ToString();
  }
}
