using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject EnemyBullet;
    float currenTime;
    public float createTime = 1;
    

    // Update is called once per frame
    void Update()
    {
        currenTime += Time.deltaTime;
        if(currenTime > createTime)
        {
            GameObject bulletGO = Instantiate(EnemyBullet);

            bulletGO.transform.position = transform.position;

            currenTime = 0;
        }
    }
}
