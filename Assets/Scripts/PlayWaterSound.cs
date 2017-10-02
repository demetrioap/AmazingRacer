using UnityEngine;
using System.Collections;

public class PlayWaterSound : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		audio.Play(44100);

	}
}