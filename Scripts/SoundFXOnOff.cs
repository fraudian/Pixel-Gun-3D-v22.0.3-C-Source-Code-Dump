using UnityEngine;
public class SoundFXOnOff : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject 丂丒丁丛丅丗丌丞丄;
    private System.Collections.Generic.List<UnityEngine.GameObject> soundFXDynamicList;
    private bool 丂不不且丛世不万丐;
    
    // Methods
    private void Start()
    {
        var val_11;
        var val_13;
        bool val_1 = 东丗上丁下业一丂丂.丄丒丆丑东丏业丗下();
        this.丂不不且丛世不万丐 = val_1;
        if(val_1 != false)
        {
                if(UnityEngine.Application.isEditor == false)
        {
            goto label_4;
        }
        
        }
        
        this.丂丒丁丛丅丗丌丞丄 = this.transform.GetChild(index:  0).gameObject;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        this.丂丒丁丛丅丗丌丞丄.SetActive(value:  true);
        val_11 = null;
        val_11 = null;
        if((SoundFXOnOff.<>c.<>9__3_1) == null)
        {
            goto label_13;
        }
        
        label_24:
        this.soundFXDynamicList.ForEach(action:  SoundFXOnOff.<>c.<>9__3_1);
        return;
        label_4:
        val_13 = null;
        val_13 = null;
        if((SoundFXOnOff.<>c.<>9__3_0) == null)
        {
            goto label_17;
        }
        
        label_28:
        this.soundFXDynamicList.ForEach(action:  SoundFXOnOff.<>c.<>9__3_0);
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        return;
        label_13:
        SoundFXOnOff.<>c.<>9__3_1 = new System.Action<UnityEngine.GameObject>(object:  SoundFXOnOff.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SoundFXOnOff.<>c::丏不丆丝丙万专丌上(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this.soundFXDynamicList != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_17:
        SoundFXOnOff.<>c.<>9__3_0 = new System.Action<UnityEngine.GameObject>(object:  SoundFXOnOff.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SoundFXOnOff.<>c::丏业与丌丆专丒万丟(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this.soundFXDynamicList != null)
        {
            goto label_28;
        }
        
        goto label_28;
    }
    private void Update()
    {
        bool val_7;
        var val_8;
        System.Action<UnityEngine.GameObject> val_10;
        if(this.丂不不且丛世不万丐 == true)
        {
                return;
        }
        
        if(this.丂丒丁丛丅丗丌丞丄.activeSelf ^ 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_7 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        this.丂丒丁丛丅丗丌丞丄.SetActive(value:  val_7);
        val_8 = null;
        val_8 = null;
        val_10 = SoundFXOnOff.<>c.<>9__4_0;
        if(val_10 == null)
        {
                System.Action<UnityEngine.GameObject> val_6 = null;
            val_10 = val_6;
            val_6 = new System.Action<UnityEngine.GameObject>(object:  SoundFXOnOff.<>c.__il2cppRuntimeField_static_fields, method:  System.Void SoundFXOnOff.<>c::与三丑不丗丟丅专且(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            SoundFXOnOff.<>c.<>9__4_0 = val_10;
        }
        
        this.soundFXDynamicList.ForEach(action:  val_6);
    }
    public SoundFXOnOff()
    {
        this.soundFXDynamicList = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
