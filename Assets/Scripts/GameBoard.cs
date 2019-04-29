using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour {

    private static int boardWidth = 28;
    private static int boardHeight = 36;

    public int totalPellets = 0;
    public int score = 0;

    public GameObject[,] board = new GameObject[boardWidth, boardHeight];

	// Use this for initialization
	void Start () {

        Object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));

        foreach(GameObject obj in objects)
        {
            Vector2 pos = obj.transform.position;

            if(obj.name != "PacMan" && obj.name != "Nodes" && obj.name != "NonNodes" && obj.name != "Maze" && obj.name != "Pellets")
            {
                if (obj.GetComponent<Tile> () != null)
                {
                    if (obj.GetComponent<Tile> ().isPellet || obj.GetComponent<Tile> ().isSuperPellet)
                    {
                        totalPellets++;
                    }
                }
                board[(int)pos.x, (int)pos.y] = obj;
            }
            else
            {
                Debug.Log("Found PacMan at : " + pos); 
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
