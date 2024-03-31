using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthCounter : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI HealthCounterText;
    [SerializeField] backToMenu gameOverTransition;

    public static HealthCounter singleton;
    int healthRemaining = 3;

    void Awake(){
        if(singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }

    public void LoseHealth(){
        healthRemaining -= 1;
        HealthCounterText.text = healthRemaining.ToString();
        if (healthRemaining == 0){
            gameOverTransition.gameOver();
            Debug.Log("player lost");
        }
    }
}
