using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behavior : MonoBehaviour
{

    public GameObject Player;

	void Start ()
    {
        Player.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
	
	void Update ()
    {

        Player.transform.position = new Vector3(Player.transform.position.x, 0, Player.transform.position.z);
        Player.transform.rotation = new Quaternion(0, 0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z += 0.50f;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.z -= 0.50f;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x += 0.50f;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x -= 0.50f;
            this.transform.position = position;
        }
    }
}
