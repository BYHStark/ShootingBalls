using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    // Update is called once per frame
    public GameObject shootPosition;//����λ��
    public float force;//Ͷ������
    public Rigidbody ballPrefab;
    public float speed = 10f;
    void Update()
    {

        if (Input.GetMouseButton(0))//��������������
        {
            Instantiate(ballPrefab, shootPosition.transform.position, Quaternion.identity);
            Rigidbody ball = ballPrefab.GetComponent<Rigidbody>();
            ball.AddForce(force * shootPosition.transform.forward);
        }

        //�������Ҽ�ʵ�ַ���λ�õ��ƶ�
        float h = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(h,v,0f);
    }
}
