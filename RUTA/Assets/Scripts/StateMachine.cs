using UnityEngine;
using System.Collections;

public class StateMachine : MonoBehaviour
{
    public static int battleState = 0;
    public enum battleStates
    {
        mainMenu,
        attackMenu,
        defenseMenu,
        run,
        target,
        confirm,
        enemy,
        drops,
        end,
        fail
    };

}