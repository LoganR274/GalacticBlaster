using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{   

    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "Blaster"){
            HealthCounter.singleton.LoseHealth();
            Destroy(this.gameObject);
        }
    }


    // void Start(){
    //     disableSpawn();
    // }

    // public void disableSpawn(){
    //      GetComponent<enemySpawner>().enabled = false;
    // }
    // // Start is called before the first frame update
    // public void callSpawn(){
    //     GetComponent<enemySpawner>().enabled = true;
    // }
}
