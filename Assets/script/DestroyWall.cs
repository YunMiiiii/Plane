using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�Ѿ��� ������ �ı�

public class DestroyWall : MonoBehaviour
{
    // �浹 ����
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall" || other.gameObject.tag == "Player")
        {
            return;
        }

        Destroy(other.gameObject);
    }
    //�浹 ��
    private void OnTriggerStay(Collider other)
    {

    }

    //�浹 �ǰ� ����
    private void OnTriggerExit(Collider other)
    {

    }
}
