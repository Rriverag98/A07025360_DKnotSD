using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC : MonoBehaviour {
    public float speed = 3f;


    void Start()
    {
       
    }


    void Update()
    {
        transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Block")
        {
            var s = transform.localScale;
            s.x *= -1;
            transform.localScale = s;
            speed *= -1;
        }
        else if (collider.gameObject.tag == "Player")
        {
            LevelManager levelMngr = new LevelManager();
            levelMngr.LoadLevel("GameOver");
        }
    }
}
