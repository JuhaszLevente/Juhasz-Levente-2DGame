using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float min_x = 13f, max_x = 63f;
    public GameObject Bunny;

    public float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemies", timer);
    }

    void SpawnEnemies()
    {
        float pos_Y = Random.Range(min_x, max_x);
        Vector3 temp = transform.position;
        temp.x = pos_Y;


        Instantiate(Bunny, temp, Quaternion.Euler(0f, 0f, 0));
        Invoke("SpawnEnemies", timer);

    }
}