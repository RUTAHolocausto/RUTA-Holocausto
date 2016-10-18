using UnityEngine;
using System.Collections;

public class ButtonsPress : MonoBehaviour {
    public static bool att = false, def = false, run = false;
    public void attButt()
    {
        Debug.Log("me tocaron!");
        att = true;
    }
    public void defButt()
    {
        Debug.Log("Me tocaste!");
        def = true;
    }
    public void runButt()
    {
        Debug.Log("Joto");
        run = true;
    }
}
