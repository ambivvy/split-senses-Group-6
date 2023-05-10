using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
// once the finish collides with the player they will be loaded into the next scene/ level
private void OnTriggerEnter(Collider other)
{
  if (other.gameObject.name == "Player") 
  { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }    
}

}
