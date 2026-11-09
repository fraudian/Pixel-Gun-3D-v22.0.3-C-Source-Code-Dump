using UnityEngine;
public class EmojiController : MonoBehaviour
{
    // Fields
    internal static EmojiController 丘丆专丕丏且不丏丑;
    protected System.Collections.Generic.List<EmojiChat> 丅三丙丝与七万业丟;
    protected System.Collections.Generic.List<EmojiChat> 丂下丒丄世且丅丈丗;
    protected UnityEngine.GameObject 三丙丌下与上且丆不;
    
    // Methods
    protected virtual void Awake()
    {
        UnityEngine.GameObject val_3;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "Emoji/ChatEmoji");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_3 = 0;
        }
        
        this.三丙丌下与上且丆不 = val_3;
    }
    protected virtual void OnEnable()
    {
        EmojiController.丘丆专丕丏且不丏丑 = this;
    }
    private void OnDisable()
    {
        this.丒丝丞丅丆丘世丅丈();
    }
    private void 丒丝丞丅丆丘世丅丈()
    {
        goto label_1;
        label_7:
        EmojiChat val_1 = this.丅三丙丝与七万业丟.Item[0];
        val_1.丒专下丟丝七丆丆三 = false;
        val_1.丑七与一业丛丞丝丈();
        this.丂下丒丄世且丅丈丗.Add(item:  val_1);
        this.丅三丙丝与七万业丟.RemoveAt(index:  0);
        label_1:
        if(this.丅三丙丝与七万业丟.Count > 0)
        {
            goto label_7;
        }
    
    }
    protected virtual void Update()
    {
        goto label_1;
        label_11:
        EmojiChat val_1 = this.丅三丙丝与七万业丟.Item[0];
        if(val_1.show != false)
        {
                if(val_1.owner != 0)
        {
            goto label_7;
        }
        
        }
        
        val_1.丒专下丟丝七丆丆三 = false;
        val_1.丑七与一业丛丞丝丈();
        this.丂下丒丄世且丅丈丗.Add(item:  val_1);
        this.丅三丙丝与七万业丟.RemoveAt(index:  0);
        label_7:
        0 = 0;
        label_1:
        if(0 < this.丅三丙丝与七万业丟.Count)
        {
            goto label_11;
        }
    
    }
    protected virtual EmojiChat 丒丑东七丟丗上丟丅()
    {
        if(this.丂下丒丄世且丅丈丗.Count != 0)
        {
                this.丂下丒丄世且丅丈丗.RemoveAt(index:  0);
            return (EmojiChat)this.丂下丒丄世且丅丈丗.Item[0];
        }
        
        UnityEngine.GameObject val_4 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject, 丑且不丕与专丄业丙:  this.三丙丌下与上且丆不);
        if(val_4 != null)
        {
                return val_4.GetComponent<EmojiChat>();
        }
        
        return val_4.GetComponent<EmojiChat>();
    }
    internal virtual void 下丞丆业丘东丁下且(NetworkStartTable 丈丗与丞一上且上上, string 丛丆丆世下丛不丏东)
    {
        var val_16;
        EmojiChat val_17;
        var val_18;
        val_17 = this;
        if((val_17 & 1) == 0)
        {
                return;
        }
        
        this.下丞丆业丘东丁下且(丈丗与丞一上且上上:  丈丗与丞一上且上上, 丛丆丆世下丛不丏东:  丛丆丆世下丛不丏东);
        val_18 = 0;
        goto label_3;
        label_12:
        EmojiChat val_1 = X23.Item[0];
        if(val_1.owner == 丈丗与丞一上且上上)
        {
                val_3.丒专下丟丝七丆丆三 = false;
            this.丅三丙丝与七万业丟.Item[0].丑七与一业丛丞丝丈();
        }
        
        val_18 = 1;
        label_3:
        if(val_18 < this.丅三丙丝与七万业丟.Count)
        {
            goto label_12;
        }
        
        this.丅三丙丝与七万业丟.Add(item:  this);
        val_17 = ???;
        val_16 = ???;
        goto typeof(EmojiController).__il2cppRuntimeField_1C8;
    }
    internal virtual bool 丟东丗丂东专丅丑丑(NetworkStartTable 不且上一上丐三万丛)
    {
        return true;
    }
    protected virtual void 丘丌丘一不丛东丝丒(EmojiChat 丟丗丙万丙且丐丏丗)
    {
    
    }
    public virtual void SendEmoji(string 丛丆丆世下丛不丏东)
    {
        var val_5;
        var val_6;
        System.Object[] val_8;
        object val_9;
        var val_10;
        var val_11;
        PlayerCoreSettingsStorager val_1 = PlayerCoreSettingsStorager.Instance;
        val_5 = null;
        if((val_1.listNewEmojies.Contains(item:  丛丆丆世下丛不丏东)) != false)
        {
                val_6 = null;
            val_8 = new object[2];
            val_8[0] = 丛丆丆世下丛不丏东;
            val_9 = 124105336;
            val_8[1] = val_9;
            val_10 = 192;
        }
        else
        {
                val_11 = null;
            object[] val_4 = new object[2];
            val_8 = val_4;
            val_8[0] = 丛丆丆世下丛不丏东;
            val_9 = 124105336;
            val_8[1] = val_9;
            val_10 = 153;
        }
        
        NetworkStartTable.__il2cppRuntimeField_flags.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  153, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_4);
    }
    public EmojiController()
    {
        this.丅三丙丝与七万业丟 = new System.Collections.Generic.List<EmojiChat>();
        this.丂下丒丄世且丅丈丗 = new System.Collections.Generic.List<EmojiChat>();
    }

}
