using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blaster : MonoBehaviour
{

    [Header("stats")]

    [SerializeField] int health = 0;
    public float speed = 0f;
    //[SerializeField] float speedIncrease = 2.5f;
    [SerializeField] float projectileTime = 0.5f;
   
   //[SerializeField] float 

    [Header("current position")]
    [SerializeField] Vector3 position = Vector3.zero;

    Rigidbody2D rb;
    float speedIncrease = 5f;
    bool isActive = false;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //GameObject bullet = gameObject.AddComponent<BlasterMovement>().ProjectilePrefab;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void Move(Vector3 direction){
        rb.transform.position += direction * speed * Time.deltaTime;
        //rigidbodyMovement(direction);
    }

    /*public void rigidbodyMovement(Vector3 direction){
        Vector3 currentVelocity = new Vector3(0,rb.velocity.y,0);
        rb.velocity = (currentVelocity) + (speed * direction);
    }*/

    public void SpeedPickup(){
        //  if(speed <= 30){
        //     speed += speedIncrease;
        //     SpeedCounter.singleton.speedCounterScore();
        //     Debug.Log("Speed increase!");
        //  }
        // else {
        //     Debug.Log("Speed spawner is disabled");
        //     speed += 0;
        //     return;
        // }
    }

    public void DoubleFireratePickup(){
        Debug.Log("Double Firerate picked!");
        FirerateCounter.singleton.IsFirerateOn();
        BlasterMovement.singleton.ActivateDoubleFirerate();
        //isActive = true;

        // GameObject newProjectile = Instantiate(bullet, transform.position, Quaternion.identity);
        // newProjectile.GetComponent<Rigidbody2D>().velocity = newProjectile.transform.up * speed;
    }
}
