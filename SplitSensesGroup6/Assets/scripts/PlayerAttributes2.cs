using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerAttributes2 : MonoBehaviour
{
    public bool PlayerAlive;

    public void Update()
    {
        if (PlayerAlive == true)
        {
            
            SceneManager.LoadScene(3);
           
        }
    }
}          

