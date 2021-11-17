using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) {
            Jump();
        }
    }

    void Jump()
    {
        transform.Translate(Vector3.forward);
    }
}
