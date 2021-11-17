using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingScript : MonoBehaviour
{
   public float playerReach;
   public Camera main;

  

   void Update(){

       if(Input.GetMouseButton(0)) {
           RaycastHit hit;
           if(Physics.Raycast(main.ScreenPointToRay(Input.mousePosition),out hit,playerReach))
           {
               transform.position = hit.collider.gameObject.transform.position;
           } else {
               return;
           }
       }
   }

   
}
