using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public CharacterController controller;

    private float verticalSpeed = 0f;
	private float horizontalSpeed = 0f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //eteen ja sivulle liikkuminen
        //tällä rivillä saadaan pelaaja liikkumaan eteen ja sivulle
		verticalSpeed = Input.GetAxis("Vertical");
		horizontalSpeed = Input.GetAxis("Horizontal");
		Vector3 direction = new Vector3(horizontalSpeed, -1, verticalSpeed);

        controller.Move(direction * Time.deltaTime * 5);
    }
}
