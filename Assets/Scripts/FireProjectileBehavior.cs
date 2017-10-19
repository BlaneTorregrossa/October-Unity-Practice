using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectileBehavior : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject projectile;
    public Transform projectileTransform;
    public FireBall fireBall;
    public GameObject Player;

    protected GameObject NewProjectile;

    private float time;
    private int projectileCounter;


    void Start ()
    {
        projectileCounter = 0;
        projectile.transform.localScale = new Vector3(1, 1, 1);
	}
	
	void Update ()
    {
        time = UnityEngine.Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.F))
        {
            Spawn();
            Debug.Log("A projectile was fired!");
        }


        NewProjectile.transform.position -= (Player.transform.position + new Vector3(-0.05f, 0, 0)) * fireBall.speed;
        
    }

    void Spawn()
    {
        projectileCounter++;
        NewProjectile = Instantiate(projectile, projectileTransform.transform.position, projectileTransform.transform.rotation);
        NewProjectile.transform.position += transform.forward + transform.up;
        fireBall.speed = Random.Range(0.1f, 0.9f);
        fireBall.scale = Random.Range(0.01f, 0.09f);
        projectile.transform.localScale += new Vector3(fireBall.scale, 0, fireBall.scale);
    }

    
}
