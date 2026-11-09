using UnityEngine;
[Serializable]
public class ModulesSetGadgetsStorage.ModuleGadgetRecord
{
    // Fields
    public string gadgetID;
    public System.Collections.Generic.List<string> gadgetUps;
    public string nameLocalizationKey;
    public string descriptionLocalizationKey;
    public System.Collections.Generic.List<ModulesSetGadgetsStorage.GadgetProperty> properties;
    public ModulesSetGadgetsStorage.GadgetModuleType type;
    public UnityEngine.Texture icon;
    public UnityEngine.AudioClip soundOnUse;
    
    // Properties
    public UnityEngine.AudioClip SoundOnUse { get; }
    
    // Methods
    public UnityEngine.AudioClip get_SoundOnUse()
    {
        if(this.soundOnUse != 0)
        {
                return (UnityEngine.AudioClip)mem[val_2.defaultSoundOnUseGadget];
        }
        
        ModulesSetGadgetsStorage val_2 = ModulesSetGadgetsStorage.Instance;
        this = val_2.defaultSoundOnUseGadget;
        return (UnityEngine.AudioClip)mem[val_2.defaultSoundOnUseGadget];
    }
    public ModulesSetGadgetsStorage.ModuleGadgetRecord()
    {
        this.gadgetUps = new System.Collections.Generic.List<System.String>();
    }

}
