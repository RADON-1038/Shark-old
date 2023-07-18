using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector2euler : MonoBehaviour
{

    public Vector3 LookRotation(Vector3 fromDir)
    {
        Vector3 eulerAngles = new Vector3();
        if (fromDir.x == 0 && fromDir.y == 0 && fromDir.z == 0) 
        {
            return  new Vector3(0, 0, 0);
        }

        //AngleX = arc cos(sqrt((x^2 + z^2)/(x^2+y^2+z^2)))
        eulerAngles.x = Mathf.Acos(Mathf.Sqrt((fromDir.x * fromDir.x + fromDir.z * fromDir.z) / (fromDir.x * fromDir.x + fromDir.y * fromDir.y + fromDir.z * fromDir.z))) * Mathf.Rad2Deg;
        if (fromDir.y > 0) eulerAngles.x = 360 - eulerAngles.x;

        //AngleY = arc tan(x/z)
        if (fromDir.z == 0)
        {
            eulerAngles.y = 270;
        }
        else {
            eulerAngles.y = Mathf.Atan2(fromDir.x, fromDir.z) * Mathf.Rad2Deg;
            if (eulerAngles.y < 0) eulerAngles.y += 180;
            if (fromDir.x < 0) eulerAngles.y += 180;
            //AngleZ = 0
            eulerAngles.z = 0;
        }
       
        return eulerAngles;
    }

}
