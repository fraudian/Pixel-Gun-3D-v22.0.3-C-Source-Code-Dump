using UnityEngine;
public class SiegeController.与丂东专丏且丆丝丗
{
    // Fields
    private float 丟丂丏不万丏且下丝;
    public int 不丛三三专丛一万丝;
    public bool 丄上且东丙丘丙丈丕;
    public bool 与丟丌丒丐丕丒丟丌;
    public float 丆丄专丌丁业万丛且;
    public float 东且且丑一丞丂丅且;
    public string[] 丆万下上七丄上与丙;
    public string 丐世丐丌丞丟丞丕丆;
    public UnityEngine.Texture 上丌丏丅丑丈世丁且;
    
    // Methods
    public SiegeController.与丂东专丏且丆丝丗(string[] 丆万下上七丄上与丙)
    {
        this.丆丄专丌丁业万丛且 = 0f;
        this.东且且丑一丞丂丅且 = 1.5f;
        this.丆万下上七丄上与丙 = 丆万下上七丄上与丙;
    }
    public void 且丑七专与且丈业丑()
    {
        float val_10 = this.丆丄专丌丁业万丛且;
        if(val_10 <= 0f)
        {
            goto label_1;
        }
        
        if(this.丟丂丏不万丏且下丝 <= 0f)
        {
            goto label_2;
        }
        
        val_10 = this.丟丂丏不万丏且下丝 - UnityEngine.Time.deltaTime;
        this.丟丂丏不万丏且下丝 = val_10;
        goto label_22;
        label_1:
        if(this.丄上且东丙丘丙丈丕 != true)
        {
                this.丄上且东丙丘丙丈丕 = true;
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  SiegeUI.__il2cppRuntimeField_methods);
        }
        
        }
        
        }
        
        if(this.东且且丑一丞丂丅且 <= 0f)
        {
            goto label_15;
        }
        
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = this.东且且丑一丞丂丅且 - val_5;
        this.东且且丑一丞丂丅且 = val_5;
        return;
        label_2:
        int val_10 = this.不丛三三专丛一万丝;
        val_10 = val_10 + 1;
        this.丟丂丏不万丏且下丝 = 0.2f;
        this.不丛三三专丛一万丝 = val_10;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                UnityEngine.AudioSource val_8 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  SiegeUI.__il2cppRuntimeField_properties);
        }
        
        }
        
        label_22:
        float val_9 = UnityEngine.Time.deltaTime;
        val_9 = this.丆丄专丌丁业万丛且 - val_9;
        this.丆丄专丌丁业万丛且 = val_9;
        return;
        label_15:
        this.与丟丌丒丐丕丒丟丌 = true;
    }
    internal bool 丌丆丞丘丐丁且丂且(NetworkStartTable 不且上一上丐三万丛)
    {
        System.String[] val_2;
        var val_3;
        var val_2 = 0;
        label_5:
        val_2 = this.丆万下上七丄上与丙;
        if(val_2 >= this.丆万下上七丄上与丙.Length)
        {
            goto label_1;
        }
        
        val_2 = this.丆万下上七丄上与丙[0];
        val_2 = val_2 + 1;
        if((System.String.op_Equality(a:  val_2, b:  不且上一上丐三万丛.丐丆丒丅且丏世一与)) == false)
        {
            goto label_5;
        }
        
        val_3 = 1;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
    }
    internal void 专万丏丛丝丝丝丙丑(NetworkStartTable 不且上一上丐三万丛)
    {
        if(不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner == null)
        {
                return;
        }
        
        与丅丕丈丘东丝世丟 val_2 = 不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner;
        this.丐世丐丌丞丟丞丕丆 = 不且上一上丐三万丛.丐丆丒丅且丏世一与;
        this.上丌丏丅丑丈世丁且 = 不且上一上丐三万丛.丏丅业丞丁丌丈与丆;
    }

}
