using UnityEngine;
using System.Collections;

public class Gallao : Entidade, IRodada {

	/* Baseado na Rev. 3 da documentação:
	 * O Prof. Gallão deve entrar na faculdade (Fatec.cs) para resgatar as provas (Prova.cs)
	 * e para isso, se for preciso, matar o Monstro DP (MonstroDP.cs).
	 * Prof. Gallão começa na posição [1,1], orientado à direita
	 * Prof. Gallão será perseguido pelo Monstro DP
	 * Prof. Gallão pode resgatar as provas
	 * Prof. Gallão pode atingir o Monstro DP com seu Livro de Inteligência Artificial
	 * Prof. Gallão pode escorregar nas salas que tem poças d'Água, e assim, permanecendo inativo por uma rodada
	 * Prof. Gallão pode se movimentar para frente
	 * Prof. Gallão pode se movimentar para esquerda ou direita em 90 graus.
	 * Prof. Gallão pode AGARRAR, para levantar um objeto que esteja na mesma sala que o Prof. Gallão.
	 * Prof. Gallão pode ATIRAR em linha reta para disparar o livro de Inteligência Artificial. O livro só para quando encontrar uma parede ou o Monstro DP.
	 */

	/* Performance:
	 * Resgatar as provas: 1000
	 * Cair na Poça d'Água: -100
	 * Ser devorado pelo Monstro DP: -1000
	 * Cada ação executada: -1
	 * Uso do livro de Inteligência Artificial: 10
	 */

	/* Percebe:
	 * Som de Grunhido: nas salas diretamente adjacentes ao Monstro DP (não em diagonal)
	 * Som de Goteira: nas salas diretamente adjacentes às Poças d'Água (não em diagonal)
	 * Som de Papel ao Vento: que vem da sala onde está o monte de Provas <- ?
	 * Impacto: quando existe uma parede a sua frente
	 * Morte do Monstro DP: de qualquer lugar
	 * 
	 * [Grunhido, Goteira, Provas, Parede, DP Morto]
	 */
	
	public Direction direction = Direction.down;
	public int myScore = 0;
	public int score{
		get{
			return myScore;
		}
		set{
			myScore = value;
			Buttons.updateScore();
		}
	}

	public void Rodada(){
	}

	public void action_turnLeft(){
		direction -= 1;
		if((int)direction < 0) direction = Gallao.Direction.right;
		--score;
	}
		
	public void action_turnRight(){
		direction += 1;
		if((int)direction > 3) direction = Gallao.Direction.down;
		--score;
	}

	public enum Direction{
		down,
		left,
		up,
		right
	}
}
