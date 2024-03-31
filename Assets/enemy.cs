using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{   

    void Start(){
        disableSpawn();
    }

    public void disableSpawn(){
         GetComponent<enemySpawner>().enabled = false;
    }
    // Start is called before the first frame update
    public void callSpawn(){
        GetComponent<enemySpawner>().enabled = true;
    }
}
