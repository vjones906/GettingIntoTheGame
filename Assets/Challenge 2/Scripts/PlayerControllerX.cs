using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spaceCooldown = 0.5f;
    private float getSpace = 0;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > getSpace)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                getSpace = Time.time + spaceCooldown;
            }
        }
    }
}
