using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMAnager : MonoBehaviour {

    public AudioSource EfxSource;
    public AudioSource musicSource;
    public static AudioMAnager instance = null;
    public float lowPitchRange = .95f;
    public float highPitchRange = 1.05f;


	void Start () {

        if (instance == null)
            instance = this;
        else if (instance != this)
        {
            // Destroy(gameObject);
            //DontDestroyOnLoad(gameObject);
           instance = this;

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playSingle(AudioClip clip)
    {
        EfxSource.clip = clip;

        EfxSource.Play();
    }


    public void RandomizeSfx(params AudioClip[] clips)
    {
        int randomIndex = Random.Range(0, clips.Length);

        float randompitch = Random.Range(lowPitchRange, highPitchRange);

        EfxSource.pitch = randompitch;

        EfxSource.clip = clips[randomIndex];

        EfxSource.Play();
    }
}
