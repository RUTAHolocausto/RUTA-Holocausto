using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int hp;
    public int ap;
    public int attack;
    public int defense;
    public int weight;
    public int rp;
    public int hpBase;
    public int apBase;
    public int attackBase;
    public int defenseBase;
    public int weightBase;
    public int rpBase;
    public GameObject parte1, parte2, parte3, parte4, parte5;
	// Use this for initialization
	void Start () {
        hp = hpBase;
        ap = apBase;
        attack = attackBase;
        defense = defenseBase;
        weight = weightBase;
        rp = rpBase;
        
    }
	
	// Update is called once per frame
	void Update () {

	}
}
