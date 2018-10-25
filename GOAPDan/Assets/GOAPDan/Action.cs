using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action
{

    protected string actionTitle = "Undefined";
    protected Dictionary<string, bool> preconditions = null;
    protected Dictionary<string, bool> effects = null;
    protected float maxDistance = 1.0f;
    protected GameObject thisActor = null;
    protected GameObject targetActor = null;

    public abstract void doPlanningReset();
    public abstract void isComplete();
    public abstract float getCost();
    public abstract float getReward();
    public abstract bool testPreconditions();
    public abstract void execute();

    public Action()
    {
        preconditions = new Dictionary<string, bool>();
        effects = new Dictionary<string, bool>();
    }

    public void addPrecondition(string condition, bool startState)
    {
        if(!preconditions.ContainsKey(condition))
        {
            preconditions.Add(condition, startState);
        }
        else
        {
            preconditions.Remove(condition);
            preconditions.Add(condition, startState);
        }
    }

    public void removePrecondition(string condition)
    {
        if (preconditions.ContainsKey(condition))
        {
            preconditions.Remove(condition);
        }
        else
        {
            Debug.Log(condition + " Not Contained in Action " + actionTitle + " Precondition List");
        }
    }

    public void addEffect(string effect, bool endState)
    {
        if (!effects.ContainsKey(effect))
        {
            effects.Add(effect, endState);
        }
        else
        {
            effects.Remove(effect);
            effects.Add(effect, endState);
        }
    }

    public void removeEffect(string effect)
    {
        if (effects.ContainsKey(effect))
        {
            effects.Remove(effect);
        }
        else
        {
            Debug.Log(effect + " Not Contained in Action " + actionTitle + " Effect List");
        }
    }
}
