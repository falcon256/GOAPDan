using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal {

    private string conditionToModify { get; set; }
    private float amountToModify { get; set; }
    private float goalPriority { get; set; }

    public Goal(string cond, float change, float prior)
    {
        conditionToModify = cond;
        amountToModify = change;
        goalPriority = prior;
    }

}
