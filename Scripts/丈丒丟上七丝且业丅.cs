using UnityEngine;
private sealed class ReusableRewardedVideo.丈丒丟上七丝且业丅 : ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁
{
    // Fields
    private const string 丌与丌丝丛丂万不丞 = "ReusableRewardedVideo.Idle.";
    
    // Methods
    public ReusableRewardedVideo.丈丒丟上七丝且业丅(Rilisoft.ReusableRewardedVideo 下丒丗丛丙丆丄丈专)
    {
    
    }
    public override void 丗世业丞丝且丙七下(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 且东丁丄业世丞丁不, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                string val_2 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Idle.Enter", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_2);
        }
        
        if(null != 0)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            val_2.Dispose();
            mem2[0] = 0;
        }
        
        this.东东七丕世业丞丌世(丗丛不丁丑专专丂且:  this.三丅丙丗丟丙世丑丅(且东丁丄业世丞丁不:  且东丁丄业世丞丁不));
    }
    public override Rilisoft.万丐丂专丏丛丑丌丑<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 丞一丙东丐且丝丞丑(Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        Rilisoft.丝丌万丗三丈与丁丂<TInput> val_5;
        var val_6;
        if((丗丄下丈丑七丗丞专 != 3) && (Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false))
        {
                UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Idle.React", arg1:  "input", arg2:  丗丄下丈丑七丗丞专));
        }
        
        if(丗丄下丈丑七丗丞专 == 4)
        {
                Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.上东与三万丄丒丛不, 丒且万不丌丁丂丒丟> val_4 = null;
            val_5 = val_4;
            val_4 = new Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.上东与三万丄丒丛不, 丒且万不丌丁丂丒丟>(与丆丌丂丟丛丘丑且:  new ReusableRewardedVideo.上东与三万丄丒丛不(下丒丗丛丙丆丄丈专:  this));
            return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_5;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = Rilisoft.丝丌万丗三丈与丁丂<TInput>.万丝上三丈下丌业与;
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_5;
    }
    public override void 丕丗丏东丘丑丗与丅(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 与丆丌丂丟丛丘丑且, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        var val_8;
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                string val_2 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Idle.Exit", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_2);
        }
        
        if(val_2 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_2.Dispose();
        }
        
        mem2[0] = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  X22, method:  System.Void Rilisoft.ReusableRewardedVideo::七丕东丘丑丞三丏丑()), 与且专丈不万东一万:  "ReusableRewardedVideo.Idle.Exit()");
        val_8 = null;
        val_8 = null;
        if(0 == 0)
        {
                return;
        }
        
        0.Invoke(sender:  this, e:  System.EventArgs.Empty);
    }
    private Rilisoft.与丞专七丙专下丅且 三丅丙丗丟丙世丑丅(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 且东丁丄业世丞丁不)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if((且东丁丄业世丞丁不 != null) && (null == null))
        {
                if(且东丁丄业世丞丁不.丂丌丈丗东专丒丒丐().IsCompleted != false)
        {
                if(且东丁丄业世丞丁不.丂丌丈丗东专丒丒丐().IsFaulted == false)
        {
            goto label_6;
        }
        
        }
        
        }
        
        val_8 = null;
        val_8 = null;
        return (Rilisoft.与丞专七丙专下丅且)Rilisoft.与丞专七丙专下丅且.丁丂专丝丑丗丅业丑;
        label_6:
        val_9 = null;
        if((System.String.Equals(a:  且东丁丄业世丞丁不.丂丌丈丗东专丒丒丐().Result, b:  "CLOSE_FINISHED", comparisonType:  4)) != false)
        {
                val_10 = null;
            return (Rilisoft.与丞专七丙专下丅且)Rilisoft.与丞专七丙专下丅且.丁丂专丝丑丗丅业丑;
        }
        
        val_11 = null;
        return (Rilisoft.与丞专七丙专下丅且)Rilisoft.与丞专七丙专下丅且.丁丂专丝丑丗丅业丑;
    }

}
