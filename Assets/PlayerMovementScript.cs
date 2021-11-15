using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeReference]float moveSpeed = 10f;
    [SerializeReference]float jumpDistance = 10f;

    new Rigidbody rigidbody;
    void Awake(){
        rigidbody = GetComponentInChildren<Rigidbody>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)) {
            MoveHorizontal(1);
        }if(Input.GetKeyDown(KeyCode.A)) {
            MoveHorizontal(-1);
        }

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    
    void MoveHorizontal(int direction){
        float xPos;
        
        xPos = direction * jumpDistance;
        if(transform.position.x == 0) {
            transform.position = new Vector3(xPos, 1, transform.position.z);
        } else {
            xPos = 0;
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }
    }
}
