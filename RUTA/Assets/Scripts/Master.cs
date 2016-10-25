using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using UnityEngine.Events;
public class Master : MonoBehaviour {
    public GameObject mainMenuC, attackMenuC, defenseMenuC, runMenuC,
        targetMenuC, confirmMenuC, dropMenuC, endMenuC, failMenuC,
        cam, side1, side2, player, attackButt1, attackButt2,
        attackButt3, attackButt4, attackButt5;
    static public int iterador = 0;
    static public int[] queue;
    bool camc;
    
    Vector3 camPosOrig;
    Quaternion camRotOrig;
    // Use this for initialization
    void Start() {
        StateMachine.battleState = (int)StateMachine.battleStates.mainMenu;
        camPosOrig = cam.transform.position;
        camRotOrig = cam.transform.rotation;
        queue = new int[player.GetComponent<Player>().apBase];
        attackButt1.GetComponentInChildren<GUIText>().text = player.GetComponent<Player>().parte1.GetComponent<attacks>().attackName;
        //attackButt1.GetComponent<Button>().onClick.
        //attackButt2.GetComponentInChildren<GUIText>().text = player.GetComponent<Player>().parte2.GetComponent<attacks>().attackName;
        //attackButt3.GetComponentInChildren<GUIText>().text = player.GetComponent<Player>().parte3.GetComponent<attacks>().attackName;
        //attackButt4.GetComponentInChildren<GUIText>().text = player.GetComponent<Player>().parte4.GetComponent<attacks>().attackName;
        //attackButt5.GetComponentInChildren<GUIText>().text = player.GetComponent<Player>().parte5.GetComponent<attacks>().attackName;
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
                        mainMenuC.SetActive(false);
                        StateMachine.battleState = (int)StateMachine.battleStates.attackMenu;
                        break;
                    }
                case "Fase de Defensa":
                    {
                        ButtonsPress.state = "0";
                        mainMenuC.SetActive(false);
                        StateMachine.battleState = (int)StateMachine.battleStates.defenseMenu;
                        break;
                    }
                case "Run phase":
                    {
                        ButtonsPress.state = "0";
                        mainMenuC.SetActive(false);
                        StateMachine.battleState = (int)StateMachine.battleStates.run;
                        break;
                    }
            }
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.attackMenu)
        {
            attackMenuC.SetActive(true);
            camc = false;
            cam.transform.position = camPosOrig;
            cam.transform.rotation = camRotOrig;
            
            
            if(ButtonsPress.state == "Targetting")
            {
                ButtonsPress.state = "0";
                player.GetComponent<Player>().ap -= ButtonsPress.attackAp;
                attackMenuC.SetActive(false);
                StateMachine.battleState = (int)StateMachine.battleStates.target;
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
            targetMenuC.SetActive(true);
            if(camc == false)
            {
                cam.transform.position = side1.transform.position;
                cam.transform.rotation = side1.transform.rotation;
                camc = true;
            }

            if (ButtonsPress.state == "Change Side")
            {
                ButtonsPress.state = "0";
                if (cam.transform.position == side1.transform.position)
                {
                    ButtonsPress.state = "0";
                    cam.transform.position = side2.transform.position;
                    cam.transform.rotation = side2.transform.rotation;
                }
                else if (cam.transform.position == side2.transform.position)
                {
                    ButtonsPress.state = "0";
                    cam.transform.position = side1.transform.position;
                    cam.transform.rotation = side1.transform.rotation;
                }
            }
            if(ButtonsPress.state == "Selected")
            {
                ButtonsPress.state = "0";
                targetMenuC.SetActive(false);
                StateMachine.battleState = (int)StateMachine.battleStates.confirm;
            }
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.confirm)
        {
            confirmMenuC.SetActive(true);
            if (ButtonsPress.state == "Confirmed")
            {
                ButtonsPress.state = "0";
                if (player.GetComponent<Player>().ap >= 0)
                {
                    confirmMenuC.SetActive(false);
                    StateMachine.battleState = (int)StateMachine.battleStates.attackMenu;
                }
                else
                {
                    confirmMenuC.SetActive(false);
                    StateMachine.battleState = (int)StateMachine.battleStates.execution;
                }
            }
            else if(ButtonsPress.state =="Go back")
            {
                ButtonsPress.state = "0";
                player.GetComponent<Player>().ap += ButtonsPress.attackAp;
                confirmMenuC.SetActive(false);
                StateMachine.battleState = (int)StateMachine.battleStates.attackMenu;
            }
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.execution)
        {
            //ejecutar ataques
            //comprobar si el enemigo tiene vida
            StateMachine.battleState = (int)StateMachine.battleStates.enemy;
            //else
            StateMachine.battleState = (int)StateMachine.battleStates.endStatus;
            iterador = 0;
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.enemy)
        {
            //enemigo IA y ejecuta ataques
            if (player.GetComponent<Player>().hp <= 0)
                StateMachine.battleState = (int)StateMachine.battleStates.mainMenu;
            else
                StateMachine.battleState = (int)StateMachine.battleStates.fail;
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.drops)
        {
            //regresar a menu principal y seleccionar objetos
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.endStatus)
        {
            StateMachine.battleState = (int)StateMachine.battleStates.drops;
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.fail)
        {
            //regresar a menu principal
        }
    }

}
