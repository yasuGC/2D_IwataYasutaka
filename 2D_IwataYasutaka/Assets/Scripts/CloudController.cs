using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
	// 移動速度
	private float Speed = -1.0f;
	// 終了位置
	private float deadLine = -10.0f;
 
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		// 移動する
		transform.Translate( this.Speed * Time.deltaTime, 0f, 0f);

		// 画面外に出たら破棄する
		if( transform.position.x < this.deadLine)
		{
			Destroy( this.gameObject);
		}
	}
}
