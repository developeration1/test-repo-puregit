using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCtrl : MonoBehaviour
{
  public TextMeshProUGUI pointsLabel;
  public float initialVelocity;

  private int score = 0;
  // Start is called before the first frame update
  void Start()
  {
    gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * initialVelocity;
  }

  // Update is called once per frame
  void Update()
  {
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "Block")
    {
      Debug.Log("CollisionEnter");
      score++;
      pointsLabel.text = "Puntos: " + score;
      Destroy(other.gameObject);
    }
  }
}
