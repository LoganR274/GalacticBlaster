using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childSpawner : MonoBehaviour
{
    [SerializeField] GameObject PressurePlate;
    [SerializeField] Result1Handler toResultScreen;
    [SerializeField] int spawnCount = 0;
    [SerializeField] int pressurePlateSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        childSpawn();
    }

     public void childSpawn(){

        StartCoroutine (spawnChildRoutine());
        IEnumerator spawnChildRoutine(){
            
            for(int i = 0; i <= spawnCount; i++){
                if(i == 0){
                    yield return new WaitForSeconds(5f);
                }
                else
                yield return new WaitForSeconds(10f);
                transitionLeft();
                if (i == spawnCount){
                    Debug.Log("End of for loop");
                    yield return new WaitForSeconds(30);
                    toResultScreen.toResultScreen();
                    break;
                }
                else
                Debug.Log(i);
            }     
        }
   }

   public void transitionLeft(){

        GameObject newPressurePlate = Instantiate(PressurePlate, new Vector3(11, 0, 0), Quaternion.identity);
        newPressurePlate.GetComponent<Rigidbody2D>().velocity = -(newPressurePlate.transform.right) * pressurePlateSpeed;
        Destroy(newPressurePlate, 10);
   }
    
}
