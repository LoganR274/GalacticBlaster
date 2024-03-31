using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "powerups")]

public class SpeedPickup : powerUp
{
    public float increase;

    public override void Apply(GameObject target){


       //yolo = target.GetComponent<blaster>().speed;

       if(target.GetComponent<blaster>().speed <= 30){
            //speed += speedIncrease;
            target.GetComponent<blaster>().speed += increase;
            SpeedCounter.singleton.speedCounterScore();
            Debug.Log("Speed increase!");
         }
        else {
            Debug.Log("Speed spawner is disabled");
            target.GetComponent<blaster>().speed += 0;
            return;
        }


    }
}