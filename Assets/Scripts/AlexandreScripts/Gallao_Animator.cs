using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Gallao))]
public class Gallao_Animator : MonoBehaviour {
	/*
	 * Gerencia as animaçoes do Gallao
	 */

	Animator animator;
	Gallao gallao;

	void Awake(){
		animator = GetComponent<Animator>();
		gallao = GetComponent<Gallao>();
	}

	void Update(){
		updateAnimationFlags();
	}

	void updateAnimationFlags(){
		animator.SetInteger("Direction",(int)gallao.direction);
	}
}
