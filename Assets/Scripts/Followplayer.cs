using System.Collections;
using UnityEngine;

public class Followplayer : MonoBehaviour {

	// プレイヤーのTransform
	public Transform player;
	//相対座標
	private Vector3 offset;


	private void Start()
	{
		//MaincameraとPlayerの相対距離を求める
		offset = GetComponent<Transform> ().position - player.position;
	}


	private void Update () {
		
	
	  // cameraの座標にPlayerの座標とoffset加算した値を代入する
		GetComponent<Transform>().position = player.position + offset;

		
	}
}
