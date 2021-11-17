using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawnerScript : MonoBehaviour
{
    public List<GameObject> prefabs;
    public int spawnedPrefabs;
    GameObject newSpawnPos;
    [SerializeField] Transform player;
    void Awake() => GenerateLevel();
   void OnTriggerEnter(Collider other) {
       GenerateLevel();
   }
    void GenerateLevel() {
             for(int i = 0; i < spawnedPrefabs; i++)
                {
                int random = Random.Range(0,4);
                Vector3 spawnPosition = new Vector3(transform.position.x,transform.position.y,transform.position.z + i);
                newSpawnPos = Instantiate(prefabs[random],spawnPosition,Quaternion.identity);
            }
            transform.position = new Vector3(newSpawnPos.transform.position.x,newSpawnPos.transform.position.y,newSpawnPos.transform.position.z);
    }
}
