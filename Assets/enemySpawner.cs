using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    [SerializeField]  GameObject enemyPrefab;

    [SerializeField] GameObject projectilePrefab;
    [SerializeField]  float spawnRangeX = 4f;
     [SerializeField]  float spawnRangeY = 4f;
    [SerializeField] int spawnCount = 0;

    [SerializeField] int enemySpeed = 0;

    [SerializeField] int projectileSpeed = 0;

    [SerializeField] float projectileTime = 0;

    bool check = false;

    //public bool enable = false;

    void Start(){

    }



    void Update(){

    }

    // if (enable == true){
    //     enemySpawn();
    // }
   public void enemySpawn(){

        StartCoroutine (spawnEnemyRoutine());
        IEnumerator spawnEnemyRoutine(){

            for(int i = 0; i <= spawnCount; i++){
                yield return new WaitForSeconds(Random.Range(1f, 1.5f));
                spawnEnemyRandom();
                if (i == spawnCount){
                   // Debug.Log("End of for loop");
                   if (check == true){
                        Debug.Log("end of level!");
                   }
                    break;
                }
                // else
                // Debug.Log(i);
            }     
        }
   }

   public void projectileSpawn(GameObject newEnemy){

        StartCoroutine (spawnBulletRoutine());
        IEnumerator spawnBulletRoutine(){

            while (true){
                yield return new WaitForSeconds(Random.Range(0.9f, 2f));
                shootProjectile(newEnemy);
                //Debug.Log("enemy bullet shot!");
            }     
        } 
   }

   public void spawnEnemyRandom(){
        //float randomX = Random.Range(5, 10);
        float randomY = Random.Range(-spawnRangeY, spawnRangeY);

        GameObject newEnemy = Instantiate(enemyPrefab, new Vector3(11, randomY, 0), Quaternion.identity);
        newEnemy.GetComponent<Rigidbody2D>().velocity = -(newEnemy.transform.right) * enemySpeed;
        projectileSpawn(newEnemy);
   }
   
    public void shootProjectile(GameObject newEnemy){
        if (newEnemy != null){
            GameObject newProjectile = Instantiate(projectilePrefab, newEnemy.transform.position, Quaternion.identity);
            newProjectile.GetComponent<Rigidbody2D>().velocity = -(newProjectile.transform.right) * projectileSpeed * enemySpeed;
            Destroy(newProjectile, projectileTime);
        }
        else{
            //Debug.Log("enemy is null");
            return;
        }
    }
}