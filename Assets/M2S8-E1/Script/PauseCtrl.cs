using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseCtrl : MonoBehaviour
{

  public void PauseScaleTime(float scaleTime)
  {
    Time.timeScale = scaleTime;
  }

  public void RestartGame(){
    //SceneManager.LoadScene(0);
  }

  public void ExitGame(){
    Application.Quit();
  }
}
