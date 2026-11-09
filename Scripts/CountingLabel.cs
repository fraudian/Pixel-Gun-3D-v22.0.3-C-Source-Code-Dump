using UnityEngine;
public class CountingLabel : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip tickSound;
    public UILabel[] targets;
    private string <丗不丝丄丛专丒七七>k__BackingField;
    private bool <丞七下东一丆丅不且>k__BackingField;
    private int 丙东专丗上不丂丆业;
    private int 丝三业丛丘且不丝丆;
    private float duration;
    private bool 世丂丄丕丟丐丘丄七;
    private float 丞且丅三三东不丄且;
    private int 丂丐丏下万万丒三上;
    private float 丘丐万丙丆一丞且丆;
    
    // Properties
    internal string 丕丂丐丌丆丝且万丗 { get; set; }
    internal bool 丒与丘丕丒丝东一丗 { get; set; }
    
    // Methods
    internal string 且丞且丞一七丂丁丟()
    {
        return (string)this.<丗不丝丄丛专丒七七>k__BackingField;
    }
    private void 专丂丙东专丝七一丅(string 丙业与丙丗丝不丈东)
    {
        this.<丗不丝丄丛专丒七七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 下丒丑下丟世丆丙丑()
    {
        return (bool)this.<丞七下东一丆丅不且>k__BackingField;
    }
    private void 世三丒三丛丅丘丘丂(bool 丙业与丙丗丝不丈东)
    {
        this.<丞七下东一丆丅不且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 且丟丘专丕丗丟专下(float 与丈业丛丝丒丙一丏)
    {
        if((this.<丞七下东一丆丅不且>k__BackingField) != false)
        {
                return;
        }
        
        this.duration = 与丈业丛丝丒丙一丏;
    }
    internal void 丅下丂丒东下丒丑丐()
    {
        this.<丞七下东一丆丅不且>k__BackingField = false;
        this.一与三丂丌丘丟丛丁(丕丗丘丑丛与丑业丒:  System.String.alignConst);
    }
    internal void 上不与丞丛不丏专丙(int 丂丐丏下万万丒三上, string 丕丂丐丌丆丝且万丗 = "")
    {
        if((System.String.IsNullOrEmpty(value:  丕丂丐丌丆丝且万丗)) != false)
        {
                string val_2 = 丂丐丏下万万丒三上.ToString();
        }
        
        this.<丞七下东一丆丅不且>k__BackingField = false;
        this.丝三业丛丘且不丝丆 = 丂丐丏下万万丒三上;
        this.一与三丂丌丘丟丛丁(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丕丂丐丌丆丝且万丗, arg0:  丂丐丏下万万丒三上));
    }
    internal void 丒丙丐丑丘不丅业下(int 丆一万东丒丗一丝不, int 上丘专万丐丐丗丕丈, float 丟丞一专丕三东丗一, string 丕丂丐丌丆丝且万丗 = "")
    {
        float val_3;
        if((this.<丞七下东一丆丅不且>k__BackingField) != false)
        {
            
        }
        else
        {
                val_3 = 0f;
            this.世丂丄丕丟丐丘丄七 = false;
            this.丙东专丗上不丂丆业 = 丆一万东丒丗一丝不;
            this.丝三业丛丘且不丝丆 = 上丘专万丐丐丗丕丈;
            this.<丗不丝丄丛专丒七七>k__BackingField = 丕丂丐丌丆丝且万丗;
            if()
        {
                val_3 = this.duration / ((float)上丘专万丐丐丗丕丈 - 丆一万东丒丗一丝不);
        }
        
            this.丞且丅三三东不丄且 = val_3;
        }
        
        float val_3 = (float)上丘专万丐丐丗丕丈 - 丆一万东丒丗一丝不;
        val_3 = val_3 * 丟丞一专丕三东丗一;
        if(val_3 > this.duration)
        {
                return;
        }
        
        this.丞且丅三三东不丄且 = 丟丞一专丕三东丗一;
    }
    internal void 且丏丂丐丏业丕七丞(int 丆一万东丒丗一丝不, int 上丘专万丐丐丗丕丈, string 丕丂丐丌丆丝且万丗 = "")
    {
        float val_2;
        if((this.<丞七下东一丆丅不且>k__BackingField) != false)
        {
                return;
        }
        
        val_2 = 0f;
        this.世丂丄丕丟丐丘丄七 = false;
        this.丙东专丗上不丂丆业 = 丆一万东丒丗一丝不;
        this.丝三业丛丘且不丝丆 = 上丘专万丐丐丗丕丈;
        this.<丗不丝丄丛专丒七七>k__BackingField = 丕丂丐丌丆丝且万丗;
        if()
        {
                val_2 = this.duration / ((float)上丘专万丐丐丗丕丈 - 丆一万东丒丗一丝不);
        }
        
        this.丞且丅三三东不丄且 = val_2;
    }
    internal void 丞上丝丗七丁七丑丘()
    {
        this.世丂丄丕丟丐丘丄七 = true;
    }
    internal void 丄丄丛万丁丐丐与丏()
    {
        if(this.世丂丄丕丟丐丘丄七 == true)
        {
                return;
        }
        
        if((this.<丞七下东一丆丅不且>k__BackingField) == true)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.丂丐丏下万万丒三上 = this.丙东专丗上不丂丆业;
        if(this.丞且丅三三东不丄且 != 0f)
        {
                this.<丞七下东一丆丅不且>k__BackingField = true;
            return;
        }
        
        this.丒丁丅一下丂专万不(丂丐丏下万万丒三上:  this.丝三业丛丘且不丝丆, 丕丂丐丌丆丝且万丗:  this.<丗不丝丄丛专丒七七>k__BackingField);
    }
    internal void 丌丄丏下七丁专丂世()
    {
        this.<丞七下东一丆丅不且>k__BackingField = false;
    }
    private void Update()
    {
        if((this.<丞七下东一丆丅不且>k__BackingField) == false)
        {
                return;
        }
        
        if(this.targets == null)
        {
                return;
        }
        
        float val_5 = this.丘丐万丙丆一丞且丆;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_5 + val_1;
        this.丘丐万丙丆一丞且丆 = val_1;
        if(val_1 < this.丞且丅三三东不丄且)
        {
                return;
        }
        
        val_5 = val_1 / this.丞且丅三三东不丄且;
        this.丒丁丅一下丂专万不(丂丐丏下万万丒三上:  this.丂丐丏下万万丒三上, 丕丂丐丌丆丝且万丗:  this.<丗不丝丄丛专丒七七>k__BackingField);
        if(this.tickSound != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.tickSound);
        }
        
        }
        
        int val_6 = this.丂丐丏下万万丒三上;
        val_6 = val_6 + (int)val_5;
        this.丂丐丏下万万丒三上 = val_6;
        this.丘丐万丙丆一丞且丆 = 0f;
        if(val_6 <= this.丝三业丛丘且不丝丆)
        {
                return;
        }
        
        this.丒丁丅一下丂专万不(丂丐丏下万万丒三上:  this.丝三业丛丘且不丝丆, 丕丂丐丌丆丝且万丗:  this.<丗不丝丄丛专丒七七>k__BackingField);
        this.<丞七下东一丆丅不且>k__BackingField = false;
    }
    private void 丒丁丅一下丂专万不(int 丂丐丏下万万丒三上, string 丕丂丐丌丆丝且万丗)
    {
        string val_6 = 丕丂丐丌丆丝且万丗;
        if((System.String.IsNullOrEmpty(value:  val_6 = 丕丂丐丌丆丝且万丗)) == false)
        {
            goto label_1;
        }
        
        label_7:
        val_6 = 丂丐丏下万万丒三上.ToString();
        goto label_6;
        label_1:
        if(((val_6.Contains(value:  "{")) == false) || ((val_6.Contains(value:  "}")) == false))
        {
            goto label_6;
        }
        
        string val_5 = System.String.Format(format:  val_6, arg0:  丂丐丏下万万丒三上);
        goto label_7;
        label_6:
        this.一与三丂丌丘丟丛丁(丕丗丘丑丛与丑业丒:  val_6);
    }
    private void 一与三丂丌丘丟丛丁(string 丕丗丘丑丛与丑业丒)
    {
        goto label_1;
        label_16:
        if(this.targets[0] != 0)
        {
                if((this.targets[0].text.Equals(value:  丕丗丘丑丛与丑业丒)) != true)
        {
                this.targets[0].text = 丕丗丘丑丛与丑业丒;
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < this.targets.Length)
        {
            goto label_16;
        }
    
    }
    private void OnDisable()
    {
        this.<丞七下东一丆丅不且>k__BackingField = false;
    }
    private void 东丄且丞丘丕东且专()
    {
        this.丄丄丛万丁丐丐与丏();
    }
    public CountingLabel()
    {
    
    }

}
