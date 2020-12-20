using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bunny : MonoBehaviour
{
    public float speed = 5f;



    public float bound_X = -20f;

   

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (collision.gameObject.name == "Player")
            {
                Destroy(gameObject);
            }
        }
    }
}