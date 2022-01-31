using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
	//�_�̃v���n�u�i�傫�����Ⴄ�O��ށj
	public GameObject prefabCloud_L;
	public GameObject prefabCloud_M;
	public GameObject prefabCloud_S;

	//�`�b�N
	private float tickCounter = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�`�b�N
		if( tickCounter >= 10.0f)
		{
			//�^�C�}�[�i�����_���ŐU��j
			tickCounter -= Random.Range( 3.0f, 10.0f);

			//�_�𐶐�����
			switch( Random.Range(0, 3) ) {
				case 0: Instantiate( prefabCloud_L, new Vector3( 10f, Random.Range( 0.0f, 3.0f), 0f), Quaternion.identity); break;
				case 1: Instantiate( prefabCloud_M, new Vector3( 10f, Random.Range( 0.0f, 3.0f), 0f), Quaternion.identity); break;
				case 2: Instantiate( prefabCloud_S, new Vector3( 10f, Random.Range( 0.0f, 3.0f), 0f), Quaternion.identity); break;

				default: break;
			}
		}

		//�^�C�}�[
		tickCounter += Time.deltaTime;
    }
}
