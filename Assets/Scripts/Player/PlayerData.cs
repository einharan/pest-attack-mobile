using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData 
{
    public static int AvailableGrids = 0;
    public static int LifePoint = 3;
    public static int CurrentTaelPoint = 100;
    //private static int CurrentStarPoint = 0;
    public static int SelectedStage = 1;

    public static void UponRestart()
    {
        LifePoint = 3;
        CurrentTaelPoint = 0;
    }
}
