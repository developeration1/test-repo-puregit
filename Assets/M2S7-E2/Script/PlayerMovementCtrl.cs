using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementCtrl : MonoBehaviour
{
  public float moveSpeed;
  public GameObject bullet;

  public float shootForce;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float movementX = Input.GetAxis("Horizontal");

    if (movementX < 0 && transform.position.x > -2.5)
    {
      transform.Translate(Vector3.right * movementX * moveSpeed * Time.deltaTime);
    }
    else if (movementX > 0 && transform.position.x < 2.5)
    {
      transform.Translate(Vector3.right * movementX * moveSpeed * Time.deltaTime);
    }
 
    if (Input.GetButtonDown("Jump"))
    {
      GameObject b = Instantiate(bullet, transform.position, Quaternion.identity);
      b.GetComponent<Rigidbody2D>().AddForce(Vector2.up * shootForce);
    }

  }

}
