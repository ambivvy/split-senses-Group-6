using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
// once the finish collides with the player they will be loaded into the win screen
private void OnTriggerEnter(Collider other)
{
  if (other.gameObject.name == "Player") 
  { SceneManager.LoadScene(4); }    
}
}
 