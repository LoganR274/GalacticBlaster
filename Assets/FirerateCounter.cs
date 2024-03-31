using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FirerateCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI FirerateBoolText;
    public static FirerateCounter singleton;
    bool FirerateBool = false;
    void Start(){
        if(singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }

    public void IsFirerateOn(){
        FirerateBool = true;
        FirerateBoolText.text = FirerateBool.ToString();
    }
}
