using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//총알 
public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.up;
    public GameObject bulletExplosion;
    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
    
    //총알이 적과 충돌하면 나(총알)와, 적이 파괴
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Player")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
            GameObject bulletExplosionGO = Instantiate(bulletExplosion);
            bulletExplosionGO.transform.position = transform.position;

        }
    }
}
