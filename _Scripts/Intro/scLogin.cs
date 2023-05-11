using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scLogin : MonoBehaviour {

	public GameObject goPanelIntro;
	public GameObject goPanelSelAvatar;
	// Use this for initialization
	void Start()
	{
		print("hola");
	}

	// Update is called once per frame
	void Update()
	{

	}
	public void ShowSelAvatarPanel()
	{
		print("ggggg");
		goPanelIntro.SetActive(false);
		goPanelSelAvatar.SetActive(true);

	}
}
