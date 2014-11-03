using UnityEngine;
using System.Collections;

public class FollowAI : MonoBehaviour {
	
	public Transform Leader;
	public float AISpeed = 1;
	public float MaxDistance = 7;
	public float MinDistance = 2;
	public float gravity = 2;
	private Vector3 moveDirection = Vector3.zero;
	private float gVelocity = 0;
	private Animator anim;
	
	// Use this for initialization
	void Start () 
	{
		//Leader = GameObject.Find("Player").transform;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//GetComponent(CharacterController).SimpleMove(Vector3.zero);
		//Apply gravity
		gVelocity += gravity * Time.deltaTime;
		moveDirection.y -= gravity;
		transform.LookAt (Leader);
		
		//animation.Play("walk01");
		//anim.Play ("walk01");
		
		// block rotation
		
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
		
		
		
		
		AI ();
	}
	
	void AI () 
	{
		if (Vector3.Distance (transform.position, Leader.position) >= MinDistance) 
		{
			transform.position += transform.forward*AISpeed*Time.deltaTime;
			
			
			/*
			if (Vector3.Distance (transform.position, Leader.position) >= MaxDistance)
			{
				AIDie ();
			}
			*/
			
			anim.Play ("walk03");
			
		}
		else
		{
			anim.Play ("atack01");
		}
	}
	
	void AIDie () 
	{
		Destroy (gameObject);
	}
}