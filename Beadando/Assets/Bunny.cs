using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bunny : MonoBehaviour
{
    public float speed = 5f;

    public float timer = 3;

    public float bound_X = -20f;


    
    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "Bunny(Clone)")
        {
         if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {

                Destroy(gameObject);

            }

        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (collision.gameObject.name == "Player")
            {
                ScoreScript.scoreValue += 1;
                Destroy(gameObject);
            }
        }
    }
}