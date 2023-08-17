using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ����
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
        //���� �ð��� �帥��
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
