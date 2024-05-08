using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyKilled : MonoBehaviour
{

    [System.Serializable]

    public class myEvent : UnityEvent<int>{}

    public myEvent myKillEvent;

    // void Start()
    // {
    //     onEnemyKilled.AddListener(printPickup);
    //     onEnemyKilled.RemoveListener(printPickup);
    // }

    // void printPickup(){
    //     Debug.Log("Enemy spawned!");
    // }

    public UnityEvent onEnemyKilled;

    void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<bullet>() != null){
            myKillEvent.Invoke(500);
            Destroy(other.gameObject);
        }
    }
}
