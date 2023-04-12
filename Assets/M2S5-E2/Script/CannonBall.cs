using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
  public float firePower;
  private float ejeY = 1;

  private Vector3 InitialPosition;
  // Start is called before the first frame update
  void Start()
  {
    InitialPosition = gameObject.transform.position;
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      ejeY -= 0.2f;
    }

    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      ejeY += 0.2f;
    }
  }

  public void Recharge()
  {
    gameObject.transform.position = InitialPosition;

    gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0;


    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, ejeY) * firePower);
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    Recharge();
  }

}
