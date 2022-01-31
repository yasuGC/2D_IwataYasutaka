using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
	// �ړ����x
	private float Speed = -2.0f;

	// �I���ʒu�iX�����j
	private float deadLine = -12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  		// �ړ����� ���t���[�����̎��������ׁ̈ATime.deltaTime���|����1�b�ԕӂ�̈ړ��ɕϊ�
		transform.Translate( this.Speed * Time.deltaTime, (Mathf.Cos( Time.time) * 0.5f) * Time.deltaTime, 0f);
		
		// ��ʊO�ɏo����j������
		if( transform.position.x < this.deadLine)
		{
			Destroy( this.gameObject);
		} 
    }
}
