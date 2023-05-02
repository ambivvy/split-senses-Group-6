using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    public GameObject Player;
    public bool PlayerAlive;


    void Start(){
    PlayerAlive = Player.GetComponent<PlayerAttributes>().PlayerAlive;
}
    

     //Start is called before the first frame update


     //Update is called once per frame


private void OnCollisionEnter3D(Collision Player){
    PlayerAlive = false;
}

}