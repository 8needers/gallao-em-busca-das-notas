using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Image))]
public class FadeInUIImage : MonoBehaviour {
	
	public float tempoDeFade;
	
	void OnEnable () {
		this.GetComponent<Image>().CrossFadeAlpha(1, tempoDeFade, true);
	}
}