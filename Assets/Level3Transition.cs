using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Transition : MonoBehaviour
{
    public void toLevel3Screen(){
        SceneManager.LoadScene("Level3");
    }
}
