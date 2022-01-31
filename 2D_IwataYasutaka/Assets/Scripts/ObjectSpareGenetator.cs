using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpareGenetator : MonoBehaviour
{
	//プレハブ（配列）
	public GameObject[] defPrefab;

	//チック
	private float tickCounter = 1.0f;

	//経過した秒
	private int secondCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	//発生する関数（defPrefabのインスタンス）
	void Hassei( int number, float y)
	{
		Instantiate( defPrefab[ number], new Vector3( 10f, y, 0f), Quaternion.identity);
	}

	//Hassei関数について
	//第一引数はプレハブ番号、第二引数は出現時のY座標

    // Update is called once per frame
    void Update()
    {
        //チック
		if( tickCounter >= 1.0f)
		{
			//タイマー（1秒の間隔）
			tickCounter -= 1.0f;

			//生成するオブジェクト ※以下の case～を追加してください
			switch( secondCounter % 80)
			{
				//冬② 0～9秒
				//case  0 : Hassei( 1, 0.0f);	break;

				//春 10秒～29秒
				//お花畑の時間 17秒～27秒まで
				

				case 20 : Hassei( 4, -4.0f);	break;
				case 21 : Hassei( 4, -4.0f);	break;
				case 22 : Hassei( 4, -4.0f);	break;
				case 23 : Hassei( 4, -4.0f);	break;
				case 24 : Hassei( 4, -4.0f);	break;
				case 25 : Hassei( 4, -4.0f);	break;
				case 26 : Hassei( 4, -4.0f);	break;
				case 27 : Hassei( 4, -4.0f);	break;
				case 28 : Hassei( 4, -4.0f);	break;
				case 29 : Hassei( 4, -4.0f);	break;
				case 30 : Hassei( 4, -4.0f);	break;


				//夏 30～49秒
				case 35 : Hassei( 8, -4.8f);	break;
				case 36 : Hassei( 8, -4.8f);	break;
				case 37 : Hassei( 8, -4.8f);	break;
				case 38 : Hassei( 8, -4.8f);	break;
				case 39 : Hassei( 8, -4.8f);	break;

				//年末 60秒～80秒

				case 63: Hassei(12, -4.8f); break;
				case 68: Hassei(12, -4.8f); break;
				case 73: Hassei(12, -4.8f); break;
				

				default:	break;
			}

			//秒を進める
			secondCounter++;
		}

		//タイマー
		tickCounter += Time.deltaTime;
	}
}
