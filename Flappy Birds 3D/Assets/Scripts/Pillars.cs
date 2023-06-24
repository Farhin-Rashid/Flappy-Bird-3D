using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillars : MonoBehaviour
{
    [SerializeField] Vector3 movementVector;

    // Update is called once per frame
    void Update()
    {
        MovePillar();
    }

    void MovePillar(){
        transform.position += movementVector * Time.deltaTime;

        if(transform.position.x <= -16){ //FIX ME - change it so game object deletes when out of screen
            Destroy(this.gameObject);
        }
    }
}
