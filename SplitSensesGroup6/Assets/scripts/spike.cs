using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spike : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
{
  if (other.gameObject.name == "Player") 
  { SceneManager.LoadScene(3); }    
}
}