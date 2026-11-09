using UnityEngine;
private sealed class BankIncrementSoundIndicator.丅下丕丞丗一丈丁丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public string 丏丂不专上丘丂不丅;
    public bool 丗专丕丑丝丕东三丆;
    public Rilisoft.BankIncrementSoundIndicator 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BankIncrementSoundIndicator.丅下丕丞丗一丈丁丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.AudioClip val_13;
        int val_14;
        var val_15;
        UnityEngine.AudioClip val_16;
        UnityEngine.Object val_17;
        val_13 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_35;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  "LevelComplete")) == true) || (与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false))
        {
            goto label_35;
        }
        
        val_14 = 1;
        this.丒上七丌业七丟与丐 = new 丕世专丒丁不丁丅丁(丆丐七丅丆丗丛上与:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_14;
        return (bool)val_14;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = null;
        val_15 = null;
        if((System.String.op_Equality(a:  this.丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
        {
            goto label_11;
        }
        
        if(this.丗专丕丑丝丕东三丆 == false)
        {
            goto label_12;
        }
        
        val_13 = this.丝且与丝丒丟万丁专.ClipCoinAdded;
        if(val_13 == 0)
        {
            goto label_30;
        }
        
        val_16 = this.丝且与丝丒丟万丁专.ClipGemAdded;
        goto label_31;
        label_11:
        if((System.String.op_Equality(a:  this.丏丂不专上丘丂不丅, b:  "ClanSilver")) == false)
        {
            goto label_18;
        }
        
        val_16 = this.丝且与丝丒丟万丁专;
        if(this.丝且与丝丒丟万丁专._clanSilverAdded != 0)
        {
            goto label_31;
        }
        
        label_18:
        val_17 = 0;
        if((System.String.op_Equality(a:  this.丏丂不专上丘丂不丅, b:  "BattlePassCurrency")) == true)
        {
            goto label_23;
        }
        
        if(this.丗专丕丑丝丕东三丆 == false)
        {
            goto label_24;
        }
        
        val_16 = this.丝且与丝丒丟万丁专;
        val_13 = this.丝且与丝丒丟万丁专.ClipCoinAdded;
        if(val_13 == 0)
        {
            goto label_32;
        }
        
        goto label_31;
        label_12:
        label_30:
        val_16 = this.丝且与丝丒丟万丁专.ClipGemsAdded;
        goto label_31;
        label_24:
        label_32:
        val_16 = this.丝且与丝丒丟万丁专.ClipCoinsAdded;
        label_31:
        val_17 = mem[this.丝且与丝丒丟万丁专.ClipCoinsAdded];
        label_23:
        if(val_17 != 0)
        {
                UnityEngine.AudioSource val_12 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_17);
        }
        
        label_35:
        val_14 = 0;
        return (bool)val_14;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
