using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall" || other.tag == "East Wall" || other.tag == "West Wall" || other.tag == "North Wall" || other.tag == "South Wall")
        {
            Destroy(gameObject);
            Debug.Log("Wall hit bullet.");
        }

        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Player hit bullet.");
        }

        if (other.tag == "Projectile")
        {
            Debug.Log("Two Projectile's passed over each other!");
        }

        else
        {
            Destroy(gameObject);
            Debug.Log("Something untagged was hit.");
        }
    }

}
