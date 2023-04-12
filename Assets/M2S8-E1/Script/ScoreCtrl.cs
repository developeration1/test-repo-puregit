using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCtrl : MonoBehaviour
{
  private int scoreCount = 0;
  public TextMeshProUGUI scoreText;

  public void ScoreAdd(int points)
  {
    scoreCount += points;
    scoreText.text = "Score: " + scoreCount.ToString();
  }

  public void ScoreReset()
  {
    scoreCount = 0;
    scoreText.text = "Score: " + scoreCount.ToString();
  }
}
