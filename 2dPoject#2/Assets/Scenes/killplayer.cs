using UnityEngine;
using system.collections;

public class KillPlayer : monobehaviour {


    public LevelManager LevelManager;

    // use this for initialization
    void start () {
        LevelManager= findobjectoftype <LevelManager>();
}

void ontriggerenter2d(collider2d other){
    if(other.name == "PC"){
        LevelManager.respawnplayer();
        }
    }
}