﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planner
{
  
    public Plan searchForNewPlan(List<WorldStateMemory> memories, Goal goal)
    {
        if(goal==null||memories==null)
            return null;
        List<Action> possibleEndActions = GOAPDan.getSingleton().getActionsByEffect(goal.getConditionToModify());
        List<Plan> plansPerEndActions = new List<Plan>();
        for (int i = 0; i < possibleEndActions.Count; i++)
        {

        }




        return null;//just to make it compile for now.
    }
	
}
