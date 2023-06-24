using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnObj;
    [SerializeField] float interval;

    float timer = 0f;

    void Start() {
        Instantiate(spawnObj, new Vector3(5,0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPillars();
    }

    void SpawnPillars(){
        Vector3 randSpawnPos = new Vector3(5, Random.Range(-3,3), 0);

        timer += Time.deltaTime;
        if(timer >= interval){
            GameObject obj = Instantiate(spawnObj, randSpawnPos, Quaternion.identity);
            timer = 0;
        }
    }
}
