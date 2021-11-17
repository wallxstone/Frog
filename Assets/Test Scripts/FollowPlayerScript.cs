using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    [SerializeField]  Transform player;
    Vector3 offset;
    void Awake(){
        offset = new Vector3(0, 4.5f, -8);
    }
     void Update(){
         Mathf.Clamp(transform.position.x, 0,0);
         transform.position =player.position + offset;
  }
}
