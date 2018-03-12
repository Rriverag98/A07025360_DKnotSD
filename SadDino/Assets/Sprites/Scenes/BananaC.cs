using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaC : MonoBehaviour {
    
    public int scoreValue;            //	Points obtained 
    private ScoreKeeper scoreKeeper;        //	A link to the ScoreKeeper script

    // Use this for initialization
    void Start()
    {
        scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
    }

    //	Called everytime our object collides with a trigger collider
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            scoreKeeper.Score(scoreValue);
            Destroy(gameObject);
        }
    }
}

