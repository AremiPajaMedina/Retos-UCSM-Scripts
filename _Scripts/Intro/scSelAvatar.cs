using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class scSelAvatar : MonoBehaviour {

	public GameObject goPanelSelAvatar;
	public GameObject goPanelLoading;

	private AsyncOperation async;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SelectAvatar()
	{
		int iPersonaje = Int32.Parse(EventSystem.current.currentSelectedGameObject.transform.GetChild(0).name);
		print("Personaje: " + iPersonaje);
		GlobalVars.iAvatar = iPersonaje; // 1: Girl       2: Boy 
		goPanelLoading.SetActive(true);
		//goPanelSelAvatar.SetActive(false);
		StartCoroutine(LoadScene());
		StartCoroutine(ShowScene());
	}

	IEnumerator LoadScene()
	{

		async = SceneManager.LoadSceneAsync("Main");
		async.allowSceneActivation = false;
		yield return async;		
	}

	IEnumerator ShowScene()
	{
		yield return new WaitForSeconds(5f);
		async.allowSceneActivation = true;
	}
}
