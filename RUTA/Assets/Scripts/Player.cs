﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

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
    public GameObject part1, part2, part3, part4, part5;
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
