using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
	// �X�N���[�����x
	private float scrollSpeed = -4.0f;
	// �w�i�I���ʒu
	private float deadLine = -12.78f;
	// �w�i�J�n�ʒu
	private float startLine = 12.78f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		// �w�i���ړ�����
		transform.Translate( this.scrollSpeed * Time.deltaTime, 0f, 0f);

		// ��ʊO�ɏo����A��ʉE�[�Ɉړ�����
		if( transform.position.x < this.deadLine)
		{
				transform.position = new Vector2( this.startLine, 0f);
		}
	}
}
