using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using UnityEngine.Events;
public class Master : MonoBehaviour {
    public GameObject mainMenuC, attackMenuC, defenseMenuC, runMenuC,
        targetMenuC, confirmMenuC, dropMenuC, endMenuC, failMenuC,
        cam, side1, side2, player, attackButt1, attackButt2,
        attackButt3, attackButt4, attackButt5;
    static public int iterador = 0, enemyNum = 0;
    static public int[] queue;
    bool camc;
    public GameObject[] target;
    Vector3 camPosOrig;
    Quaternion camRotOrig;
    // Use this for initialization
    void Start() {
        StateMachine.battleState = (int)StateMachine.battleStates.mainMenu;
        camPosOrig = cam.transform.position;
        camRotOrig = cam.transform.rotation;
        queue = new int[player.GetComponent<Player>().apBase];
        target = new GameObject[player.GetComponent<Player>().apBase];
        attackButt1.GetComponentInChildren<Text>().text = player.GetComponent<Player>().part1.GetComponent<Attacks>().attackName;
        attackButt2.GetComponentInChildren<Text>().text = player.GetComponent<Player>().part2.GetComponent<Attacks>().attackName;
        attackButt3.GetComponentInChildren<Text>().text = player.GetComponent<Player>().part3.GetComponent<Attacks>().attackName;
        attackButt4.GetComponentInChildren<Text>().text = player.GetComponent<Player>().part4.GetComponent<Attacks>().attackName;
        attackButt5.GetComponentInChildren<Text>().text = player.GetComponent<Player>().part5.GetComponent<Attacks>().attackName;
    }

    // Update is called once per frame
    void Update () {
        if (StateMachine.battleState == (int)StateMachine.battleStates.mainMenu)
        {
            mainMenuC.SetActive(true);
            for(int i = 0; i < player.GetComponent<Player>().apBase; i++)
            {
                queue[i] = 0;
            }
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
            
            if(!player.GetComponent<Player>().part1.activeInHierarchy)
            {
                attackButt1.SetActive(false);
            }
            if (!player.GetComponent<Player>().part2.activeInHierarchy)
            {
                attackButt2.SetActive(false);
            }
            if (!player.GetComponent<Player>().part3.activeInHierarchy)
            {
                attackButt3.SetActive(false);
            }
            if (!player.GetComponent<Player>().part4.activeInHierarchy)
            {
                attackButt4.SetActive(false);
            }
            if (!player.GetComponent<Player>().part5.activeInHierarchy)
            {
                attackButt5.SetActive(false);
            }
            if (ButtonsPress.state == "Targetting")
            {
                ButtonsPress.state = "0";
                Player.ap -= ButtonsPress.attackAp;
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
                iterador++;
                ButtonsPress.state = "0";
                if (Player.ap >= 0)
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
                Player.ap += ButtonsPress.attackAp;
                confirmMenuC.SetActive(false);
                StateMachine.battleState = (int)StateMachine.battleStates.attackMenu;
            }
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.execution)
        {
            attackExe();
            if (enemyNum == 0)
                StateMachine.battleState = (int)StateMachine.battleStates.enemy;
            else
                StateMachine.battleState = (int)StateMachine.battleStates.endStatus;
            iterador = 0;
        }
        else if (StateMachine.battleState == (int)StateMachine.battleStates.enemy)
        {
            //enemigo IA y ejecuta ataques
            if (Player.hp <= 0)
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


    void attackExe()
    {
        int j = 0;
        foreach (int i in queue)
        {
            switch (i)
            {
                //Checar si la animacion termino y regresar el integer a 0
                case 1:
                    player.GetComponent<Animator>().SetInteger("State", player.GetComponent<Player>().part1.GetComponent<Attacks>().attackAnim);
                    break;
                case 2:
                    player.GetComponent<Animator>().SetInteger("State", player.GetComponent<Player>().part2.GetComponent<Attacks>().attackAnim);
                    break;
                case 3:
                    player.GetComponent<Animator>().SetInteger("State", player.GetComponent<Player>().part3.GetComponent<Attacks>().attackAnim);
                    break;
                case 4:
                    player.GetComponent<Animator>().SetInteger("State", player.GetComponent<Player>().part4.GetComponent<Attacks>().attackAnim);
                    break;
                case 5:
                    player.GetComponent<Animator>().SetInteger("State", player.GetComponent<Player>().part5.GetComponent<Attacks>().attackAnim);
                    break;
            }
            if (target[j].GetComponent<Enemy>().hp <= 0)
            {
                Destroy(target[j]);
                enemyNum--;
            }
            j++;
        }
    }
    void damageResolution(Attacks part)
    {
        //añadir formula de daño para ejecución.
    }
}
