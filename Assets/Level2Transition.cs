using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Transition : MonoBehaviour
{
    public void toLevel2Screen(){
        SceneManager.LoadScene("Level2");
    }
}
