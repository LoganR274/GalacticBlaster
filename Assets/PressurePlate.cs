using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    //  [SerializeField] private GameObject enemyPrefab;

    // public static PressurePlate singleton;

    // void Start(){
    //     if(singleton != null){
    //         Destroy(this.gameObject);
    //     }

    //     singleton =  this;
    // }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "Blaster"){
        Debug.Log("Pressure plate triggered!");
        //other.GetComponent<enemy>().callSpawn();
        Destroy(this.gameObject);
        }
    }
}
