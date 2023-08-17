using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//점수

public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    GameObject Player;

    int hp = 3;

    GameManager gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision otherObject)
    {
        hp--;
        //피격시 attackScore를 10씩 올린다.
        gameManager.attackScore += 10;
        gameManager.attackScoreTxt.text = gameManager.attackScore.ToString();

        if (otherObject.gameObject.tag == "Player")
        {
            Player.GetComponent<playerMove>().hp--;
            if (Player.GetComponent<playerMove>().hp < 0)
            {
                Destroy(otherObject.gameObject);

                gameManager.bestScore = gameManager.attackScore + gameManager.destroyScore;
                gameManager.bestScoreTxt.text = gameManager.bestScore.ToString();

                //최고점수를 플렛폼 레지스트리에 저장
                PlayerPrefs.SetInt("Best Score", gameManager.bestScore);
            }
            //피격시 destroyScore를 100씩 올린다.
            gameManager.destroyScore += 100;
            gameManager.destroyScoreTxt.text = gameManager.destroyScore.ToString();

            Destroy(gameObject);
        }
        else if (hp < 0)
        {
            Destroy(gameObject);
            Destroy(otherObject.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {

    }
    private void OnCollisionExit(Collision collision)
    {

    }

}

