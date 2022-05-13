using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    // Update is called once per frame
    public GameObject shootPosition;//发射位置
    public float force;//投掷力度
    public Rigidbody ballPrefab;
    public float speed = 10f;
    void Update()
    {

        if (Input.GetMouseButton(0))//摁下鼠标左键发射
        {
            Instantiate(ballPrefab, shootPosition.transform.position, Quaternion.identity);
            Rigidbody ball = ballPrefab.GetComponent<Rigidbody>();
            ball.AddForce(force * shootPosition.transform.forward);
        }

        //键盘左右键实现发射位置的移动
        float h = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(h,v,0f);
    }
}
