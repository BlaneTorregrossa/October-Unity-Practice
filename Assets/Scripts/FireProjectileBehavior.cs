using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectileBehavior : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject NewProjectile;
    public GameObject projectileObject;
    public Transform projectileTransform;

    public FireBall fireBall;
    public GameObject Player;

    //public int projectileCounter;

    private bool projectileStillPresent;
    private Vector3 Direction;
    private float SpawnPos;
    private string lastFired;


    void Start()
    {
        //projectileCounter = 0;
        projectileObject.transform.localScale = new Vector3(1, 1, 1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            lastFired = "F";
            SpawnA();
            SpawnPos = Random.Range(-50f, 50f);
            //projectileCounter++;
            Debug.Log("A projectile type A was fired!");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            lastFired = "E";
            SpawnB();
            SpawnPos = Random.Range(-50f, 50f);
            //projectileCounter++;
            Debug.Log("A projectile type B was fired!");
        }


        if (lastFired == "F")
        {
            projectileObject.transform.position = new Vector3(projectileObject.transform.position.x - 1, 0, SpawnPos);
            projectileObject.transform.position -= Spawner.transform.position * 0.02f;
        }

        if (lastFired == "E")
        {
            projectileObject.transform.position = new Vector3(SpawnPos, 0, projectileObject.transform.position.z - 1);
            projectileObject.transform.position -= Spawner.transform.position * 0.02f;
        }

    }
  
    void SpawnA()
    {
        projectileObject = NewProjectile;
        projectileTransform = NewProjectile.GetComponent<Transform>();

        projectileObject = Instantiate(projectileObject, NewProjectile.transform.position, NewProjectile.transform.rotation);
        fireBall.scale = Random.Range(0.01f, 1.25f);
        projectileObject.transform.localScale += new Vector3(fireBall.scale, 0, fireBall.scale);
    }


    void SpawnB()
    {
        projectileObject = NewProjectile;
        projectileTransform = NewProjectile.GetComponent<Transform>();

        projectileObject = Instantiate(projectileObject, NewProjectile.transform.position, NewProjectile.transform.rotation);
        fireBall.scale = Random.Range(0.01f, 1.25f);
        projectileObject.transform.localScale += new Vector3(fireBall.scale, 0, fireBall.scale);
    }


}
