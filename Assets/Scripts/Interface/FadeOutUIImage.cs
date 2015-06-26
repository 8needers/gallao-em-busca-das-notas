using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeOutUIImage : MonoBehaviour {

	public float tempoAntesDoFade, tempoDeFade;

	void Start () {
		StartCoroutine(DelayedStart());
	}

	IEnumerator DelayedStart(){
		yield return new WaitForSeconds(tempoAntesDoFade);
		this.GetComponent<Image>().CrossFadeAlpha(0, tempoDeFade, true);
		StartCoroutine(DisableGameObject());
	}

	IEnumerator DisableGameObject(){
		yield return new WaitForSeconds(tempoDeFade);
		this.gameObject.SetActive(false);
	}

}
