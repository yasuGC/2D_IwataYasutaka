using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
	// 移動速度
	private float Speed = -2.0f;

	// 終了位置（X方向）
	private float deadLine = -12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  		// 移動する ※フレーム数の自動調整の為、Time.deltaTimeを掛けて1秒間辺りの移動に変換
		transform.Translate( this.Speed * Time.deltaTime, (Mathf.Cos( Time.time) * 0.5f) * Time.deltaTime, 0f);
		
		// 画面外に出たら破棄する
		if( transform.position.x < this.deadLine)
		{
			Destroy( this.gameObject);
		} 
    }
}
