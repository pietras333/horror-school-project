using UnityEngine;
using System.Collections;
using EZCameraShake;

public class HeadShake : MonoBehaviour
{
	[Header("Head Shake")]
	[Space]
	[Header("Neccesary")]
	[Space]
	[SerializeField] Rigidbody playerRb;
	[Space]
	[Header("Customizable")]
	[SerializeField] float magnitude;

	void Update(){
		CameraShaker.Instance.ShakeOnce(0.1f * playerRb.velocity.magnitude / magnitude, 0.35f * playerRb.velocity.magnitude / magnitude, 0.75f, 1f);
	}
}