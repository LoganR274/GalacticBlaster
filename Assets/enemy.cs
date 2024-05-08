using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{   

    //[SerializeField] GameObject bulletSpawner;

//    [SerializeField]  GameObject enemyPrefab;
    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "Blaster"){
            HealthCounter.singleton.LoseHealth();
            Destroy(this.gameObject);
        }
        else if (other.gameObject.name == "Deadzone"){
            Debug.Log("Enemy reached Deadzone!");
            Destroy(this.gameObject);
        }
        // else if(other){

        // }
    }


    void Start(){
        //disableSpawn();
    }

    // public void disableSpawn(){
    //      GetComponent<enemySpawner>().enabled = false;
    // }
    // // Start is called before the first frame update
    // public void callSpawn(){
    //     GetComponent<enemySpawner>().enabled = true;
    // }
}
