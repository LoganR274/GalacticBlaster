using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other){
        if (other.gameObject.name == "Blaster"){
            Debug.Log("Enemy struck Blaster!");
            HealthCounter.singleton.LoseHealth();
            Destroy(this.gameObject);
        }
    }
}
