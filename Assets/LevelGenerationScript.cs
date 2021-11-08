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
   void Update(){
       if(spawnCount == 10){
           generateLvl = false;
       }
        do{
            StartCoroutine(GenerateLevel());
       } while (generateLvl);
   }

   IEnumerator GenerateLevel(){
       yield return new WaitForSeconds(3f);
       float randomXPosition = Mathf.Floor(Random.Range(-2.5f,2.5f));
       Vector3 spawnPosition = new Vector3(randomXPosition,spawnOrigin.position.y,spawnOrigin.position.z);
       Instantiate(platform, spawnPosition, Quaternion.identity);
       spawnCount++;
       yield return new WaitForSeconds(3f);
   
   }
}
