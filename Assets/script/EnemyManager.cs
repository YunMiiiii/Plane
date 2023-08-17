using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//적을 생성
public class EnemyManager : MonoBehaviour
{
    public float createTime;

    float currentTIme;

    public GameObject Enemy;

    public int minTime = 5;
    public int maxTime = 8;

    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        //현재 시간이 흐른다
        currentTIme += Time.deltaTime;
        //print("currentTime" + currentTIme);

        if (currentTIme > createTime)
        {
            GameObject enemyGO = Instantiate(Enemy);
            enemyGO.transform.position = transform.position;

            currentTIme = 0;
        }
    }
}
