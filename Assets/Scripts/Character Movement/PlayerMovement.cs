using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public float attackTime;

	private Animator anim;
	private Rigidbody2D myRigidbody;
	private bool playerMoving;
	private Vector2 lastMove;
	private bool attack;
	private float attackTimeCounter;

	void Start () {
		anim = GetComponent<Animator> ();
	}

	void Update () {

		playerMoving = false;

		if (Input.GetAxisRaw ("Horizontal") > 0.5f || Input.GetAxisRaw ("Horizontal") < -0.5f) {

			transform.Translate (new Vector3 (Input.GetAxisRaw ("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
			playerMoving = true;
			lastMove = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0f);
		}

		if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f ) {

			transform.Translate (new Vector3 (0f, Input.GetAxisRaw ("Vertical") * moveSpeed * Time.deltaTime, 0f));
			playerMoving = true;
			lastMove = new Vector2 (0f, Input.GetAxisRaw ("Vertical"));
		}

		if (Input.GetAxisRaw ("Horizontal") < 0.5f && Input.GetAxisRaw ("Horizontal") > -0.5f) {

			myRigidbody.velocity = new Vector2 (Of, myRigidbody.velocity.y);

		}

		if (Input.GetAxisRaw ("Vertical") < 0.5f && Input.GetAxisRaw ("Vertical") > -0.5f) {

			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, Of);

		}
			

		if (Input.GetKeyDown (KeyCode.Space)) {

			attackTimeCounter = attackTime;
			attack = true;
			myRigidbody.velocity = Vector2.zero;
			anim.SetBool ("Attack", true);

		}


		anim.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		anim.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));
		anim.SetBool ("PlayerMoving", playerMoving);
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat ("LastMoveY", lastMove.y);
		anim.SetBool ("Attack", attack);
	}
}
