using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 此脚本用于测试运行状态下的物体坐标朝向控制是否正常
public class PointTest : MonoBehaviour
{
    public GameObject[] Points;//想要控制的点
    public Vector3[] Positions;//设定控制的点的位置
    public Vector3[] Rotation_Euler;//以欧拉角形式设置点的方向
    public Vector3[] Control_Vector;//以向量形式设置点的方向
    private vector2euler V2E;
    
    void Start()
    {
        V2E = GetComponent<vector2euler>();
    }

    
    void Update()
    {
        for (int i = 0; i < Points.Length; i++) 
        {
            Points[i].transform.position = Positions[i];
            print("the position of point " + i + " is " + Points[i].transform.position);


            //欧拉角控制方法，和向量控制方法只激活一个
            //Points[i].transform.rotation = Quaternion.Euler(Rotation_Euler[i]);
            //print("the rotation of point " + i + " is " + Points[i].transform.rotation.eulerAngles);
        }

        

        //向量控制方法，和欧拉角控制方法只激活一个
        Points[0].transform.LookAt(Control_Vector[0] * 1000);

        Points[0].transform.Rotate(0, 90, -90);
        print("the rotation of point 0 is " + Points[0].transform.rotation.eulerAngles);
        //Points[1].transform.LookAt(Control_Vector[1] * 1000);
       // print("the rotation of point 1 is " + Points[1].transform.rotation.eulerAngles);
    }
}
