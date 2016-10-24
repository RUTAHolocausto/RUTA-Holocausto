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

    public void attack(int x)
    {
        state = "Targetting";
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
