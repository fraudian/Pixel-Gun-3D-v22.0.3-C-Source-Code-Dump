using UnityEngine;
private sealed class ReusableRewardedVideo.上东与三万丄丒丛不 : ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁
{
    // Fields
    private const string 丌与丌丝丛丂万不丞 = "ReusableRewardedVideo.ReadyToWatch.";
    
    // Methods
    internal ReusableRewardedVideo.上东与三万丄丒丛不(Rilisoft.ReusableRewardedVideo 下丒丗丛丙丆丄丈专)
    {
    
    }
    public override void 丗世业丞丝且丙七下(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 且东丁丄业世丞丁不, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                string val_2 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.ReadyToWatch.Enter", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_2);
        }
        
        val_2.SetActive(value:  true);
        this.SetActive(value:  true);
    }
    public override void 丕丗丏东丘丑丗与丅(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 与丆丌丂丟丛丘丑且, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        丒且万不丌丁丂丒丟 val_3;
        var val_4;
        val_3 = 丗丄下丈丑七丗丞专;
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                val_3 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.ReadyToWatch.Exit", arg1:  "input", arg2:  val_3);
            UnityEngine.Debug.Log(message:  val_3);
        }
        
        if((与丆丌丂丟丛丘丑且 != null) && (null == null))
        {
                val_4 = null;
            val_4 = null;
            val_3 = System.EventArgs.Empty;
            if(0 != 0)
        {
                0.Invoke(sender:  与丆丌丂丟丛丘丑且, e:  val_3);
        }
        
        }
        
        与丆丌丂丟丛丘丑且.SetActive(value:  false);
        this.SetActive(value:  false);
    }
    public override Rilisoft.万丐丂专丏丛丑丌丑<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 丞一丙东丐且丝丞丑(Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁 val_7;
        var val_9;
        Rilisoft.丝丌万丗三丈与丁丂<TInput> val_10;
        var val_11;
        if((丗丄下丈丑七丗丞专 != 3) && (Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false))
        {
                UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.ReadyToWatch.React", arg1:  "input", arg2:  丗丄下丈丑七丗丞专));
        }
        
        if(丗丄下丈丑七丗丞专 == 5)
        {
            goto label_5;
        }
        
        if(丗丄下丈丑七丗丞专 != 2)
        {
            goto label_6;
        }
        
        val_7 = new ReusableRewardedVideo.丝丘与业且丙不丙丗();
        .且业丁丝丐丅且上丝 = PGCompany.且世万丐七丆丛丄丌.丐丞丂丒丏专不丒业();
        val_7 = new ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁(下丒丗丛丙丆丄丈专:  this);
        val_9 = 1152921542246130192;
        goto label_7;
        label_5:
        ReusableRewardedVideo.丈丒丟上七丝且业丅 val_5 = null;
        val_7 = val_5;
        val_5 = new ReusableRewardedVideo.丈丒丟上七丝且业丅(下丒丗丛丙丆丄丈专:  this);
        Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丈丒丟上七丝且业丅, 丒且万不丌丁丂丒丟> val_6 = null;
        val_9 = 1152921542246139408;
        label_7:
        val_10 = val_6;
        val_6 = new Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丈丒丟上七丝且业丅, 丒且万不丌丁丂丒丟>(与丆丌丂丟丛丘丑且:  val_5);
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_10;
        label_6:
        val_11 = null;
        val_11 = null;
        val_10 = Rilisoft.丝丌万丗三丈与丁丂<TInput>.万丝上三丈下丌业与;
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_10;
    }

}
