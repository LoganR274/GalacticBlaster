using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropProbability : MonoBehaviour
{

    
    public static DropProbability singleton;
    
    void Awake(){
        
        if(singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }
    public void probability(){

        int prob = Random.Range(1, 1000);

        if(prob <= 500){
            //Debug.Log("Nothing spawns");
            return;
        }
        else if (prob <= 600){
            if (SpeedUpSpawner.singleton != null) {
            SpeedUpSpawner.singleton.spawnSpeedRandom();
            //Debug.Log("Speed Spawns");
        } else {
            Debug.LogError("SpeedUpSpawner singleton is null!");
        }
        return;
        }
        else if (prob <= 800){
            if (FirerateSpawner.singleton != null) {
            FirerateSpawner.singleton.spawnFirerateRandom();
            //Debug.Log("DoubleFirerate Spawns");
        } else {
            Debug.LogError("FirerateSpawner singleton is null!");
        }
        return;
        }

        else if (prob <= 1000){
            Debug.Log("Health Respawns");
            return;
        }
        //else
        //return 1;
    }
}
