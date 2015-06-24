using UnityEngine;
using System.Collections;

public class UserInterfaceActions : MonoBehaviour {
	// É meio perda de tempo ficar montando várias classes pra fazer uma interface tão simples/descartável, acho melhor concentrar tudo aqui

	#region Ações dos botões do menu principal
	/// <summary>
	/// Abre a cena do jogo
	/// </summary>
	public void Jogar(){}

	/// <summary>
	/// Fecha o menu principal e abre o menu de configurações
	/// </summary>
	public void AbrirMenuDeConfiguracoes(){}

	/// <summary>
	/// Fecha o menu principal e abre a tela de créditos
	/// </summary>
	public void AbrirMenuDeCreditos(){}
	#endregion 

	#region Ações dos botões do menu de configurações
	/// <summary>
	/// Fecha o menu de configurações e volta ao menu principal
	/// </summary>
	public void VoltarAoMenuPrincipal(){}
	#endregion
	
}
