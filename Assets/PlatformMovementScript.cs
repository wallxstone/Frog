using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementScript : MonoBehaviour
{
   [SerializeField] float moveSpeed = 2f;


   private void Update() {
       transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
   }

}
