using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControler : MonoBehaviour {
    public enum SOUND
    {
        die, 
        ButtonClick,
        Scored,
    }
    // Use this for initialization
    public AudioClip SoundDie;
    public AudioClip SoundButtonClick;
    public AudioClip SoundScored;
    static private SoundControler instance;

    void Start () {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void PlaySound(SOUND currentSound)
    {
        if(currentSound==SOUND.ButtonClick)
        {
            instance.GetComponent<AudioSource>().PlayOneShot(instance.SoundDie);
        }

        if(currentSound==SOUND.die)
        {
            instance.GetComponent<AudioSource>().PlayOneShot(instance.SoundDie);
            instance.Invoke("PlaySoundDie", 0.8f);
        }
        if(currentSound==SOUND.Scored)
        {
            instance.GetComponent<AudioSource>().PlayOneShot(instance.SoundScored);
        }
    }
}
