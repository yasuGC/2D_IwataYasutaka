using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //n•b‚Å©ŒÈ”jŠü‚·‚é
		Destroy( this.gameObject, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
 		// ˆÚ“®‚·‚é ¦ƒtƒŒ[ƒ€”‚Ì©“®’²®‚Ìˆ×ATime.deltaTime‚ğŠ|‚¯‚Ä1•bŠÔ•Ó‚è‚ÌˆÚ“®‚É•ÏŠ·
		transform.Translate( 0f, 1.0f * Time.deltaTime, 0f);		        
    }
}
