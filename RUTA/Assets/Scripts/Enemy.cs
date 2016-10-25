using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
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
    // Use this for initialization
    void Awake () {
        Master.enemyNum++;
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
