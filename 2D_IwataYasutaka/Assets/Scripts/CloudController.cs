using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
	// �ړ����x
	private float Speed = -1.0f;
	// �I���ʒu
	private float deadLine = -10.0f;
 
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		// �ړ�����
		transform.Translate( this.Speed * Time.deltaTime, 0f, 0f);

		// ��ʊO�ɏo����j������
		if( transform.position.x < this.deadLine)
		{
			Destroy( this.gameObject);
		}
	}
}
