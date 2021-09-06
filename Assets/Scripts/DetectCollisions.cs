using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Destroy food and animals on collision
    private void OnTriggerEnter(Collider other)
    {
        //Destry the food
        Destroy(gameObject);

        // Destroy the animal
        Destroy(other.gameObject);
    }
}
