using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI speedCounterText;
    public static SpeedCounter singleton;
    int speedIndicator = 0;
    void Start(){
        if(singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }

    public void speedCounterScore(){
        speedIndicator += 1;
        speedCounterText.text = speedIndicator.ToString();
    }
}
