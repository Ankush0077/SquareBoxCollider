using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Next Level");
        SceneManager.LoadScene("Level1");
    }

}
