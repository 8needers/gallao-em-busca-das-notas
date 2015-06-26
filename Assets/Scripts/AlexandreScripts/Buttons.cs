using UnityEngine;
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

	public void turnAntiClockWise(){
		gallao.direction -= 1;
		if((int)gallao.direction < 0) gallao.direction = Gallao.Direction.right;
	}

	public void turnClockWise(){
		gallao.direction += 1;
		if((int)gallao.direction > 3) gallao.direction = Gallao.Direction.down;
		
	}


}
