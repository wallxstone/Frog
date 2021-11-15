using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementScript : MonoBehaviour
{
   [SerializeField] float moveSpeed = 2f;
    GameObject Player;

    void OnEnable(){
        Player = GameObject.FindWithTag("Player");
    }
   private void FixedUpdate() {
       transform.Translate(Vector3.forward * -1f *moveSpeed * Time.fixedDeltaTime);
       if(transform.position.z < Player.transform.position.z - 2f){
           Destroy(gameObject);
       }
   }

}
