using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ObjectGenetator : MonoBehaviour
{
	//プレハブ（配列）
	public GameObject[] defPrefab;

	//チック
	private float tickCounter = 1.0f;

	//経過した秒
	private int secondCounter = 0;

	//デバッグ
	public GameObject uiDebug;

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
				case  0 : Hassei( 1, 1.0f);	break;
				case  3 : Hassei( 1, 1.0f);	break;
				case  6 : Hassei( 1, 1.0f);	break;
				case  9 : Hassei( 1, 1.0f); break;
				
				
				//春 10秒～29秒
				case 13 : Hassei( 4, 0.5f);	break;
				case 15 : Hassei( 4, 0.5f);	break;
				//お花畑の時間　17秒～30秒
				case 18 : Hassei( 12, 1.5f); break;
				case 20 : Hassei( 12, 1.5f); break;
				case 22 : Hassei( 12, 1.5f); break;
				case 24 : Hassei( 12, 1.5f); break;
				case 26 : Hassei( 12, 1.5f); break;
				case 28 : Hassei( 12, 1.5f); break;
				


				//夏 30～49秒
				case 30 : Hassei( 7, 1.0f);	break;
				case 33	: Hassei( 7, 1.0f); break;
				//ひまわり　34秒～41秒
				case 34 : Hassei(13, 5.7f); break;
				case 35 : Hassei(13, 5.7f); break;
				case 36 : Hassei(13, 5.7f); break;
				case 37 : Hassei(13, 5.7f); break;
				case 38 : Hassei(13, 5.7f); break;
				case 39 : Hassei(13, 5.7f); break;
				

				//秋 42秒～47秒
				case 42 : Hassei( 8, 1.0f); break;
				case 43 : Hassei( 9, 1.0f); break;
				case 44 : Hassei( 10, 1.3f); break;
				case 45 : Hassei( 8, 1.0f); break;
				case 46 : Hassei( 9, 1.0f); break;
				case 47 : Hassei( 10,1.3f); break;

				//冬 50～69秒
				
				case 50 : Hassei( 11, 1.0f); break;
				case 53 : Hassei( 11, 1.0f); break;
				case 56 : Hassei( 11, 1.0f); break;
				case 59 : Hassei( 11, 1.0f); break;
				
				//年末　60秒～80秒

				//雪のジェネレータ（30秒降る）
				case 60 : Hassei( 24, 0.0f); break;
				//雪だるま
				case 63 : Hassei( 14, 2.0f); break;
				case 68 : Hassei( 14, 2.0f); break;
				case 73 : Hassei( 14, 2.0f); break;
				//サンタクロース
				case 75 : Hassei( 16, 0.0f); break;
				//回復アイテム　Hyuuganatu　毎16秒ずつ設置
				case 16 : Hassei( 15, 0.5f); break;
				case 32 : Hassei( 15, 0.5f); break;
				case 48 : Hassei( 15, 0.5f); break;
				case 64 : Hassei( 15, 0.5f); break;
				case 80 : Hassei( 15, 0.5f); break;





				default :	break;
			}

			//デバッグ
			uiDebug.GetComponent<Text>().text = "" + (secondCounter % 80);

			//秒を進める
			secondCounter++;
		}

		//タイマー
		tickCounter += Time.deltaTime;
	}
}
