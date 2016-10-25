using UnityEngine;
using System.Collections;

public class PieceProperties : MonoBehaviour {
    public int durability, hpExtra, apExtra, weightExtra;
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<Player>().hpBase += hpExtra;
        player.GetComponent<Player>().apBase += apExtra;
        player.GetComponent<Player>().weightBase += weightExtra;
    }
	
	// Update is called once per frame
	void Update () {
	    if(durability <= 0)
        {
            gameObject.SetActive(false);
        }
	}
}
