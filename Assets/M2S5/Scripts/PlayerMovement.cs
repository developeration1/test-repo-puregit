using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public float movementSpeed;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    //Debug.Log();
    if (Input.GetAxis("Horizontal") != 0)
    {
      if (Input.GetAxis("Horizontal") > 0 && gameObject.transform.position.x < 6.5f)
      {
        gameObject.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * movementSpeed * Input.GetAxis("Horizontal"));
      }
      else if (Input.GetAxis("Horizontal") < 0 && gameObject.transform.position.x > -6.5f)
      {
        gameObject.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * movementSpeed * Input.GetAxis("Horizontal"));
      }
    }
  }
}
