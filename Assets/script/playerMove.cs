using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//player이동
//player hp생성
public class playerMove : MonoBehaviour
{
    public float speed = 5;
    public int hp = 5;

    public VariableJoystick joystick;
    void Update()
    {

#if UNITY_ANDROID
float h = joystick.Horizontal;
float v = joystick.Vertical;
#elif UNITY_EDITOR || UNTIY_STANDALONE
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
#endif
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
