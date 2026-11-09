using UnityEngine;
public class RPG_Animation_CharacterFadeOnly : MonoBehaviour
{
    // Fields
    public static RPG_Animation_CharacterFadeOnly instance;
    
    // Methods
    private void Awake()
    {
        RPG_Animation_CharacterFadeOnly.instance = this;
    }
    public RPG_Animation_CharacterFadeOnly()
    {
    
    }

}
