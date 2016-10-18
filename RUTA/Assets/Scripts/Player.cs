using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int hp;
    public int ap;
    public int attack;
    public int defense;
    
    public static int apPub;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        apPub = ap;
	}
}
