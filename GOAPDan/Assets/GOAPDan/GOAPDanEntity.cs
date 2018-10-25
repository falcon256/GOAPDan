using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOAPDanEntity {

    private Plan currentPlan = null;
    private Action currentAction = null;
    private Goal currentGoal = null;
    private List<Goal> goals = null;
    private bool doReplanning = false;
    private List<WorldStateMemory> memories = null;
    private Planner myPlanner = null;

    public GOAPDanEntity()
    {

        currentPlan = null;
        currentAction = null;
        currentGoal = null;
        goals = new List<Goal>();
        doReplanning = true;
        memories = new List<WorldStateMemory>();
        myPlanner = new Planner();

    }



}
