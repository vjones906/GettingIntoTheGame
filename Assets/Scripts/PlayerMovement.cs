using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    const float hozBoundary = 10.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Player can't move off the grass to the right
        if(transform.position.x > hozBoundary)
        {
            transform.position = new Vector3(hozBoundary, transform.position.y, transform.position.z);
        }
        // Player can't move off the grass to the left
        if (transform.position.x < -hozBoundary)
        {
            transform.position = new Vector3(-hozBoundary, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
