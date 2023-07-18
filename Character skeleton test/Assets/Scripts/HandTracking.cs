using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] LandMarks;//�ֲ��ڵ�
    public GameObject[] KeyPoints;//ģ�ͽڵ�

//    private CoordinateConvert convert;
    void Start()
    {
        //convert ����ת��MediaPipe��Unity֮�������(��δʵ��)
//        convert = GetComponent<CoordinateConvert>();
    }
    void Update()
    {

        //���Ȼ�ȡģ��ԭ���Ĺ�����(��ӳ���)λ�ã���������֮��ľ���
        Vector3 PositionModel0 = KeyPoints[0].transform.position;
        Vector3 PositionModel1 = KeyPoints[1].transform.position;
        Vector3 PositionModel2 = KeyPoints[2].transform.position;
        //Debug.Log("position of point 0 on model is "+ positionModel0 +" and position of point 1 on model is "+positionModel1 );
        float Distance0_1_Model = Vector3.Distance(PositionModel0, PositionModel1);
        float Distance1_2_Model = Vector3.Distance(PositionModel1, PositionModel2);
        //Debug.Log("distance between joint0 and joint1 is "+distance0_1_model);


        //��ȡ����UDP�����ݲ��������������
        string data = udpReceive.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1);
        string[] points = data.Split(',');

        //��ȡȫ��������
        for (int i = 0; i < 21; i++)
        {

            float x = /*7 - */float.Parse(points[i * 3]) / 100;
            float y = float.Parse(points[i * 3 + 1]) / 100;
            float z = float.Parse(points[i * 3 + 2]) / 100;

            LandMarks[i].transform.localPosition = new Vector3(x, y, z);

        }
        Vector3 Direction9_0 = LandMarks[0].transform.position - LandMarks[9].transform.position;
        Vector3 Direction12_9 = LandMarks[9].transform.position - LandMarks[12].transform.position;

        KeyPoints[0].transform.position = LandMarks[0].transform.position;
        KeyPoints[0].transform.LookAt(Direction9_0 * 100);
        KeyPoints[0].transform.Rotate(0, 90, -90);
        KeyPoints[1].transform.position = LandMarks[9].transform.position;
        KeyPoints[1].transform.LookAt(Direction12_9 * 100);
        KeyPoints[1].transform.Rotate(0, 90, -90);
        KeyPoints[2].transform.position = LandMarks[12].transform.position;
        KeyPoints[2].transform.LookAt(Direction12_9 * 100);
        KeyPoints[2].transform.Rotate(0, 90, -90);
    }


}
