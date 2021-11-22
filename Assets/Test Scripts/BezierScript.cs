using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierScript : MonoBehaviour
{
    public Vector3 a,b,c,d;
    [Range(0f,1f)]
    public float t;
    public LineRenderer lineRenderer;
    void Start()
    {
        lineRenderer.positionCount = 4;
    }
    void Update()
    {
      for(int i = 0; i < lineRenderer.positionCount - 1; i++)
      {
          Vector3 e = CubicBezierCurve(a,b,c,d,t);
          lineRenderer.SetPosition(3, e);

      }
    }
   

    Vector3 Lerp(Vector3 a, Vector3 b, float t)
    {
        return a + ((b-a) * t);
    }

    public Vector3 QuadraticBezierCurve(Vector3 a, Vector3 b, Vector3 c, float t)
    {
        Vector3 p0 = Lerp(a,b,t); 
        Vector3 p1 = Lerp(a,c,t);
        
        return Lerp(p0,p1,t);
    }

    Vector3 CubicBezierCurve(Vector3 a, Vector3 b, Vector3 c,Vector3 d, float t)
    {
        Vector3 p0 = QuadraticBezierCurve(a,b,c,t);
        Vector3 p1 = QuadraticBezierCurve(b,c,d,t);

        return Lerp(p0,p1,t);
    }
}
