using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//player이동
//player hp생성
public class playerMove : MonoBehaviour
{
    public float speed = 5;
    public int hp = 5;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = Vector3.right * h + Vector3.up * v;
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
