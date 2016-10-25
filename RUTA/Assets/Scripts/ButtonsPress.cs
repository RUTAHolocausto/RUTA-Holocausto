using UnityEngine;
using System.Collections;

public class ButtonsPress : MonoBehaviour {
    public static string state;
    public static int attackAp;
    public void attButt()
    {
        state = "Attack phase";
    }
    public void defButt()
    {
        state = "Defense phase";
    }
    public void runButt()
    {
        state = "Run phase";
    }

    public void attack()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = GameObject.FindGameObjectWithTag("Piece1").GetComponent<attacks>().attackNumber;
        Master.iterador++;
    }
    public void attack2()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = GameObject.FindGameObjectWithTag("Piece2").GetComponent<attacks>().attackNumber;
        Master.iterador++;
    }
    public void attack3()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = GameObject.FindGameObjectWithTag("Piece3").GetComponent<attacks>().attackNumber;
        Master.iterador++;
    }
    public void attack4()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = GameObject.FindGameObjectWithTag("Piece4").GetComponent<attacks>().attackNumber;
        Master.iterador++;
    }
    public void attack5()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = GameObject.FindGameObjectWithTag("Piece5").GetComponent<attacks>().attackNumber;
        Master.iterador++;
    }
    public void changeSide()
    {
        state = "Change Side";
    }
    public void select()
    {
        state = "Selected";
    }
    public void confirm()
    {
        state = "Confirmed";
    }
    public void goBack()
    {
        state = "Go back";
    }
    
}
