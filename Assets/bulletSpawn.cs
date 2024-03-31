using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawn : MonoBehaviour
{
    [SerializeField] GameObject ProjectilePrefab;
    [SerializeField] float speed = 25f;
    [SerializeField] float projectileTime = 0.5f;

public void Launch(){
    GameObject newProjectile = Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
    //newProjectile.transform.rotation = Quaternion.LookRotation(transform.forward, TargetPos - transform.position);
    newProjectile.GetComponent<Rigidbody2D>().velocity = newProjectile.transform.up * speed;
    Destroy(newProjectile, projectileTime);
}

}
