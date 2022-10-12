using UnityEngine;
using System.Collections;

public class SpinObj : MonoBehaviour {

    public float speed = 1.0f;
    public float radius = 1.0f;
    public float height = 1.0f;
    public float offset = 0.0f;

    private float angle = 0.0f;

    void Update()
    {
        angle += speed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Cos(angle) * radius, height, Mathf.Sin(angle) * radius) + transform.parent.position;
        transform.LookAt(transform.parent.position + new Vector3(0, height, 0));
    }
}