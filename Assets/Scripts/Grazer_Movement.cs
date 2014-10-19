using UnityEngine;
using System.Collections;


public class Grazer_Movement : MonoBehaviour {

	
		//
	public Vector2 speed = new Vector2(5, 5);
	public CircleCollider2D circle;	
	private Vector2 movement;
	private Vector2 currentPos;
	private Collider2D currentFood;
	private float moveCounter = 0f;
	private float turnRate = 2.5f;
	private Vector2 targetPos;
	private float screenWidth = Screen.width;
	private float screenHeight = Screen.height;
	private float x;
	private float y;


		void Start()
		{
//		targetPos.x = Random.Range(-10,10);
//		targetPos.y = Random.Range(-5,5);
		x = Random.Range (0.0f, 1.0f);
		y = Random.Range (0.0f, 1.0f);
		targetPos = Camera.main.ViewportToWorldPoint(new Vector2(x,y));

		}

		void Update()
		{

			
		if (currentFood == null) {

			if (moveCounter >= turnRate){
				moveCounter = 0;
//				targetPos.x = Random.Range(,);
//				targetPos.y = Random.Range(-5,5);
				x = Random.Range (0.0f, 1.0f);
				y = Random.Range (0.0f, 1.0f);
				targetPos = Camera.main.ViewportToWorldPoint(new Vector2(x,y));



			}
			moveCounter += Time.deltaTime;
			transform.position = Vector3.MoveTowards(transform.position, targetPos, 3*Time.deltaTime );

			circle.radius = 0.5f;    // ATTENTION!!


//						float inputX = Input.GetAxis ("Horizontal");
//						float inputY = Input.GetAxis ("Vertical");
//						movement = new Vector2 (
//						speed.x * inputX,
//						speed.y * inputY);
				}

		if (currentFood != null){
			transform.position = Vector3.MoveTowards(transform.position, targetPos, 1*Time.deltaTime );
		}
		}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{

			currentFood = otherCollider;
			targetPos = otherCollider.transform.position;
			circle.radius = 0.115f;    //ATTENTION!!
			movement = new Vector2(0, 0);

	}



		
		void FixedUpdate()
		{
			// 5 - Move the game object
			rigidbody2D.velocity = movement;

		}
	}
