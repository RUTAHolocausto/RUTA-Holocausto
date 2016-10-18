using UnityEngine;
using System.Collections;

public class Master : MonoBehaviour {
    public GameObject mainMenuC, attackMenuC, defenseMenuC, runMenuC, targetMenuC, confirmMenuC, dropMenuC, endMenuC, failMenuC;

	// Use this for initialization
	void Start () {
        StateMachine.battleState = (int)StateMachine.battleStates.mainMenu;
	}
	
	// Update is called once per frame
	void Update () {
        if (StateMachine.battleState == (int)StateMachine.battleStates.mainMenu)
        {
            Debug.Log("Main Menu");
            mainMenuC.SetActive(true);
            if (ButtonsPress.att == true)
            {
                ButtonsPress.att = false;
                StateMachine.battleState = (int)StateMachine.battleStates.attackMenu;
            }
            else if (ButtonsPress.def == true)
            {
                ButtonsPress.def = false;
                StateMachine.battleState = (int)StateMachine.battleStates.defenseMenu;
            }
            else if (ButtonsPress.run == true)
            {
                ButtonsPress.run = false;
                StateMachine.battleState = (int)StateMachine.battleStates.run;
            }
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.attackMenu)
        {
            Debug.Log("ataquini");
            mainMenuC.SetActive(false);
            attackMenuC.SetActive(true);
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.defenseMenu)
        {
            Debug.Log("defensini");
            mainMenuC.SetActive(false);
            defenseMenuC.SetActive(true);
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.run)
        {
            Debug.Log("jotini");
            mainMenuC.SetActive(false);
            runMenuC.SetActive(true);
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.target)
        {

        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.confirm)
        {

        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.enemy)
        {

        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.drops)
        {

        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.end)
        {

        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.fail)
        {

        }
    }

}
