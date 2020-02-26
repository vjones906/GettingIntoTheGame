using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    const float hozBoundary = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 3;
        float result = 1.0f / num1;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
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
        float hozInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hozInput * Time.deltaTime * speed);
    }
}
