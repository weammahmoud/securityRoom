using UnityEngine;
using System.Collections;

public class lighton : MonoBehaviour {
	public Light lightbulb=null;
	// Use this for initialization
	void Start () {
		lightbulb.GetComponent<Light> ();
		lightbulb.enabled = true;
		lightbulb.color = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
		lightbulb.enabled = true;
		lightbulb.color = Color.yellow;
	
	}
}

