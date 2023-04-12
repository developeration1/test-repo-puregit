using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCtrl : MonoBehaviour
{
  public GameObject fruitBase;
  public float dirX;
  private int index;

  public List<GameObject> fruitSpaces;
  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("newFruit", 1f, 0.5f);
  }

  private void newFruit()
  {
    if (index == fruitSpaces.Count)
    {
      index = 0;
    }
    fruitSpaces[index].SetActive(true);
    fruitSpaces[index].transform.position = gameObject.transform.position;
    fruitSpaces[index].transform.rotation = Quaternion.identity;
    fruitSpaces[index].GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    fruitSpaces[index].GetComponent<Rigidbody2D>().angularVelocity = 0f;
    //GameObject f = Instantiate(fruitBase, gameObject.transform.position, Quaternion.identity);
    fruitSpaces[index].GetComponent<Rigidbody2D>().AddForce(new Vector2(dirX, 1) * Random.Range(3000, 4500));
    index++;
  }

}
