using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{

	public static GameController Instance;

	[Space(10)]
	[Header("Player")]
	public GameObject goAvatarGirl;
	public GameObject goAvatarBoy;
	private GameObject goPlayer;
	private int iPlayer;

	[Space(10)]
	[Header("Canvas")]
	public GameObject pnlAnswerQuestion;

	List<string> urls;
	private int iIndexListUrls = 0;

	private void Awake()
	{
		Instance = this;
		SetupGame();

		urls = GlobalVars.urls;

		pnlAnswerQuestion.SetActive(false);
	}

	void Start()
	{

	}

	void Update()
	{

	}

	public void ShowDialog(string nameObj)
	{
		iIndexListUrls = Int32.Parse(nameObj);
		pnlAnswerQuestion.SetActive(true);
	}


	public void OpenUrl()
	{
		print("URL: " + urls[iIndexListUrls]);
		Application.OpenURL(urls[iIndexListUrls]);		
	}

	private void SetupGame()
	{
		iPlayer = GlobalVars.iAvatar;

		if (iPlayer == 1) // 1:Girl was selected
		{
			goPlayer = goAvatarGirl;
			goAvatarGirl.SetActive(true);
			goAvatarBoy.SetActive(false);
		}
		else // 2:Boy was selected
		{
			goPlayer = goAvatarBoy;
			goAvatarGirl.SetActive(false);
			goAvatarBoy.SetActive(true);
		}
	}

	public void onClickUIButton()
	{
		string sButtonName;
		sButtonName = EventSystem.current.currentSelectedGameObject.name;
		switch (sButtonName)
		{
			case "btnAnswerQuestion":				
				OpenUrl();
				pnlAnswerQuestion.SetActive(false);

				break;
			case "btnAnswerLater":				
				pnlAnswerQuestion.SetActive(false);
				break;

		}
	}
}