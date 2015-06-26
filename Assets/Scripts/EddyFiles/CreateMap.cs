using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateMap : MonoBehaviour
{

		//==========GAME OBJECT
		public List<GameObject> tileMap;

		//==========IMAGES
		List<Sprite> imageList = new List<Sprite> ();

		//==========PREFABS
		public GameObject tilePrefab;
		public GameObject wumpusPrefab;
		public GameObject testPrefab;
		public GameObject waterPrefab;

		//==========VARIABLES
		/// <summary>
		/// Map Size: Size of Mapa in coordinates X,Y
		/// </summary>

		public int mapSize;

		// Use this for initialization
		void Start ()
		{
				SetMap ();
		}

		//======
		//CREATE THE MAP
		//======
		void SetMap ()
		{
				tileMap = new List<GameObject> ();
				for (int i = 0; i< mapSize; i++) {
						for (int j = 0; j< mapSize; j++) {
								tileMap.Add (Instantiate (tilePrefab, 
				                                new Vector3 (this.gameObject.transform.position.x + i, this.gameObject.transform.position.y + j, 0),
				                                Quaternion.identity) as GameObject);
						}
				}
		RandomizeElements ();
		}

	void RandomizeElements(){
		Wumpus mWumpus = new Wumpus ();
		mWumpus = ((GameObject)Instantiate (wumpusPrefab, new Vector3 (Random.Range (2, mapSize), Random.Range (2, mapSize), 0f), Quaternion.Euler(new Vector3(0,0,0)))).GetComponent<Wumpus>();

		Test mTest = new Test ();
		mTest = ((GameObject)Instantiate (testPrefab, new Vector3 (Random.Range (2, mapSize), Random.Range (2, mapSize), 0f), Quaternion.Euler(new Vector3(0,0,0)))).GetComponent<Test>();

		Water mWater = new Water ();
		mWater = ((GameObject)Instantiate (waterPrefab, new Vector3 (Random.Range (2, mapSize), Random.Range (2, mapSize), 0f), Quaternion.Euler(new Vector3(0,0,0)))).GetComponent<Water>();

	}

		
}
