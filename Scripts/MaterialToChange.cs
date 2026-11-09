using UnityEngine;
[Serializable]
public class LobbyDayNightController.MaterialToChange
{
    // Fields
    public string description;
    public UnityEngine.Color[] cicleColors;
    public UnityEngine.Material[] materials;
    public float[] cicleLerp;
    public bool changecolor;
    public bool changeLM;
    public UnityEngine.Color currentColor;
    public float currentLerp;
    public UnityEngine.GameObject[] objectsToOnAtNight;
    public bool objectsIsActive;
    
    // Methods
    public LobbyDayNightController.MaterialToChange()
    {
        this.description = "description";
        this.cicleColors = new UnityEngine.Color[6];
        this.cicleLerp = new float[6];
    }

}
