using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
  public float speed = 8f;
  public float goal = 20f;
  public float start = -2f;
  float[] lanes = { -2f, -1f, 0f, 1f, 2f };
  Vector3 startposition;
  Vector3 target;
  void Start()
  {
    startposition = new Vector3(0, transform.position.y, start);
    transform.position = startposition;
    Sendball();
  }
  void Update()
  {
    transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
  }
  void Sendball()
  {
    float randomX = lanes[Random.Range(0, lanes.Length)];
    target = new Vector3(randomX, startposition.y + 1f, goal);
  }
  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Goal")
    {
      enabled = false;
    }
    if (other.tag == "Player")
    {
      transform.position = startposition;
      Sendball();
    }
  }
}
