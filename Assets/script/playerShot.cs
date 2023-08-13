using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

// ��ǥ : ����� �Է�(�����̽���)�� �޾� �Ѿ��� �����. 
// ����1 �Է��� �ް�ʹ�.
// ����2 �Ѿ��� �����ʹ�.

//��ǥ2: �������� �Ծ��ٸ�, ��ų ������ �ö󰣴�.

//��ǥ3 : �߻�� ����Ŵ����� ������ҽ��� ����Ѵ�.
// ����. ���۽� ����Ŵ����� �ҷ��´�
//�ʿ�Ӽ� : ����Ŵ���

public class PlayerFire : MonoBehaviour
{
    public int skillLevel = 0;
    public GameObject Bullet;

    

    
    // Update is called once per frame
    void Update()
    {
        // ����1 �Է��� �ް�ʹ�.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ExcuteSkill(skillLevel);
        }

    }

    private void ExcuteSkill(int _skillLevel)
    {
        switch (_skillLevel)
        {
            case 0:
                ExcuteSkill();
                break;
            case 1:
                ExcuteSkill1();
                break;
            case 2:
                ExcuteSkill2();
                break;
            case 3:
                ExcuteSkill3();
                break;

        }

        

        // �Ѱ��� �Ѿ��� �߻�ȴ�.
        void ExcuteSkill()
        {
            // ����2 �Ѿ��� �����ʹ�.
            GameObject bulletGO = Instantiate(Bullet);

            //����3 : �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� ���صΰ� �ʹ�.
            bulletGO.transform.position = transform.position;
        }

        // �ΰ��� �Ѿ��� �߻�ȴ�.
        void ExcuteSkill1()
        {
            // ����2 �Ѿ��� �����ʹ�.
            GameObject bulletGO = Instantiate(Bullet);
            GameObject bulletGO1 = Instantiate(Bullet);

            //����3 : �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� ���صΰ� �ʹ�.
            bulletGO.transform.position = transform.position + new Vector3(-0.5f, 0, 0);
            bulletGO1.transform.position = transform.position + new Vector3(0.5f, 0, 0);

        }

        // ������ �Ѿ��� �߻�ȴ�
        // 1, 2, 3�Ѿ� �� 1, 3 �Ѿ��� ���� Z������ -30��, 30�� ȸ�� �� �߻�ȴ�.
        void ExcuteSkill2()
        {
            // ����2 �Ѿ��� �����ʹ�.
            GameObject bulletGO = Instantiate(Bullet);

            //����3 : �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� ���صΰ� �ʹ�.
            bulletGO.transform.position = transform.position;

            // ����2 �Ѿ��� �����ʹ�.
            GameObject bulletGO1 = Instantiate(Bullet);
            GameObject bulletGO2 = Instantiate(Bullet);

            //����3 : �Ѿ��� ��ġ�� �÷��̾��� ��ġ�� ���صΰ� �ʹ�.
            bulletGO1.transform.position = transform.position + new Vector3(-0.8f, 0, 0);
            bulletGO1.transform.rotation = Quaternion.Euler(0, 0, 30);
            bulletGO1.GetComponent<Bullet>().dir = bulletGO1.transform.up;


            bulletGO2.transform.position = transform.position + new Vector3(0.8f, 0, 0);
            bulletGO2.transform.rotation = Quaternion.Euler(0, 0, -30);
            bulletGO2.GetComponent<Bullet>().dir = bulletGO2.transform.up;
        }

        void ExcuteSkill3()
        {
            int degree = 15;
            int numOfBullet = 360 / degree;

            for (int i = 0; i < numOfBullet; i++)
            {
                GameObject bulletGO = Instantiate(Bullet);

                bulletGO.transform.position = transform.position;
                bulletGO.transform.rotation = Quaternion.Euler(0, 0, i * degree);
                bulletGO.GetComponent<Bullet>().dir = bulletGO.transform.up;

            }
        }
    }


    //��ǥ2: �������� �Ծ��ٸ�, ��ų ������ �ö󰣴�.
    //�ܰ�1. �������� �Ծ��ٸ�
    //�ܰ�2. ��ų������ 1�ö󰣴�.
    //�ܰ�3. �������� �ı��Ѵ�.
    private void OnTriggerEnter(Collider other)
    {
        //�ܰ�1. �������� �Ծ��ٸ�
        if (other.gameObject.tag == "Item")
        {
            //�ܰ�2. ��ų������ 1�ö󰣴�.(�ִ� ��ų������ �ʰ��ϱ� ������)
            if (skillLevel < 3)
            {
                skillLevel++;
            }
            //�ܰ�3. �������� �ı��Ѵ�.
            Destroy(other.gameObject);
        }
    }
}
