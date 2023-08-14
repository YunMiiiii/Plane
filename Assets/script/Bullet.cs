using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�Ѿ� 
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
    
    //�Ѿ��� ���� �浹�ϸ� ��(�Ѿ�)��, ���� �ı�
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
