using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallGenerator : MonoBehaviour
{
	//�v���n�u
	public GameObject defPrefab;

	//�`�b�N
	private float TickCounter = 0.0f;

	//�^�C�}�[
	private float TimeCounter = 0f;

	//�~�炷���Ԑݒ� ���C���X�y�N�^�[�����D�悷��̂Œ���
	public float MaxTime = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//n�b�Ԋu�i���Ԃ����ށj
		if( TickCounter >= 0.1f) {
			TickCounter -= 0.1f;

			//��
			Instantiate( defPrefab, new Vector3( Random.Range( -6f, 12f), 5.0f, 0f), Quaternion.identity);
		}

		//�^�C�}�[�i�`�b�N�j
		TickCounter += Time.deltaTime;

		//�^�C�}�[
		TimeCounter += Time.deltaTime;

		//���Ԃ��߂�����j��
		if( TimeCounter > MaxTime) {
			Destroy( this.gameObject);
		}
	}
}
