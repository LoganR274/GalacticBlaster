using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpSpawner : MonoBehaviour
{
    [SerializeField]  GameObject SpeedUpPrefab;
    [SerializeField] float ItemSpeed = 0;
    [SerializeField] float ItemLifeSpan = 0;

    //public bool isActivated = true;

    public static SpeedUpSpawner singleton;

    void Awake(){
        if(singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }

   public void spawnSpeedRandom(){
        GameObject newSpeedUp =  Instantiate(SpeedUpPrefab, transform.position, Quaternion.identity);
        newSpeedUp.GetComponent<Rigidbody2D>().velocity = -(newSpeedUp.transform.right) * ItemSpeed;
   }
}
