using UnityEngine;
internal sealed class MailBoxFullContent : PGBehaviour
{
    // Fields
    internal 一丗不丈丒万丂下丑 maxAspectRatio;
    internal System.Collections.Generic.List<MailBoxChildFullContet> childFullContets;
    private MailBoxChildFullContet 万丙丞丏丄丆三丕一;
    public UILabel headerLabel;
    public UILabel desc2Label;
    public UILabel dateLabel;
    public UITexture newsPic;
    internal bool 不丟丌丅丁丅丛一丛;
    internal TweenAlpha tweenAlphaFullScroll;
    
    // Properties
    internal MailBoxChildFullContet 三丘丛下丂丒丏丁丅 { get; set; }
    
    // Methods
    internal MailBoxChildFullContet 丛上且丕丐世一丘丛()
    {
        if(this.万丙丞丏丄丆三丕一 != 0)
        {
                if(((this.万丙丞丏丄丆三丕一.isPicture == true) ? 1 : 0) == ((this.不丟丌丅丁丅丛一丛 == true) ? 1 : 0))
        {
            goto label_5;
        }
        
        }
        
        this.一丟上丐且东丄丁丏();
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.万丙丞丏丄丆三丕一, 丏业丟一东丂东丘丛:  true);
        return (MailBoxChildFullContet)this.万丙丞丏丄丆三丕一;
    }
    internal void 与丑下丗丅东且丈丂(MailBoxChildFullContet 丙业与丙丗丝不丈东)
    {
        this.万丙丞丏丄丆三丕一 = 丙业与丙丗丝不丈东;
    }
    private void 一丟上丐且东丄丁丏()
    {
        var val_7;
        var val_8;
        val_7 = this;
        if(this.childFullContets.Count == 1)
        {
                val_8 = 1;
            this.万丙丞丏丄丆三丕一 = this.childFullContets.Item[0];
        }
        else
        {
                val_8 = 0;
        }
        
        List.Enumerator<T> val_3 = this.childFullContets.GetEnumerator();
        goto label_15;
        label_16:
        string val_4 = 0.丐丏七丌丕丗业且上();
        if((val_8 & 1) != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_4, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                var val_5 = ((-685651128) != 0) ? 1 : 0;
            val_5 = val_5 ^ ((this.不丟丌丅丁丅丛一丛 == true) ? 1 : 0);
            if((val_5 & 1) != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_4, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                this.万丙丞丏丄丆三丕一 = val_4;
        }
        
        }
        
        label_15:
        if(((-685651128) & 1) != 0)
        {
            goto label_16;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public MailBoxFullContent()
    {
        this.childFullContets = new System.Collections.Generic.List<MailBoxChildFullContet>();
    }

}
