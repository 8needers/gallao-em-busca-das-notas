using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Buttons : MonoBehaviour {
	/*
	 * Gerencia as açoes dos botoes da interface de usuario
	 */

	Gallao myGallao;
	public Gallao gallao{
		get{
			if(myGallao == null) myGallao = FindObjectOfType<Gallao>();
			return myGallao;
		}
	}

	public Text scoreText;
	public static Buttons self;

	void Awake(){
		self = this;
	}

	public void turnAntiClockWise(){
		gallao.action_turnLeft();
	}

	public void turnClockWise(){
		gallao.action_turnRight();
	}

	public void walkForward(){
		gallao.action_walk();
	}

	public static void updateScore(){
		self.scoreText.text = "Pontos: " + self.gallao.score.ToString();
	}

}
