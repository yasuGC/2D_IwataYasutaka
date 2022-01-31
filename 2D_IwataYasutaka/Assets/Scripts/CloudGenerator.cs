using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
	//雲のプレハブ（大きさが違う三種類）
	public GameObject prefabCloud_L;
	public GameObject prefabCloud_M;
	public GameObject prefabCloud_S;

	//チック
	private float tickCounter = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //チック
		if( tickCounter >= 10.0f)
		{
			//タイマー（ランダムで振る）
			tickCounter -= Random.Range( 3.0f, 10.0f);

			//雲を生成する
			switch( Random.Range(0, 3) ) {
				case 0: Instantiate( prefabCloud_L, new Vector3( 10f, Random.Range( 0.0f, 3.0f), 0f), Quaternion.identity); break;
				case 1: Instantiate( prefabCloud_M, new Vector3( 10f, Random.Range( 0.0f, 3.0f), 0f), Quaternion.identity); break;
				case 2: Instantiate( prefabCloud_S, new Vector3( 10f, Random.Range( 0.0f, 3.0f), 0f), Quaternion.identity); break;

				default: break;
			}
		}

		//タイマー
		tickCounter += Time.deltaTime;
    }
}
