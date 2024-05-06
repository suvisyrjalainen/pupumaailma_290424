using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public CharacterController controller;

    private float verticalSpeed = 0f;
	private float horizontalSpeed = 0f;

    private float mouseMovement = 0f;

    public Animator animator;
	
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

        //hiirellä kääntyminen
		mouseMovement += Input.GetAxis("Mouse X") * 5;
		transform.localRotation = Quaternion.Euler(0, mouseMovement, 0);
		direction = transform.rotation * direction;

        controller.Move(direction * Time.deltaTime * 5);

        if(verticalSpeed > 0){
			animator.SetBool("Run", true);
		}
		else{
			animator.SetBool("Run", false);
		}
    }
}
