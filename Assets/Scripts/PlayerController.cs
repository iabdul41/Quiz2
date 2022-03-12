using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput = 5.0f;
    public float verticalInput = 5.0f;
    public float speed = 50.0f;

    private Rigidbody rb;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //For player physics
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        rb.AddForce(Vector2.right * Time.deltaTime * speed * horizontalInput,ForceMode.Impulse);
        rb.AddForce(Vector2.up * Time.deltaTime * speed * verticalInput, ForceMode.Impulse);

        //Player Rotation
        transform.Rotate(Vector3.forward, horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fire from the player
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y +3, 0), projectilePrefab.transform.rotation);
        }
    }
}
