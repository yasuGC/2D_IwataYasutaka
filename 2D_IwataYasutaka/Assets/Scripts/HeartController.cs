using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //n�b�Ŏ��Ȕj������
		Destroy( this.gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
 		// �ړ����� ���t���[�����̎��������ׁ̈ATime.deltaTime���|����1�b�ԕӂ�̈ړ��ɕϊ�
		transform.Translate( 0f, 1.0f * Time.deltaTime, 0f);		        
    }
}
