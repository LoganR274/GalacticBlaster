using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyScoreCounter : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI EnemyScoreCounterText;
    public static EnemyScoreCounter singleton;

    int ScoreTotal = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (singleton != null){
            Destroy(this.gameObject);
        }
        singleton = this;
    }

    public void ScoreCounter(){
        
        ScoreTotal += 100;
        EnemyScoreCounterText.text = ScoreTotal.ToString();
    }
    
}
