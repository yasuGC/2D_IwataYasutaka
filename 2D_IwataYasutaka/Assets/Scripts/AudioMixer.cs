using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMixer : MonoBehaviour
{
	// �~�L�T�[
	public UnityEngine.Audio.AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
		//�w��̓f�V�x���idB�j�Ȃ̂Œ��� 0.0�`1.0�͎g���Ȃ�
		//0.0�Ȃ�-80.0f�A����ȏ�Ȃ�10.0f * Mathf.Log���g�p����B

		//mixer.SetFloat( "MusicVolume", 10.0f * Mathf.Log( 1.0));
        //mixer.SetFloat( "MusicVolume", -80.0f);

		//mixer.SetFloat( "SoundVolume", 10.0f * Mathf.Log( 1.0));
        //mixer.SetFloat( "SoundVolume", -80.0f);
		
		//mixer.SetFloat( "VoiceVolume", 10.0f * Mathf.Log( 1.0));
        //mixer.SetFloat( "VoiceVolume", -80.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
