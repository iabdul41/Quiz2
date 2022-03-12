using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public int speed;
    public int minSp = 4;
    public int maxSp = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Enemy1"))
        {
            speed = Random.Range(minSp, maxSp);
            //transform.Translate((player.transform.position - transform.position).normalized * speed * Time.deltaTime);

        }

        if (gameObject.CompareTag("Enemy2"))
        {
            speed = Random.Range(minSp, maxSp);
            //transform.Translate((player.transform.position - transform.position).normalized * speed * Time.deltaTime);

        }

        if (gameObject.CompareTag("Enemy3"))
        {
            speed = Random.Range(minSp, maxSp);
            //transform.Translate((player.transform.position - transform.position).normalized * speed * Time.deltaTime);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
        //AI Movement
        transform.Translate((player.transform.position - transform.position).normalized * speed * Time.deltaTime);

    }
}
