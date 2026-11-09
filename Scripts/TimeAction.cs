using UnityEngine;
[Serializable]
public class TimeAction
{
    // Fields
    public double time;
    public string stateName;
    internal bool isPlayed;
    public bool SmoothTransition;
    public float maxTimeInTransition;
    internal bool isTransitionEnd;
    public UnityEngine.Events.UnityEvent onTimeRemaning;
    public UnityEngine.Events.UnityEvent onActive;
    public UnityEngine.Events.UnityEvent onDisable;
    
    // Methods
    public TimeAction()
    {
    
    }

}
