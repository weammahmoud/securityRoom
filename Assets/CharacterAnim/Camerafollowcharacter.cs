using UnityEngine;
using System.Collections;

public class Camerafollowcharacter : MonoBehaviour {

		public GameObject player;       //Public variable to store a reference to the player game object


		private Vector3 offset;         //Private variable to store the offset distance between the player and camera

		// Use this for initialization
		void Start () 
		{
			//Calculate and store the offset value by getting the distance between the player's position and camera's position.
			offset = transform.position - player.transform.position;
		}

		// LateUpdate is called after Update each frame
		void LateUpdate () 
		{
			// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
			transform.position = player.transform.position + offset;
		}

//
//		private float distance = 10.0f;
//		private float currentX = 0.0f;
//		private float currentY = 0.0f;
//		private float sensivetyX = 4.0f;
//		private float sensivetyY = 1.0f;
//		private Camera cam;
//		public Transform lookAt;
//		public Transform camTransform;
//
//		// Use this for initialization
//		void Start () {
//			camTransform = transform;
//			cam = Camera.main;
//
//
//		}
//
//		// Update is called once per frame
//		void LateUpdate () {
//			Vector3 dir = new Vector3(0,0,-distance);
//			Quaternion rotation = Quaternion.Euler(currentY,currentX,0);
//			camTransform.position = lookAt.position + rotation * dir;
//		}
	}

