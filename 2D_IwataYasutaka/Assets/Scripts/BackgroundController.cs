using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
	// スクロール速度
	private float scrollSpeed = -4.0f;
	// 背景終了位置
	private float deadLine = -12.78f;
	// 背景開始位置
	private float startLine = 12.78f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		// 背景を移動する
		transform.Translate( this.scrollSpeed * Time.deltaTime, 0f, 0f);

		// 画面外に出たら、画面右端に移動する
		if( transform.position.x < this.deadLine)
		{
				transform.position = new Vector2( this.startLine, 0f);
		}
	}
}
