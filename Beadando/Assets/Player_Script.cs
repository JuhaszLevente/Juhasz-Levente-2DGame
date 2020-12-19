using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{



    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
         rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.position += Vector2.up * 2;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.position += Vector2.down * 2;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.position += Vector2.right * 2;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.position += Vector2.left * 2;
        }
    }
}
