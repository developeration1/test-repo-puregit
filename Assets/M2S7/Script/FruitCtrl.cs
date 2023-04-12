using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCtrl : MonoBehaviour
{
  private ScoreManager scoreManager;

  private void Start()
  {
    scoreManager = GameObject.Find("Score").GetComponent<ScoreManager>();
  }
  private void OnMouseDown()
  {
    Debug.Log("Fire:" + gameObject.name);
    scoreManager.score++;
    scoreManager.SetTextScore();
    gameObject.SetActive(false);
  }


  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log(other.gameObject.name);
    if (other.gameObject.tag == "Border")
    {
      //Destroy(gameObject);
    }
    /*
    if (other.gameObject.tag == "Fruit")
    {
      Physics2D.IgnoreCollision(other.gameObject.GetComponent<BoxCollider2D>(), gameObject.GetComponent<BoxCollider2D>());
    }*/
  }
}
