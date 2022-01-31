using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //n秒で自己破棄する
		Destroy( this.gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
 		// 移動する ※フレーム数の自動調整の為、Time.deltaTimeを掛けて1秒間辺りの移動に変換
		transform.Translate( 0f, 1.0f * Time.deltaTime, 0f);		        
    }
}
