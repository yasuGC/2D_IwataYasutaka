using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToraController : MonoBehaviour
{
	//�ړ�������R���|�[�l���g������
	private Rigidbody2D myRigidbody;

	//�ړ���
	private float velocity = 3.0f;

	//�W�����v��
	private float jumppower = 7.0f;

	//�n�ʂɐڐG
	private bool isGround = false;

	//�g���̗̑�

	//�n�[�g�̃v���n�u
	public GameObject HeartPrefab;
	public GameObject PresentPrefab;
	//�\��̃I�u�W�F�N�g
	public GameObject faceNormal;
	public GameObject faceSmile;
	public GameObject faceDamage;
	public GameObject faceDie;

	//�\��̃^�C�}�[
	private float faceTimer = 0f;

	// Start is called before the first frame update
	void Start()
	{
		//Rigidbody�R���|�[�l���g���擾
		this.myRigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		//�ړ��i���ƉE�j
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			//�W�����v
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
			//�W�����v
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

		//���̌��E�i�N���b�v�j
		if (this.transform.position.x < -4.8f)
		{
			this.transform.position = new Vector2(-4.8f, this.transform.position.y);
		}
		//�E�̌��E�i�N���b�v�j
		if (this.transform.position.x > 4.2f)
		{
			this.transform.position = new Vector2(4.2f, this.transform.position.y);
		}

		//�\��̃^�C�}�[�i�o�ߎ��Ԃ̕b�j
		faceTimer += Time.deltaTime;

		//�\����m�[�}���֖߂�
		if (faceTimer > 1.0f)
		{
			//�\��
			faceNormal.SetActive(true);
			faceSmile.SetActive(false);
			faceDamage.SetActive(false);
			faceDie.SetActive(false);
		}
	}

	//�Փ˂���
	void OnCollisionEnter2D(Collision2D other)
	{
		//Debug.Log( "OnCollisionEnter2D: " + other.gameObject.tag);

		//�n��
		if (other.gameObject.tag == "Ground")
		{
			isGround = true;
		}
	}

	//�Փ˂����i�⋭�j
	void OnCollisionStay2D(Collision2D other)
	{
		//Debug.Log( "OnCollisionStay2D: " + other.gameObject.tag);

		//�n��
		if (other.gameObject.tag == "Ground")
		{
			isGround = true;
		}
	}

	//�Փ˂��痣�ꂽ
	void OnCollisionExit2D(Collision2D other)
	{
		//Debug.Log( "OnCollisionExit2D: " + other.gameObject.tag);

		//�n��
		if (other.gameObject.tag == "Ground")
		{
			isGround = false;
		}
	}

	//�Փˁi�g���K�[�j
	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log( "OnTriggerEnter2D: " + other.gameObject.tag);

		//�A�C�e��
		if (other.gameObject.tag == "Item")
		{
			//���C�t��

			//�\��i�΁j
			faceNormal .SetActive(false);
			faceSmile  .SetActive(true);
			faceDamage .SetActive(false);
			faceDie    .SetActive(false);


			//�\��̃^�C�}�[�����Z�b�g
			faceTimer = 0f;

			//�n�[�g���o
			Instantiate(HeartPrefab, this.transform.position + new Vector3(0f, 2f, 0f), Quaternion.identity);

			//�Փˑ����j��
			Destroy(other.gameObject);
		}
		//�T���^�N���[�X�ƐڐG�����Ƃ�
		if (other.gameObject.tag == "Santa")
		{
			Instantiate(PresentPrefab, this.transform.position + new Vector3(3f, 2f, 0f), Quaternion.identity);


			//��Q��
			if (other.gameObject.tag == "Enemy")
			{
				//���C�t���炷

				//�\��

				//�G�ƐڐG�i�_���[�W�j
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

