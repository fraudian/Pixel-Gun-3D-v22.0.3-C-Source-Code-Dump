using UnityEngine;
internal class KillChatIconsStorage : MonoBehaviour
{
    // Fields
    internal static KillChatIconsStorage 丄丘七三上丕世丞业;
    private static readonly string 万丌丙东丝丂丈丄三;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Texture> 丑丟丂丂丏丝丆一一;
    private System.Text.StringBuilder 专丁下七丞丂丏下丕;
    
    // Methods
    private void Awake()
    {
        null = null;
        KillChatIconsStorage.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        null = null;
        KillChatIconsStorage.丄丘七三上丕世丞业 = 0;
    }
    internal UnityEngine.Texture 丗丄丂且丑丑东万丝(string 丛丐丌丙丈七丛丛东)
    {
        string val_8;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture> val_9;
        var val_10;
        val_8 = 丛丐丌丙丈七丛丛东;
        if((val_8.Contains(value:  "pet_")) != false)
        {
                val_8 = val_8.Replace(oldValue:  "_up0", newValue:  "");
        }
        
        val_9 = this.丑丟丂丂丏丝丆一一;
        if((val_9.TryGetValue(key:  val_8, value: out  0)) == true)
        {
                return val_9;
        }
        
        this.专丁下七丞丂丏下丕.Length = 0;
        val_10 = null;
        val_10 = null;
        System.Text.StringBuilder val_5 = this.专丁下七丞丂丏下丕.Append(value:  KillChatIconsStorage.万丌丙东丝丂丈丄三);
        System.Text.StringBuilder val_6 = this.专丁下七丞丂丏下丕.Append(value:  val_8);
        val_9 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  this.专丁下七丞丂丏下丕);
        this.丑丟丂丂丏丝丆一一.set_Item(key:  val_8, value:  val_9);
        return val_9;
    }
    public KillChatIconsStorage()
    {
        this.丑丟丂丂丏丝丆一一 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture>();
        this.专丁下七丞丂丏下丕 = new System.Text.StringBuilder(capacity:  50);
    }
    private static KillChatIconsStorage()
    {
        KillChatIconsStorage.丄丘七三上丕世丞业 = 0;
        KillChatIconsStorage.万丌丙东丝丂丈丄三 = "WeaponChatIcons/";
    }

}
