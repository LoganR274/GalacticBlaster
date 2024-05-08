using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result1Handler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string toResultScreenName;
    public void toResultScreen(){
        SceneManager.LoadScene(toResultScreenName);
    }
}
