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
        Master.queue[Master.iterador] = 1;
    }
    public void attack2()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = 2;
    }
    public void attack3()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = 3;
    }
    public void attack4()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = 4;
    }
    public void attack5()
    {
        state = "Targetting";
        Master.queue[Master.iterador] = 5;
    }
    public void changeSide()
    {
        state = "Change Side";
    }
    public void select()
    {
        GameObject.Find("Master").GetComponent<Master>().target[Master.iterador] = gameObject.GetComponentInParent<Transform>().gameObject;
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
