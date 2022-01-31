using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallController : MonoBehaviour
{
	// 移動速度
	private float Speed = -2.0f;

	// 落下速度
	private float Fall = -2.0f;

	// 終了位置（Y方向）
	private float deadLine = -5.0f;

	//汎用タイマー
	private float TimeCounter;

    // Start is called before the first frame update
    void Start()
    {
		//乱数でタイマーを0.0～6.28（2π）に振る
        TimeCounter = Random.Range( 0f, Mathf.PI * 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
  		// 移動する ※フレーム数の自動調整の為、Time.deltaTimeを掛けて1秒間辺りの移動に変換
		transform.Translate( (this.Speed + (Mathf.Cos( TimeCounter) * 1.5f)) * Time.deltaTime, this.Fall * Time.deltaTime, 0f);       
    
		//タイマー
		TimeCounter += Time.deltaTime;

		//画面下に出たら破棄する
		if( transform.position.y < deadLine) {
			Destroy( this.gameObject);
		}
	}
}
