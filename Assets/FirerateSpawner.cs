using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirerateSpawner : MonoBehaviour
{
    [SerializeField]  GameObject FireratePrefab;
    [SerializeField] float ItemSpeed = 0;
    [SerializeField] float ItemLifeSpan = 0;

    public static FirerateSpawner singleton;

    void Start()
    {
        //FirerateSpawn();
    }

    void Awake(){
        if(singleton = null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }

   public void spawnFirerateRandom(){
        GameObject newFirerate = Instantiate(FireratePrefab, transform.position, Quaternion.identity);
        newFirerate.GetComponent<Rigidbody2D>().velocity = -(newFirerate.transform.right) * ItemSpeed;
   }
}
