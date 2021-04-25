using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	//Comentario de prueba para GitHub
	[SerializeField] GameObject cameraHolder;

	[SerializeField] float mouseSensitivity, sprintSpeed, walkSpeed, jumpForce, smoothTime;
	/*
	[SerializeField] Item[] items;
	
	int itemIndex;
	int previousItemIndex = -1;
	*/
	float verticalLookRotation;
	bool grounded;
	Vector3 smoothMoveVelocity;
	Vector3 moveAmount;


	[Header("General")]
	[SerializeField] public LayerMask hittableLayers;
	[SerializeField] public GameObject bulletHolePrefab;

	[Header("Shoot Paramaters")]
	public float fireRange = 200;

	private Transform cameraPlayerTransform;
	PhotonView PV;
	Rigidbody rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
		PV = GetComponent<PhotonView>();
	}
	
	void Start()
	{
		
		if (!PV.IsMine)
		{ 
			Destroy(GetComponentInChildren<Camera>().gameObject);
			Destroy(rb);
		}
	}
	
	void Update()
	{
		
		if (!PV.IsMine)
			return;
			
		Look();
		Move();
		Jump();
		

	}

	void Look()
	{
		transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity);

		verticalLookRotation += Input.GetAxisRaw("Mouse Y") * mouseSensitivity;
		verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

		cameraHolder.transform.localEulerAngles = Vector3.left * verticalLookRotation;
	}

	void Move()
	{
		Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

		moveAmount = Vector3.SmoothDamp(moveAmount, moveDir * (Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : walkSpeed), ref smoothMoveVelocity, smoothTime);
	}

	void Jump()
	{
		if (Input.GetKeyDown(KeyCode.Space) && grounded)
		{
			rb.AddForce(transform.up * jumpForce);
		}
	}
	
	[PunRPC]
	void Shooting ()
	{
		

			Transform t_spawn = transform.Find("CameraHolder/Camera");
			RaycastHit hit = new RaycastHit();
			if (Physics.Raycast(t_spawn.position, t_spawn.forward, out hit, fireRange, hittableLayers))
			{
				UnityEngine.Debug.Log("Pium");
				GameObject bulletHoleClone = Instantiate(bulletHolePrefab, hit.point + hit.normal * 0.001f, Quaternion.LookRotation(hit.normal)) as GameObject;
				Destroy(bulletHoleClone, 4f);
			}
			else
			{
				UnityEngine.Debug.Log("No");
			}
		
	}

	public void SetGroundedState(bool _grounded)
	{
		grounded = _grounded;
	}

	void FixedUpdate()
	{
		if (!PV.IsMine) 
		{
			return;
		}
		rb.MovePosition(rb.position + transform.TransformDirection(moveAmount) * Time.fixedDeltaTime);
		if (PV.IsMine)
		{
			if (Input.GetButtonDown("Fire1"))
			{
				PV.RPC("Shooting", RpcTarget.All);
			}
		}
		
	}
}

