using UnityEngine;
public class FollowWidgetDepth : MonoBehaviour
{
    // Fields
    public bool keepSharedMaterial;
    public UISprite sprite;
    internal static System.Collections.Generic.List<string> 业丙七丁三丐东万与;
    internal static System.Collections.Generic.List<int> 丝丆与丕丕上丒丏丒;
    private UnityEngine.ParticleSystem 丘丕丝上下丄丈丏丒;
    private int 丈丈丁丁丗不丂丄丝;
    private bool 丝一专专丏丝丘丒东;
    
    // Properties
    private UnityEngine.ParticleSystem 与一丐业丝上丕丘东 { get; }
    
    // Methods
    private UnityEngine.ParticleSystem 七万丅下丘丂丒丟一()
    {
        UnityEngine.ParticleSystem val_3;
        if(this.丘丕丝上下丄丈丏丒 != 0)
        {
                val_3 = this.丘丕丝上下丄丈丏丒;
            return val_2;
        }
        
        UnityEngine.ParticleSystem val_2 = this.GetComponent<UnityEngine.ParticleSystem>();
        this.丘丕丝上下丄丈丏丒 = val_2;
        return val_2;
    }
    private void OnEnable()
    {
        this.丝一专专丏丝丘丒东 = true;
    }
    private void LateUpdate()
    {
        int val_14 = 1152921504848912384;
        if(this.sprite == 0)
        {
                return;
        }
        
        if(this.sprite == 0)
        {
                return;
        }
        
        if(this.丝一专专丏丝丘丒东 != true)
        {
                val_14 = this.丈丈丁丁丗不丂丄丝;
            int val_3 = this.sprite.renderQueue;
            this.丝一专专丏丝丘丒东 = (val_14 != val_3) ? 1 : 0;
            if(val_14 == val_3)
        {
                return;
        }
        
        }
        
        UnityEngine.ParticleSystemRenderer val_6 = this.七万丅下丘丂丒丟一().GetComponent<UnityEngine.ParticleSystemRenderer>();
        UnityEngine.Material val_7 = val_6.sharedMaterial;
        val_14 = this.sprite.renderQueue;
        if(val_6 == null)
        {
            goto label_16;
        }
        
        if(this.keepSharedMaterial == false)
        {
            goto label_17;
        }
        
        label_22:
        string val_10 = val_6.sharedMaterial.name;
        int val_11 = val_10.丅丒丙一丞丝丁东业(丈丑丈不丈丝丒丑万:  val_10);
        if(val_11 >= val_14)
        {
            goto label_19;
        }
        
        val_11.丘丛业丈丅一丑丅丏(丈丑丈不丈丝丒丑万:  val_10, 丞丈丐一万丈丝丘丈:  val_14);
        UnityEngine.Material val_12 = val_6.sharedMaterial;
        goto label_21;
        label_16:
        if(this.keepSharedMaterial == true)
        {
            goto label_22;
        }
        
        label_17:
        label_21:
        val_6.material.renderQueue = val_14;
        this.丈丈丁丁丗不丂丄丝 = val_14;
        label_19:
        this.丝一专专丏丝丘丒东 = false;
    }
    private int 丅丒丙一丞丝丁东业(string 丈丑丈不丈丝丒丑万)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = 0;
        goto label_1;
        label_9:
        val_5 = null;
        val_5 = null;
        if((System.String.op_Equality(a:  FollowWidgetDepth.业丙七丁三丐东万与.Item[0], b:  丈丑丈不丈丝丒丑万)) == true)
        {
            goto label_5;
        }
        
        val_4 = 1;
        label_1:
        val_6 = null;
        val_6 = null;
        if(val_4 < FollowWidgetDepth.业丙七丁三丐东万与.Count)
        {
            goto label_9;
        }
        
        return 0;
        label_5:
        val_7 = null;
        val_7 = null;
        if(FollowWidgetDepth.丝丆与丕丕上丒丏丒 != null)
        {
                return FollowWidgetDepth.丝丆与丕丕上丒丏丒.Item[0];
        }
        
        return FollowWidgetDepth.丝丆与丕丕上丒丏丒.Item[0];
    }
    private void 丘丛业丈丅一丑丅丏(string 丈丑丈不丈丝丒丑万, int 丞丈丐一万丈丝丘丈)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_5 = 0;
        val_6 = 0;
        val_7 = 0;
        goto label_1;
        label_8:
        bool val_2 = System.String.op_Equality(a:  FollowWidgetDepth.业丙七丁三丐东万与.Item[0], b:  丈丑丈不丈丝丒丑万);
        val_7 = val_7 | val_2;
        val_5 = 1;
        label_1:
        val_8 = null;
        val_8 = null;
        val_9 = null;
        if(val_5 < FollowWidgetDepth.业丙七丁三丐东万与.Count)
        {
            goto label_8;
        }
        
        if(val_7 != false)
        {
                val_10 = null;
            FollowWidgetDepth.丝丆与丕丕上丒丏丒.set_Item(index:  (val_2 != true) ? (val_5) : (val_6), value:  丞丈丐一万丈丝丘丈);
            return;
        }
        
        val_11 = null;
        FollowWidgetDepth.业丙七丁三丐东万与.Add(item:  丈丑丈不丈丝丒丑万);
        FollowWidgetDepth.丝丆与丕丕上丒丏丒.Add(item:  丞丈丐一万丈丝丘丈);
    }
    public FollowWidgetDepth()
    {
        this.keepSharedMaterial = true;
        this.丈丈丁丁丗不丂丄丝 = 0;
    }
    private static FollowWidgetDepth()
    {
        FollowWidgetDepth.业丙七丁三丐东万与 = new System.Collections.Generic.List<System.String>();
        FollowWidgetDepth.丝丆与丕丕上丒丏丒 = new System.Collections.Generic.List<System.Int32>();
    }

}
