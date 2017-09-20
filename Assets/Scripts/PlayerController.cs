using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	private void FixedUpdate ()
	{
		float x = Input.GetAxis("Horizontal"); //Horizontalは水平方向
		float z = Input.GetAxis("Vertical");  //Verticalは垂直方向

		//PlayerがもつRigidbody コンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		//rigidbodyのx軸（横）とz軸（奥）に力を加える
		rigidbody.AddForce(x*5,0,z*5);

		if(Input.GetKeyDown(KeyCode.Space) && rigidbody.velocity.y == 0.00f)
		{
			rigidbody.AddForce (0, 200, 0);
		}

		if (Input.GetKey(KeyCode.X))
		{
			rigidbody.velocity = Vector3.zero;
		}


	}
}
