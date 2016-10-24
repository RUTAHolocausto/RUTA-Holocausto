using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Master : MonoBehaviour {
    public GameObject mainMenuC, attackMenuC, defenseMenuC, runMenuC,
        targetMenuC, confirmMenuC, dropMenuC, endMenuC, failMenuC,
        cam, enemy1, enemy2, enemy3, enemySelect;
    static public int enemyNum;
    Vector3 enemyTarget;
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
            switch (ButtonsPress.state)
            {
                case "Attack phase":
                    {
                        ButtonsPress.state = "0";
                        StateMachine.battleState = (int)StateMachine.battleStates.attackMenu;
                        mainMenuC.SetActive(false);
                        break;
                    }
                case "Fase de Defensa":
                    {
                        ButtonsPress.state = "0";
                        StateMachine.battleState = (int)StateMachine.battleStates.defenseMenu;
                        mainMenuC.SetActive(false);
                        break;
                    }
                case "Run phase":
                    {
                        ButtonsPress.state = "0";
                        StateMachine.battleState = (int)StateMachine.battleStates.run;
                        mainMenuC.SetActive(false);
                        break;
                    }
            }
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.attackMenu)
        {
            attackMenuC.SetActive(true);
            if(ButtonsPress.state == "Targetting")
            {
                ButtonsPress.state = "0";
                StateMachine.battleState = (int)StateMachine.battleStates.target;
                attackMenuC.SetActive(false);
            }
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.defenseMenu)
        {
            defenseMenuC.SetActive(true);
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.run)
        {
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
