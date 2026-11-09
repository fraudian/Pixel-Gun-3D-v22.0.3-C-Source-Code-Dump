using UnityEngine;
private sealed class ReusableRewardedVideo.丝丘与业且丙不丙丗 : ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁
{
    // Fields
    private const string 丌与丌丝丛丂万不丞 = "ReusableRewardedVideo.Waiting.";
    private const float 丈丆三且丞业丌万专 = 5;
    private float 且业丁丝丐丅且上丝;
    
    // Methods
    public ReusableRewardedVideo.丝丘与业且丙不丙丗(Rilisoft.ReusableRewardedVideo 下丒丗丛丙丆丄丈专)
    {
        this.且业丁丝丐丅且上丝 = PGCompany.且世万丐七丆丛丄丌.丐丞丂丒丏专不丒业();
    }
    public override void 丗世业丞丝且丙七下(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 且东丁丄业世丞丁不, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                string val_2 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Waiting.Enter", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_2);
        }
        
        val_2.SetActive(value:  true);
        val_2.SetActive(value:  true);
        if(val_2 != 0)
        {
                val_2.SetActive(value:  UnityEngine.Application.isEditor);
        }
        
        this.且业丁丝丐丅且上丝 = PGCompany.且世万丐七丆丛丄丌.丐丞丂丒丏专不丒业();
    }
    public override Rilisoft.万丐丂专丏丛丑丌丑<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 丞一丙东丐且丝丞丑(Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        object val_20;
        float val_21;
        Rilisoft.丟世丈丕世丌丌与丐<TInput> val_22;
        var val_24;
        object val_25;
        Rilisoft.丝丌万丗三丈与丁丂<TInput> val_26;
        var val_27;
        if((丗丄下丈丑七丗丞专 != 3) && (Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false))
        {
                string val_2 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Waiting.React", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_2);
        }
        
        if(val_2 == 0)
        {
            goto label_8;
        }
        
        float val_5 = PGCompany.且世万丐七丆丛丄丌.丐丞丂丒丏专不丒业() - this.且业丁丝丐丅且上丝;
        val_20 = UnityEngine.Mathf.FloorToInt(f:  val_5);
        X22 + 192.invert = ((val_20 & 1) != 0) ? 1 : 0;
        if((val_20 & 1) != 0)
        {
            goto label_14;
        }
        
        val_21 = val_5 - (float)val_20;
        if((X22 + 192 + 192) != 0)
        {
            goto label_17;
        }
        
        goto label_16;
        label_14:
        float val_20 = 1f;
        val_20 = val_20 - val_5;
        val_21 = val_20 + (float)val_20;
        if((X22 + 192 + 192) != 0)
        {
            goto label_17;
        }
        
        label_16:
        label_17:
        X22 + 192 + 192.fillAmount = val_21;
        label_8:
        if(丗丄下丈丑七丗丞专 != 5)
        {
            goto label_18;
        }
        
        ReusableRewardedVideo.丈丒丟上七丝且业丅 val_8 = null;
        val_22 = val_8;
        val_8 = new ReusableRewardedVideo.丈丒丟上七丝且业丅(下丒丗丛丙丆丄丈专:  this);
        val_24 = 1152921542246139408;
        goto label_19;
        label_18:
        val_25 = 0;
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_20;
        }
        
        val_20 = 4;
        val_25 = val_20;
        if((System.Object.Equals(objA:  4, objB:  丗丄下丈丑七丗丞专)) == true)
        {
            goto label_21;
        }
        
        label_20:
        if(丗丄下丈丑七丗丞专 != 3)
        {
            goto label_22;
        }
        
        if(ReusableRewardedVideo.丝丘与业且丙不丙丗.三丈与丞上丘专丈丆() == false)
        {
            goto label_23;
        }
        
        label_21:
        ReusableRewardedVideo.丑丝七丈丌丆不三丏 val_12 = null;
        val_22 = val_12;
        val_12 = new ReusableRewardedVideo.丑丝七丈丌丆不三丏(下丒丗丛丙丆丄丈专:  this);
        Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丑丝七丈丌丆不三丏, 丒且万不丌丁丂丒丟> val_13 = null;
        val_24 = 1152921542248158928;
        label_19:
        val_26 = val_13;
        val_13 = new Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丑丝七丈丌丆不三丏, 丒且万不丌丁丂丒丟>(与丆丌丂丟丛丘丑且:  val_12);
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_26;
        label_23:
        float val_14 = PGCompany.且世万丐七丆丛丄丌.丐丞丂丒丏专不丒业();
        val_14 = val_14 - this.且业丁丝丐丅且上丝;
        if(val_14 >= 5f)
        {
            goto label_25;
        }
        
        label_22:
        val_27 = null;
        val_27 = null;
        val_26 = Rilisoft.丝丌万丗三丈与丁丂<TInput>.万丝上三丈下丌业与;
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_26;
        label_25:
        Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丁丂专丝丑丗丅业丑, 丒且万不丌丁丂丒丟> val_19 = new Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丁丂专丝丑丗丅业丑, 丒且万不丌丁丂丒丟>(与丆丌丂丟丛丘丑且:  new ReusableRewardedVideo.丁丂专丝丑丗丅业丑(下丒丗丛丙丆丄丈专:  this, 丁丂丕与丁丒丕丟丞:  "Timeout " + 1084227584.ToString(format:  "F1", provider:  Rilisoft.ReusableRewardedVideo.丙专丝世不业下丂丈())(1084227584.ToString(format:  "F1", provider:  Rilisoft.ReusableRewardedVideo.丙专丝世不业下丂丈())) + " seconds."));
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_26;
    }
    public override void 丕丗丏东丘丑丗与丅(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 与丆丌丂丟丛丘丑且, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        var val_4 = this;
        if(Rilisoft.ReusableRewardedVideo.世丈且业丆丑丏丐一() != false)
        {
                string val_2 = System.String.Format(format:  "[{0}] {1}: {2}", arg0:  "ReusableRewardedVideo.Waiting.Exit", arg1:  "input", arg2:  丗丄下丈丑七丗丞专);
            UnityEngine.Debug.Log(message:  val_2);
        }
        
        val_2.SetActive(value:  false);
        val_2.SetActive(value:  false);
        if(val_2 == 0)
        {
                return;
        }
        
        this.SetActive(value:  false);
    }
    private static bool 三丈与丞上丘专丈丆()
    {
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                return true;
        }
        
        PGCompany.Ads.下丙丏丈三上丕丈一 val_2 = PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世();
        if(val_2 != null)
        {
                return val_2.三丈与丞上丘专丈丆();
        }
        
        return val_2.三丈与丞上丘专丈丆();
    }

}
