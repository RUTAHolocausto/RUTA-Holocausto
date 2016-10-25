using UnityEngine;
using System.Collections;

public class Attacks : MonoBehaviour {
    public int attackNumber,attackStrength, attackCost, attackAnim;
    public string attackName, attrib;
    GameObject jugador;

    // Use this for initialization
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");

        if (attackNumber == 1)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
        else if (attackNumber == 2)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
        else if (attackNumber == 3)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
        else if (attackNumber == 4)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
        else if (attackNumber == 5)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
        else if (attackNumber == 6)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
        else if (attackNumber == 7)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
        else if (attackNumber == 8)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
        else if (attackNumber == 9)
        {
            attackName = "Meele";
            attackStrength = 30;
            attackCost = jugador.GetComponent<Player>().apBase;
            attrib = "M";
            attackAnim = 0;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
