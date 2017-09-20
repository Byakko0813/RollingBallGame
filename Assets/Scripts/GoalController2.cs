using System.Collections;
using UnityEngine;

public class GoalController2 : MonoBehaviour {

	//UIControllerを参照する
	public UIController UIController;

	// Trigger との接触時に呼ばれる　callback
	private void OnTriggerEnter (Collider hit)
	{
		//接触対象はPlayerタグかどうか
		if(hit.CompareTag ("Player"))
		{

			//Rigidbodyを停止させる
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			//ゲームクリアを表示する
			UIController.ShowGameOverLabel();
			UIController.ShowRetryButton();



		}



	}
}
