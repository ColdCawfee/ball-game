using UnityEngine;
using System.Collections;
 
public class MovingObj  : MonoBehaviour
{
  //This value the user can change in the Inspector.
  public float speed = 2;
  void Update()
{
  //We use PingPong to move the object back and forth
  transform.position = new Vector3(Mathf.PingPong(Time.time*speed, 4), transform.position.y, transform.position.z);
}
 
}