using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateMap : MonoBehaviour
{

		//==========GAME OBJECT
		public List<GameObject> tileMap;

		//==========IMAGES
		List<Sprite> imageList = new List<Sprite> ();
		
		//==========OBJECTS
		public static List<Entidade> entities = new List<Entidade>();

		//==========PREFABS
		public GameObject tilePrefab;
		public GameObject wumpusPrefab;
		public GameObject testPrefab;
		public GameObject waterPrefab;
		public int waterQuantity = 1;

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
		entities.Add(((GameObject)Instantiate (wumpusPrefab, new Vector3 (Random.Range (1, mapSize), Random.Range (1, mapSize), 0f), Quaternion.Euler(new Vector3(0,0,0)))).GetComponent<Wumpus>());

		entities.Add(((GameObject)Instantiate (testPrefab, new Vector3 (Random.Range (1, mapSize), Random.Range (1, mapSize), 0f), Quaternion.Euler(new Vector3(0,0,0)))).GetComponent<Test>());

		for(int i = 0; i < waterQuantity; ++i)
			entities.Add(((GameObject)Instantiate (waterPrefab, new Vector3 (Random.Range (1, mapSize), Random.Range (1, mapSize), 0f), Quaternion.Euler(new Vector3(0,0,0)))).GetComponent<Water>());

	}

		
}
