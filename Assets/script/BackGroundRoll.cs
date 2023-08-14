using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRoll : MonoBehaviour
{
    float currentTime;
    public float speed = 1.0f;
    public Material Material;

    // Update is called once per frame
    void Update()
    {
        currentTime += speed * Time.deltaTime;

        Material.mainTextureOffset = Vector3.up * currentTime;
    }
}
