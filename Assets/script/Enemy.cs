using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    GameObject Player;

    int hp = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision otherObject)
    {
        hp--;
        if (otherObject.gameObject.tag == "Player")
        {
            Player.GetComponent<playerMove>().hp--;
            if(Player.GetComponent<playerMove>().hp < 0)
            {
                Destroy(otherObject.gameObject);
            }
        
        else if (hp < 0)
            {
                Destroy(gameObject);
                Destroy(otherObject.gameObject);
            }
            
        }
    }
}
