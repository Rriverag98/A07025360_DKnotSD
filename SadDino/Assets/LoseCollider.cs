using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour { 
    public string level;



    // Method is triggered when object touches the Losecollider GO
    //Then loads the "Lose" screen
    void OnTriggerEnter2D(Collider2D collider)
    {
        LevelManager levelMngr = new LevelManager();
        levelMngr.LoadLevel(level);
    }
}