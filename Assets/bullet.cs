using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other){
        if (other.gameObject.tag == "Destructable"){
                Debug.Log("Enemy Killed!");
                EnemyScoreCounter.singleton.ScoreCounter();
                Destroy(other.gameObject);
        }
    }
}
