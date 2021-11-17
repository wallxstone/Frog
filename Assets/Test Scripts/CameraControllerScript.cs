using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    [Range(0,100)]
   [SerializeField] float panSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * panSpeed * Time.deltaTime);
    }
}
