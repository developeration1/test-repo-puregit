using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
  //Unidades de fuerza que se aplicaran para el salto (Ejemplo: 500)
  public float jumpForce;
  //Conteo del tiempo restante que se lleva a cabo en la clase TimeCtrl
  public TimeCtrl timeReference;
  //Referencia al componente de interfaz de tipo Slider para indicar el tiempo
  //que hemos durado con el botón de salto precionado
  public Slider forceSlicerIndicator;
  //Variable de tipo bool que nos permite saber si el Magikarp esta tocando el suelo
  private bool isGrounded = false;
  //Varibale que guarda la referencia del tiempo en el momento en que precionamos
  //El botón de salto
  private float timePressCount;
  //Varible donde guardamos el calculo para identificar el tiempo transcurrido
  private float pressTime;
  //Variable de tipo bool para saber si debemos contar el tiempo que ha sido precionado el botón
  //de salto
  private bool isPressTime = false;

  // Update is called once per frame
  void Update()
  {
    //Input.GetButtonDown('Jump');
    if (Input.GetButtonDown("Jump") && isGrounded)
    {
      timePressCount = Time.time;
      isPressTime = true;
    }
    if (isPressTime)
    {
      pressTime = Time.time - timePressCount;
      if (pressTime > 1)
      {
        pressTime = 1;
      }
    }
    forceSlicerIndicator.value = pressTime;
    if (Input.GetButtonUp("Jump") && isGrounded && isPressTime && timeReference.startTime > 0)
    {
      gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce * pressTime);
      isGrounded = false;
      isPressTime = false;
      pressTime = 0;
    }
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.name == "Floor")
    {
      isGrounded = true;
    }
  }
}
