using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateConvert : MonoBehaviour
{
    public float screenWidth = 1280f;
    public float screenHeight = 720f;
    public float TranScale = 0.01f;

    public Vector3 Convert(Vector3 InputPosition) {
       /* float temp = InputPosition.z;
        InputPosition.z = InputPosition.x;
        InputPosition.x = temp;
        InputPosition.y = -InputPosition.y;
*/
        return InputPosition /** TranScale*/;

    }
}
