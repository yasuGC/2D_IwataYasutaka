using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpareGenetator : MonoBehaviour
{
	//�v���n�u�i�z��j
	public GameObject[] defPrefab;

	//�`�b�N
	private float tickCounter = 1.0f;

	//�o�߂����b
	private int secondCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	//��������֐��idefPrefab�̃C���X�^���X�j
	void Hassei( int number, float y)
	{
		Instantiate( defPrefab[ number], new Vector3( 10f, y, 0f), Quaternion.identity);
	}

	//Hassei�֐��ɂ���
	//�������̓v���n�u�ԍ��A�������͏o������Y���W

    // Update is called once per frame
    void Update()
    {
        //�`�b�N
		if( tickCounter >= 1.0f)
		{
			//�^�C�}�[�i1�b�̊Ԋu�j
			tickCounter -= 1.0f;

			//��������I�u�W�F�N�g ���ȉ��� case�`��ǉ����Ă�������
			switch( secondCounter % 80)
			{
				//�~�A 0�`9�b
				//case  0 : Hassei( 1, 0.0f);	break;

				//�t 10�b�`29�b
				//���Ԕ��̎��� 17�b�`27�b�܂�
				

				case 20 : Hassei( 4, -4.0f);	break;
				case 21 : Hassei( 4, -4.0f);	break;
				case 22 : Hassei( 4, -4.0f);	break;
				case 23 : Hassei( 4, -4.0f);	break;
				case 24 : Hassei( 4, -4.0f);	break;
				case 25 : Hassei( 4, -4.0f);	break;
				case 26 : Hassei( 4, -4.0f);	break;
				case 27 : Hassei( 4, -4.0f);	break;
				case 28 : Hassei( 4, -4.0f);	break;
				case 29 : Hassei( 4, -4.0f);	break;
				case 30 : Hassei( 4, -4.0f);	break;


				//�� 30�`49�b
				case 35 : Hassei( 8, -4.8f);	break;
				case 36 : Hassei( 8, -4.8f);	break;
				case 37 : Hassei( 8, -4.8f);	break;
				case 38 : Hassei( 8, -4.8f);	break;
				case 39 : Hassei( 8, -4.8f);	break;

				//�N�� 60�b�`80�b

				case 63: Hassei(12, -4.8f); break;
				case 68: Hassei(12, -4.8f); break;
				case 73: Hassei(12, -4.8f); break;
				

				default:	break;
			}

			//�b��i�߂�
			secondCounter++;
		}

		//�^�C�}�[
		tickCounter += Time.deltaTime;
	}
}
