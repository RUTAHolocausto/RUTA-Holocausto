using UnityEngine;
using System.Collections;

public class attacks : MonoBehaviour {
    public int attackNumber;
    public string attackName;
    public int attackStrength;
    public int attackCost;
    public string attrib;
    GameObject jugador;
	// Use this for initialization
	void Start () {
        jugador = GameObject.FindGameObjectWithTag("Player");

    if (attackNumber == 0)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "Meele";
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
