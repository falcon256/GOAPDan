using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plan {
    private List<Action> actions = null;

    public Plan()
    {
        actions = new List<Action>();
    }

    public Action getCurrentAction()
    {
        if (actions.Count > 0)
            return actions[0];
        return null;
    }

    public void addActionToTop(Action a)
    {
        actions.Insert(0, a);
    }

    public void addActionToBottom(Action a)
    {
        actions.Insert(actions.Count-1, a);
    }
}
