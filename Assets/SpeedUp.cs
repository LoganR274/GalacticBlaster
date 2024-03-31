using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public powerUp powerUp;

    public void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<blaster>() != null){
            powerUp.Apply(other.gameObject);
            
            Destroy(this.gameObject);
        }
    }
}
