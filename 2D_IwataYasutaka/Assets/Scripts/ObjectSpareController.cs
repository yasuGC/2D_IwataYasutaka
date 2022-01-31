using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpareController : MonoBehaviour
{
	// �ړ����x
	private float Speed = -8.0f;

	// �I���ʒu�iX�����j
	private float deadLine = -12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
