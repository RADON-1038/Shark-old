using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_and_Rotate : MonoBehaviour
{
    
    public GameObject[] Rigs;
    public Vector3[] TargetDirection;
    public Vector3[] TargetPosition;
    public int Number;

    void Start()
    {


        for (int i = 0; i < Number; i++) {
            Rigs[i].transform.position = TargetPosition[i];
            Rigs[i].transform.rotation = Quaternion.Euler((Quaternion.LookRotation(TargetDirection[i])).eulerAngles);//将向量转化为朝向欧拉角
            //Rigs[i].transform.LookAt(TargetDirection[i]);
        }
        /*Quaternion GestureStatus = Rigs[0].transform.rotation;
        print(GestureStatus);
        Quaternion Rotation = Quaternion.FromToRotation(Vector3.up, TargetDirection);
        Rigs[0].transform.Rotate(Rotation.eulerAngles, Space.World);
        Rigs[0].transform.LookAt(TargetDirection[0]);
        Rigs[0].transform.position = TargetPosition[0];
        GestureStatus = Rigs[0].transform.rotation;
        print(GestureStatus);*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
