using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallController : MonoBehaviour
{
	// �ړ����x
	private float Speed = -2.0f;

	// �������x
	private float Fall = -2.0f;

	// �I���ʒu�iY�����j
	private float deadLine = -5.0f;

	//�ėp�^�C�}�[
	private float TimeCounter;

    // Start is called before the first frame update
    void Start()
    {
		//�����Ń^�C�}�[��0.0�`6.28�i2�΁j�ɐU��
        TimeCounter = Random.Range( 0f, Mathf.PI * 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
  		// �ړ����� ���t���[�����̎��������ׁ̈ATime.deltaTime���|����1�b�ԕӂ�̈ړ��ɕϊ�
		transform.Translate( (this.Speed + (Mathf.Cos( TimeCounter) * 1.5f)) * Time.deltaTime, this.Fall * Time.deltaTime, 0f);       
    
		//�^�C�}�[
		TimeCounter += Time.deltaTime;

		//��ʉ��ɏo����j������
		if( transform.position.y < deadLine) {
			Destroy( this.gameObject);
		}
	}
}
