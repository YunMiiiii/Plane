using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulllet : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector3 dir = Vector3.up;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //ÃÑ ¹Ý´ë·Î ½î´Â°Å ÇØ°á
        player = GameObject.Find("player");
        dir = (player.transform.position - gameObject.transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(dir);
        transform.rotation *= Quaternion.Euler(90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
    }
}
