using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
  public GameObject enemyPrefab;
  public Sprite[] enemySprites;
  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("RandomSpawn", 1, 2);
  }

  private void RandomSpawn()
  {
    Vector3 posSpawn = gameObject.transform.position + new Vector3(Random.Range(-2.5f, 2.5f), 0, 0);
    GameObject e = Instantiate(enemyPrefab, posSpawn, Quaternion.identity);
    e.GetComponent<SpriteRenderer>().sprite = enemySprites[Random.Range(0, enemySprites.Length)];
    e.GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.01f, 0.1f);
  }
}
