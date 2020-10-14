using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
	/*
	faire une classe son qui permettrait d'ajouter des variable : volume default, nom
	
	*/

	[SerializeField] private AudioClip[] audioClips;
	private AudioSource audioSource;

	// Start is called before the first frame update
	void Awake()
	{
		if(GetComponent<AudioSource>())
        {
			audioSource = GetComponent<AudioSource>();
        }
	}

	// Update is called once per frame
	void Update()
	{
	}

	public void PlayClip(int i)
	{
		AudioSource.PlayClipAtPoint(audioClips[i], transform.position);
	}

	public void PlayClip(int i, float volume)
	{
		audioSource.PlayOneShot(audioClips[i], volume);
	}
}