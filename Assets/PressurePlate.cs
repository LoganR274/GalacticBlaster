using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public enemySpawner spawnEnemy;

    // public static PressurePlate singleton;

    // void Start(){
    //     if(singleton != null){
    //         Destroy(this.gameObject);
    //     }

    //     singleton =  this;
    // }

    //GameObject spawn = enemySpawner;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "Blaster"){
        Debug.Log("Pressure plate triggered!");
        Destroy(this.gameObject);
        spawnEnemy.enemySpawn();
        //spawnEnemy.projectileSpawn();
        }
    }
}
