using UnityEngine;
private sealed class BattlePassLevelView.丛丐专世丛丄丆三丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public int 丈丘丝一丗下丈丐不;
    public PGCompany.BattlePass.BattlePassLevelView 丝且与丝丒丟万丁专;
    public int 丘丄丙七上下丄丂丄;
    public int 丏丟与下业丑丘且丂;
    public bool 三丂东专丕专业丏万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattlePassLevelView.丛丐专世丛丄丆三丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_15;
        var val_16;
        int val_17;
        int val_18;
        var val_19;
        var val_20;
        val_15 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_16 = null;
        val_16 = null;
        val_17 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  PGCompany.BattlePass.BattlePassLevelView.世丑上丝上且丌丌丟);
        this.丗丏丅丕丆世丁专丟 = val_17;
        return (bool)val_17;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_18 = 1152921504848912384;
        if(this.丝且与丝丒丟万丁专._updatedProgressSprite != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专._updatedProgressSprite, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.丝且与丝丒丟万丁专._progressSprite != 0)
        {
                val_18 = this.丘丄丙七上下丄丂丄;
            float val_14 = (float)val_18;
            val_14 = val_14 / (float)this.丏丟与下业丑丘且丂;
            this.丝且与丝丒丟万丁专._progressSprite.fillAmount = val_14;
        }
        
        val_15 = this.丈丘丝一丗下丈丐不.ToString();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专._levelLabel, 丕丗丘丑丛与丑业丒:  val_15);
        label_25:
        val_17 = 0;
        this.丝且与丝丒丟万丁专.丛丘丒丛丟世万与世 = 0;
        return (bool)val_17;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_19 = null;
        val_19 = null;
        PGCompany.BattlePass.BattlePassLevelView.世丑上丝上且丌丌丟 = 0f;
        if((this.丈丘丝一丗下丈丐不 == this.丝且与丝丒丟万丁专.丑与丗一丘下丆丐丅) && (this.丘丄丙七上下丄丂丄 == this.丝且与丝丒丟万丁专.丞三丟上与丗丆丕丏))
        {
                if(this.丏丟与下业丑丘且丂 == this.丝且与丝丒丟万丁专.世丐丂专上专丌丅丟)
        {
            goto label_25;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专._progressLabel != 0)
        {
                val_18 = this.丝且与丝丒丟万丁专._progressLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  this.丘丄丙七上下丄丂丄, arg1:  this.丏丟与下业丑丘且丂));
        }
        
        if(this.丝且与丝丒丟万丁专._updatedProgressSprite != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专._updatedProgressSprite, 丏业丟一东丂东丘丛:  true);
            val_18 = this.丘丄丙七上下丄丂丄;
            float val_15 = (float)val_18;
            val_15 = val_15 / (float)this.丏丟与下业丑丘且丂;
            this.丝且与丝丒丟万丁专._updatedProgressSprite.fillAmount = val_15;
        }
        
        if(PGCompany.BattlePass.BattlePassSettings.Instance == 0)
        {
            goto label_39;
        }
        
        val_20 = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        goto label_42;
        label_3:
        val_17 = 0;
        return (bool)val_17;
        label_39:
        val_20 = 0;
        label_42:
        val_20 = val_20 & this.三丂东专丕专业丏万;
        if(val_20 != false)
        {
                PGCompany.BattlePass.BattlePassSettings val_11 = PGCompany.BattlePass.BattlePassSettings.Instance;
            UnityEngine.AudioSource val_12 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_11._giveBPExpEndAudioClip);
        }
        
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1.5f);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_17 = 1;
        return (bool)val_17;
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
