using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleFirerate : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<blaster>() != null){
            other.GetComponent<blaster>().DoubleFireratePickup();
            Destroy(this.gameObject);
        }
    }
}
