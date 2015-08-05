using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

	public GameObject menu; 

	public GameObject helpWindow;

	private bool isShowing = true;

	private bool isShowingHelpCanvas = false;

	// Use this for initialization
	void Start () {
		helpWindow.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClick()
	{
		Debug.Log("I've just been clicked");
	}

	public void exitApplication()
	{
		Debug.Log("Exit game!");
		Application.Quit ();
	}

	public void hideMenu()
	{
		isShowing = !isShowing;
		menu.SetActive(isShowing);
	}

	public void hideHelpPanel()
	{
		helpWindow.SetActive(false);
	}

	public void showHelpPanel()
	{
		helpWindow.SetActive(true);
	}
}
