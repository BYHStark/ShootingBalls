using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject brick;
    public int cloneNumber = 10;//列数
    public int rowNumber = 5;//行数
    void Start()
    {
        Debug.Log("start");
        for(int rowIndex = 0; rowIndex < 5; rowIndex++)
        {
            for (int cloneIndex = 0; cloneIndex < 10; cloneIndex++)
            {
                Instantiate(brick, new Vector3(cloneIndex * 1.2f, 1.1f+rowIndex, 0), Quaternion.identity);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
