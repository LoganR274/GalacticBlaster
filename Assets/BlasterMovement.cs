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
    [SerializeField] float projectileTime = 0.1f;

    public static BlasterMovement singleton;

    public bool isFirerate = false;
    // Start is called before the first frame update

    void Awake(){
        if(singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }

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
            
            if(isFirerate == true){
            DoubleFirerate();
            //Debug.Log("isActive is true!");
            }
            else{
            shootProjectile();
            }
        }

        blasterInput.Move(input);
    }

    public void shootProjectile(){
        GetComponent<AudioSource>().Play();
        GameObject newProjectile = Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = newProjectile.transform.right * speed;
        Destroy(newProjectile, projectileTime);
    }
    public void DoubleFirerate(){
        GetComponent<AudioSource>().Play();
        GameObject newProjectile1 = Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
        GameObject newProjectile2 = Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
        newProjectile1.GetComponent<Rigidbody2D>().velocity = newProjectile1.transform.right * speed;
        newProjectile2.GetComponent<Rigidbody2D>().velocity = newProjectile2.transform.right * speed;
        newProjectile1.transform.position = newProjectile1.transform.position + new Vector3(0,0.6f,0);
        newProjectile2.transform.position = newProjectile2.transform.position + new Vector3(0,-0.6f,0);
        Destroy(newProjectile1, projectileTime);
        Destroy(newProjectile2, projectileTime);
    }

    public void ActivateDoubleFirerate(){
        isFirerate = true;
    }

}
