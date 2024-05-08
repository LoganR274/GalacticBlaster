using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "powerups")]

public class SpeedPickup : powerUp
{
    
    public SpeedUpSpawner stopSpawn;
    public float increase;

    public override void Apply(GameObject target){
        bool check = true;

       //yolo = target.GetComponent<blaster>().speed;
        if(check = true){
            if(target.GetComponent<blaster>().speed < 25){
                    //speed += speedIncrease;
                    target.GetComponent<blaster>().speed += increase;
                    SpeedCounter.singleton.speedCounterScore();
                    Debug.Log("Speed increase!");
                }
        }
        else {
            Debug.Log("Speed power is disabled");
            check = false;
            target.GetComponent<blaster>().speed = 25;
            SpeedCounter.singleton.speedMax();
            //stopSpawn.isActivated = true;
            //target.GetComponent<SpeedUpSpawner>().isActivated = false;
            //target.deactivate();
            
            return;
        }


    }
}