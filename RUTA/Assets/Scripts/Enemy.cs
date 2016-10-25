using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    static public int hp;
    static public int ap;
    static public int attack;
    static public int defense;
    static public int weight;
    static public int rp;
    public int hpBase;
    public int apBase;
    public int attackBase;
    public int defenseBase;
    public int weightBase;
    public int rpBase;
    // Use this for initialization
    void Awake () {
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
