using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ObjectGenetator : MonoBehaviour
{
	//�v���n�u�i�z��j
	public GameObject[] defPrefab;

	//�`�b�N
	private float tickCounter = 1.0f;

	//�o�߂����b
	private int secondCounter = 0;

	//�f�o�b�O
	public GameObject uiDebug;

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
				case  0 : Hassei( 1, 1.0f);	break;
				case  3 : Hassei( 1, 1.0f);	break;
				case  6 : Hassei( 1, 1.0f);	break;
				case  9 : Hassei( 1, 1.0f); break;
				
				
				//�t 10�b�`29�b
				case 13 : Hassei( 4, 0.5f);	break;
				case 15 : Hassei( 4, 0.5f);	break;
				//���Ԕ��̎��ԁ@17�b�`30�b
				case 18 : Hassei( 12, 1.5f); break;
				case 20 : Hassei( 12, 1.5f); break;
				case 22 : Hassei( 12, 1.5f); break;
				case 24 : Hassei( 12, 1.5f); break;
				case 26 : Hassei( 12, 1.5f); break;
				case 28 : Hassei( 12, 1.5f); break;
				


				//�� 30�`49�b
				case 30 : Hassei( 7, 1.0f);	break;
				case 33	: Hassei( 7, 1.0f); break;
				//�Ђ܂��@34�b�`41�b
				case 34 : Hassei(13, 5.7f); break;
				case 35 : Hassei(13, 5.7f); break;
				case 36 : Hassei(13, 5.7f); break;
				case 37 : Hassei(13, 5.7f); break;
				case 38 : Hassei(13, 5.7f); break;
				case 39 : Hassei(13, 5.7f); break;
				

				//�H 42�b�`47�b
				case 42 : Hassei( 8, 1.0f); break;
				case 43 : Hassei( 9, 1.0f); break;
				case 44 : Hassei( 10, 1.3f); break;
				case 45 : Hassei( 8, 1.0f); break;
				case 46 : Hassei( 9, 1.0f); break;
				case 47 : Hassei( 10,1.3f); break;

				//�~ 50�`69�b
				
				case 50 : Hassei( 11, 1.0f); break;
				case 53 : Hassei( 11, 1.0f); break;
				case 56 : Hassei( 11, 1.0f); break;
				case 59 : Hassei( 11, 1.0f); break;
				
				//�N���@60�b�`80�b

				//��̃W�F�l���[�^�i30�b�~��j
				case 60 : Hassei( 24, 0.0f); break;
				//�Ⴞ���
				case 63 : Hassei( 14, 2.0f); break;
				case 68 : Hassei( 14, 2.0f); break;
				case 73 : Hassei( 14, 2.0f); break;
				//�T���^�N���[�X
				case 75 : Hassei( 16, 0.0f); break;
				//�񕜃A�C�e���@Hyuuganatu�@��16�b���ݒu
				case 16 : Hassei( 15, 0.5f); break;
				case 32 : Hassei( 15, 0.5f); break;
				case 48 : Hassei( 15, 0.5f); break;
				case 64 : Hassei( 15, 0.5f); break;
				case 80 : Hassei( 15, 0.5f); break;





				default :	break;
			}

			//�f�o�b�O
			uiDebug.GetComponent<Text>().text = "" + (secondCounter % 80);

			//�b��i�߂�
			secondCounter++;
		}

		//�^�C�}�[
		tickCounter += Time.deltaTime;
	}
}
