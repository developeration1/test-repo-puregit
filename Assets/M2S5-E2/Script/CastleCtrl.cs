using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CastleCtrl : MonoBehaviour
{
  public TextMeshProUGUI castleText;
  public int lifes;
  // Start is called before the first frame update
  void Start()
  {
    castleText.text = "Vidas: " + lifes;
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log(other.gameObject.name);
    lifes--;
    castleText.text = "Vidas: " + lifes;

    if (lifes < 5)
    {
      gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }
  }
}
