using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    private GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {

        gameOver = GameObject.Find("Walpaper");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //Destroy enemy and fire

        if (other.gameObject.CompareTag("Enemy1" )|| other.gameObject.CompareTag("Enemy2") || other.gameObject.CompareTag("Enemy3"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

        }


        if (other.gameObject.tag == "Game Over")
        {
            Debug.Log("Game Over");

            Time.timeScale = 0;

            //gameOver.SetActive(true);
      
        }


    }
}
