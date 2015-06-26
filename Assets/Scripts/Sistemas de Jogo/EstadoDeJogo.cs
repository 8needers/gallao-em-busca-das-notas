using UnityEngine;
using System.Collections;

public class EstadoDeJogo : MonoBehaviour {

	[HideInInspector]
	public EstadoDeJogo sharedInstance;

	public GameObject menuVitoria, menuDerrota, menuTutorial;

	void Awake(){
		if(sharedInstance==null){
			sharedInstance = this;
		} else {
			GameObject.Destroy(gameObject);
		}
	}

	public void IniciaJogo(){
		menuTutorial.SetActive(false); //Sim.
	}

	public void ReiniciaJogo(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void VoltaParaPrincipal(){
		Application.LoadLevel("MenuPrincipal");
	}

	public void Derrota(){
		menuDerrota.SetActive(true); //Isso mesmo que você viu
	}

	public void Vitoria(){
		menuVitoria.SetActive(true); //Pois é, né
	}
}