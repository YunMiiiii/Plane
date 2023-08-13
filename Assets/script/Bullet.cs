using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ÃÑ¾Ë 
public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.up;

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
}
