using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerationScript : MonoBehaviour
{

   [SerializeField] Transform spawnOrigin;
   [SerializeField] GameObject platform;
    bool generateLvl;
    int spawnCount = 0;
    void OnEnable(){
        generateLvl = true;
    }
    void Start(){
        StartCoroutine(GenerateLevel());
    }

   IEnumerator GenerateLevel(){
       yield return new WaitForSeconds(2.5f);
      while(generateLvl){
       float randomXPosition = Mathf.Floor(Random.Range(-1,2f)); 
       Vector3 spawnPosition = new Vector3(randomXPosition,spawnOrigin.position.y,spawnOrigin.position.z);
       Instantiate(platform, spawnPosition, Quaternion.identity);
       spawnCount++;
       yield return new WaitForSeconds(2.5f);
   }  
   
   }
}
