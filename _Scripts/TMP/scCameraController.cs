using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scCameraController : MonoBehaviour {

	public GameObject goAvatarGirl;
	public GameObject goAvatarBoy;

	private GameObject goTarget;
	public float xOffset, yOffset, zOffset;

	private int iAvatar;

	void Start() {
		iAvatar = GlobalVars.iAvatar;
		if (iAvatar == 1)
		{
			goTarget = goAvatarGirl;
		}
		else 
		{
			goTarget = goAvatarBoy;
		}
	}
	// Update is called once per frame
	void Update()
	{
		transform.position = goTarget.transform.position + new Vector3(xOffset, yOffset, zOffset);
		transform.LookAt(goTarget.transform.position);
	}
}
