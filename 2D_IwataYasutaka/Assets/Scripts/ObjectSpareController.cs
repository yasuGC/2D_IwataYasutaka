using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpareController : MonoBehaviour
{
	// 移動速度
	private float Speed = -8.0f;

	// 終了位置（X方向）
	private float deadLine = -12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
