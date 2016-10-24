using UnityEngine;
using System.Collections;

public class ButtonsPress : MonoBehaviour {
    public static string state;
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
}
