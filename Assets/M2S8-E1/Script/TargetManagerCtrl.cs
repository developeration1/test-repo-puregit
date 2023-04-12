using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManagerCtrl : MonoBehaviour
{
  private GameObject[] targets;
  // Start is called before the first frame update
  void Start()
  {
    targets = GameObject.FindGameObjectsWithTag("Target");
    CleanTargets();
  }

  public void CleanTargets()
  {
    foreach (GameObject target in targets)
    {
      target.SetActive(false);
    }
    RandomTargetGenerator();
  }

  public void RandomTargetGenerator()
  {

    int targetIndex = Random.Range(0, targets.Length);
    GameObject activo = GameObject.FindGameObjectWithTag("Target");
    if (activo != null)
    {
      while (activo.name == targets[targetIndex].name)
      {
        targetIndex = Random.Range(0, targets.Length);
      }
    }

    targets[targetIndex].SetActive(true);
  }
}
