using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
  protected string name;
  protected float speed;

  public void Move(Vector3 direction)
  {
    transform.position += direction * speed * Time.deltaTime;
  }

  public void Berbicara()
  {

  }

  public void UseLighting()
  {

  }
}
