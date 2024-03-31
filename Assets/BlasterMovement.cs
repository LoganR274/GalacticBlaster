using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterMovement : MonoBehaviour
{

    [Header("character")]
    [SerializeField] blaster blasterInput;


    [SerializeField] public GameObject ProjectilePrefab;
    [SerializeField] float speed = 25f;
    [SerializeField] float speedIncrease = 5f;
    [SerializeField] float projectileTime = 0.5f;


    public bool isFirerate = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = Vector3.zero;

        if(Input.GetKey(KeyCode.W)){
            input.y += 1;
        }

         if(Input.GetKey(KeyCode.S)){
            input.y += -1;
        }

        if(Input.GetKey(KeyCode.A)){
            input.x += -1;
        }

         if(Input.GetKey(KeyCode.D)){
            input.x += 1;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            shootProjectile();
            if(isFirerate == true){
            //shootProjectile1();
            Debug.Log("isActive is true!");
            }
        }

        blasterInput.Move(input);
    }

    public void shootProjectile(){
        GameObject newProjectile = Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = newProjectile.transform.right * speed;
        Destroy(newProjectile, projectileTime);
    }
    public void shootProjectile1(){
        GameObject newProjectile = Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = newProjectile.transform.up * speed;
        Destroy(newProjectile, projectileTime);
    }



}
