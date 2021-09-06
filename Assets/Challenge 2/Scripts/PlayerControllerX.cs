using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float elapsedTime; //timer to check spawning of dogs

    void Start()
    {
        elapsedTime = -2;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time - elapsedTime > 2.0f))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            elapsedTime = Time.time;
        }
    }
}
