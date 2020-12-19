using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    public float speed = 5f;

    private bool can_move = true;

    public float bound_X = -20f;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
       // Move();

    }
   /* void Move()
    {
        if (can_move)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            transform.position = temp;

            if (temp.y < bound_X)
                gameObject.SetActive(false);
        }
        
    }*/
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(col.gameObject);
        }
    }
}