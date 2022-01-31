using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallGenerator : MonoBehaviour
{
	//プレハブ
	public GameObject defPrefab;

	//チック
	private float TickCounter = 0.0f;

	//タイマー
	private float TimeCounter = 0f;

	//降らす時間設定 ※インスペクター側が優先するので注意
	public float MaxTime = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//n秒間隔（時間を刻む）
		if( TickCounter >= 0.1f) {
			TickCounter -= 0.1f;

			//雪
			Instantiate( defPrefab, new Vector3( Random.Range( -6f, 12f), 5.0f, 0f), Quaternion.identity);
		}

		//タイマー（チック）
		TickCounter += Time.deltaTime;

		//タイマー
		TimeCounter += Time.deltaTime;

		//時間が過ぎたら破棄
		if( TimeCounter > MaxTime) {
			Destroy( this.gameObject);
		}
	}
}
