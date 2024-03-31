using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirerateSpawner : MonoBehaviour
{
    [SerializeField]  GameObject enemyPrefab;
    [SerializeField]  float spawnRange = 4;

    void Start()
    {
        FirerateSpawn();
    }

   public void FirerateSpawn(){
        StartCoroutine (spawnFirerateRoutine());
        IEnumerator spawnFirerateRoutine(){
            while (true){
                yield return new WaitForSeconds(1);
                spawnFirerateRandom();
            }
        }
   }

   public void spawnFirerateRandom(){
        float randomX = Random.Range(-spawnRange, spawnRange);
        float randomY = Random.Range(-spawnRange, spawnRange);

        GameObject newEnemy = Instantiate(enemyPrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);
        Destroy(newEnemy, 3);
        newEnemy.transform.eulerAngles = new Vector3(0,0,0);
   }
}
