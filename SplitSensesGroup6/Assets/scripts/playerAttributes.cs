using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    public bool PlayerAlive;

    public float PlayerHealth;
    // Start is called before the first frame update
    void Start()
    {
        PlayerAlive = true;
        PlayerHealth = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerAlive == true)
        {
            // insert code for death screen and relocation back to spawn
        }
    }
}          
