using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawnerScript : MonoBehaviour
{
    public List<GameObject> prefabs;
    public int spawnedPrefabs;
    GameObject newSpawnPos;

    [SerializeField] Transform player;
    [SerializeField] bool generateNewTerrain;
    
    void Awake(){
        generateNewTerrain = true;
    }
    void Start()
    {
        GenerateLevel();
        
    }

    
    void GenerateLevel() {
        for(int i = 0; i < spawnedPrefabs; i++)
        {
            int random = Random.Range(0,4);
            Vector3 spawnPosition = new Vector3(transform.position.x,transform.position.y,i);
            newSpawnPos = Instantiate(prefabs[random],spawnPosition,Quaternion.identity);
        }
        Debug.Log("Old Transform = " + transform.position +" New Transform = " + newSpawnPos.transform.position + generateNewTerrain);
        transform.position = newSpawnPos.transform.position;
        generateNewTerrain = false;
        Debug.Log(generateNewTerrain);
    }
}
