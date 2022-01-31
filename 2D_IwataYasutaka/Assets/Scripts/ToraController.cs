using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToraController : MonoBehaviour
{
	//移動させるコンポーネントを入れる
	private Rigidbody2D myRigidbody;

	//移動量
	private float velocity = 3.0f;

	//ジャンプ量
	private float jumppower = 7.0f;

	//地面に接触
	private bool isGround = false;

	//トラの体力

	//ハートのプレハブ
	public GameObject HeartPrefab;
	public GameObject PresentPrefab;
	//表情のオブジェクト
	public GameObject faceNormal;
	public GameObject faceSmile;
	public GameObject faceDamage;
	public GameObject faceDie;

	//表情のタイマー
	private float faceTimer = 0f;

	// Start is called before the first frame update
	void Start()
	{
		//Rigidbodyコンポーネントを取得
		this.myRigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		//移動（左と右）
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			//ジャンプ
			if (Input.GetKey(KeyCode.Space) && isGround)
			{
				this.myRigidbody.velocity = new Vector2(-velocity, jumppower);
			}
			else
			{
				this.myRigidbody.velocity = new Vector2(-velocity, this.myRigidbody.velocity.y);
			}
		}
		else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
			//ジャンプ
			if (Input.GetKey(KeyCode.Space) && isGround)
			{
				this.myRigidbody.velocity = new Vector2(velocity, jumppower);
			}
			else
			{
				this.myRigidbody.velocity = new Vector2(velocity, this.myRigidbody.velocity.y);
			}
		}
		else if (Input.GetKey(KeyCode.Space) && isGround)
		{
			this.myRigidbody.velocity = new Vector2(0.0f, jumppower);
		}

		//左の限界（クリップ）
		if (this.transform.position.x < -4.8f)
		{
			this.transform.position = new Vector2(-4.8f, this.transform.position.y);
		}
		//右の限界（クリップ）
		if (this.transform.position.x > 4.2f)
		{
			this.transform.position = new Vector2(4.2f, this.transform.position.y);
		}

		//表情のタイマー（経過時間の秒）
		faceTimer += Time.deltaTime;

		//表情をノーマルへ戻す
		if (faceTimer > 1.0f)
		{
			//表情
			faceNormal.SetActive(true);
			faceSmile.SetActive(false);
			faceDamage.SetActive(false);
			faceDie.SetActive(false);
		}
	}

	//衝突した
	void OnCollisionEnter2D(Collision2D other)
	{
		//Debug.Log( "OnCollisionEnter2D: " + other.gameObject.tag);

		//地面
		if (other.gameObject.tag == "Ground")
		{
			isGround = true;
		}
	}

	//衝突した（補強）
	void OnCollisionStay2D(Collision2D other)
	{
		//Debug.Log( "OnCollisionStay2D: " + other.gameObject.tag);

		//地面
		if (other.gameObject.tag == "Ground")
		{
			isGround = true;
		}
	}

	//衝突から離れた
	void OnCollisionExit2D(Collision2D other)
	{
		//Debug.Log( "OnCollisionExit2D: " + other.gameObject.tag);

		//地面
		if (other.gameObject.tag == "Ground")
		{
			isGround = false;
		}
	}

	//衝突（トリガー）
	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log( "OnTriggerEnter2D: " + other.gameObject.tag);

		//アイテム
		if (other.gameObject.tag == "Item")
		{
			//ライフ回復

			//表情（笑）
			faceNormal .SetActive(false);
			faceSmile  .SetActive(true);
			faceDamage .SetActive(false);
			faceDie    .SetActive(false);


			//表情のタイマーをリセット
			faceTimer = 0f;

			//ハート演出
			Instantiate(HeartPrefab, this.transform.position + new Vector3(0f, 2f, 0f), Quaternion.identity);

			//衝突相手を破棄
			Destroy(other.gameObject);
		}
		//サンタクロースと接触したとき
		if (other.gameObject.tag == "Santa")
		{
			Instantiate(PresentPrefab, this.transform.position + new Vector3(3f, 2f, 0f), Quaternion.identity);


			//障害物
			if (other.gameObject.tag == "Enemy")
			{
				//ライフ減らす

				//表情

				//敵と接触（ダメージ）
				if (other.gameObject.tag == "Enemy")
				{
					faceNormal.SetActive(false);
					faceSmile.SetActive(false);
					faceDamage.SetActive(true);
					faceDie.SetActive(false);

					faceTimer = 0f;
				}
			}
		}
	}
}

