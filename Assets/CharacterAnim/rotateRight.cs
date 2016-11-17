using UnityEngine;
using System.Collections;

public class rotateRight : MonoBehaviour {
	private Animator anim;
	private int intss;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>(); 
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) //tol mahwa daes
		{
			intss = 1;

		}
		else if (Input.GetKey(KeyCode.W)) //tol mahwa daes
		{
			intss = 2;

		}
		else if (Input.GetKey(KeyCode.D)) //tol mahwa daes
		{
			intss = 3;

		}
        else if(Input.GetKey(KeyCode.S)) //tol mahwa daes

        {
            intss = 4;

        }
        else
        intss = 0;
		anim.SetInteger("intss",intss);

	}

}
