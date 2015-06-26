using UnityEngine;
using System.Collections;

public class UserInterfaceActions : MonoBehaviour {
	// É meio perda de tempo ficar montando várias classes pra fazer uma interface tão simples/descartável, acho melhor concentrar tudo aqui

	public GameObject principal, creditos, botaoSomHabilitado, botaoSomDesabilitado;
	bool audioHabilitado = true;

	#region Ações dos botões do menu principal
	/// <summary>
	/// Abre a cena do jogo
	/// </summary>
	public void Jogar(){ Application.LoadLevel ("mainScene"); }

	/// <summary>
	/// Fecha o menu principal e abre a tela de créditos
	/// </summary>
	public void AbrirMenuDeCreditos(){
		creditos.SetActive(true); 
		principal.SetActive(false);
	}

	public void AlternarSom(){
		if (audioHabilitado) {
			DesativarSom();
		} else {
			AtivarSom();
		}
	}
	
	void DesativarSom(){
		AudioListener.volume = 0;
		audioHabilitado = false;
		botaoSomHabilitado.SetActive(false);
		botaoSomDesabilitado.SetActive(true);
		PlayerPrefs.SetInt("som", 0);
	}
	
	void AtivarSom(){
		AudioListener.volume = 1;
		audioHabilitado = true;
		botaoSomHabilitado.SetActive(true);
		botaoSomDesabilitado.SetActive(false);
		PlayerPrefs.SetInt("som", 1);
	}

	#endregion 

	#region Ações dos botões do menu de configurações
	/// <summary>
	/// Fecha o menu de configurações e volta ao menu principal
	/// </summary>
	public void VoltarAoMenuPrincipal(){ 
		creditos.SetActive(false); 
		principal.SetActive(true); 
	}
	#endregion
	
}
