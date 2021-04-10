using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomMath;
public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vec3 a = new Vec3(2, 4, 6);
        Vec3 b = new Vec3(7, 6, 5);
        //Debug.Log("Vec3: " + Vec3.Dot(a, b));
        Debug.Log("Vec3: " + Vec3.Angle(a, b));
        //Debug.Log("Vec3: " + Vec3.Magnitude(a));

        Vector3 c = (Vector3)a;
        Vector3 d = (Vector3)b;
        //Debug.Log("Vector3: " + Vector3.Dot(c, d));
        Debug.Log("Vector3: " + Vector3.Angle(c, d));
        Debug.Log("Vector3: " + Vector3.AngleBetween(c, d));

        //Debug.Log("Vector3: " + Vector3.Magnitude(c));
    }


}
