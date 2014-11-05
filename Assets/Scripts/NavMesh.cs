using UnityEngine;
using System.Collections;

public class NavMesh : MonoBehaviour {

	public Transform leader;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<NavMeshAgent> ().destination = leader.position;
	}
}
