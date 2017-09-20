using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class RetryButtonController : MonoBehaviour {


	public UIController UIController;

	public void OnClick() 
	{
		Debug.Log("Button click!");
		gameObject.SetActive(false);
		SceneManager.LoadScene ("Game");

	}
}
