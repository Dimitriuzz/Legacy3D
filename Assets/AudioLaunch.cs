using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLaunch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PlayAudio(AudioClip clip)
        {
            GetComponent<AudioSource> ().PlayOneShot(clip);
        }
}
