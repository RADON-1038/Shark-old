using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �˽ű����ڲ�������״̬�µ��������곯������Ƿ�����
public class PointTest : MonoBehaviour
{
    public GameObject[] Points;//��Ҫ���Ƶĵ�
    public Vector3[] Positions;//�趨���Ƶĵ��λ��
    public Vector3[] Rotation_Euler;//��ŷ������ʽ���õ�ķ���
    public Vector3[] Control_Vector;//��������ʽ���õ�ķ���
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


            //ŷ���ǿ��Ʒ��������������Ʒ���ֻ����һ��
            //Points[i].transform.rotation = Quaternion.Euler(Rotation_Euler[i]);
            //print("the rotation of point " + i + " is " + Points[i].transform.rotation.eulerAngles);
        }

        

        //�������Ʒ�������ŷ���ǿ��Ʒ���ֻ����һ��
        Points[0].transform.LookAt(Control_Vector[0] * 1000);

        Points[0].transform.Rotate(0, 90, -90);
        print("the rotation of point 0 is " + Points[0].transform.rotation.eulerAngles);
        //Points[1].transform.LookAt(Control_Vector[1] * 1000);
       // print("the rotation of point 1 is " + Points[1].transform.rotation.eulerAngles);
    }
}
