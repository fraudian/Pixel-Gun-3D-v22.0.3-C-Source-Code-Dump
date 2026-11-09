using UnityEngine;
private sealed class NewsLobbyController.一万上丂上丕丆下丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.NewsLobbyController 丝且与丝丒丟万丁专;
    public bool 七三丞丘丟下丛丛不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NewsLobbyController.一万上丂上丕丆下丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.NewsLobbyController val_34;
        var val_35;
        var val_36;
        int val_37;
        var val_38;
        var val_39;
        var val_40;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_34 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        0.与丌世东丑丆一丝丒();
        val_35 = 1152921505228464128;
        if(MailBoxMessagesController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_6;
        }
        
        val_36 = MailBoxMessagesController.丄丞丁丈与业上丞丟.业丗与世东丗丒世专().Count;
        if(val_34 != null)
        {
            goto label_12;
        }
        
        goto label_10;
        label_1:
        val_37 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        return (bool)val_37;
        label_6:
        val_36 = 0;
        if(val_34 != null)
        {
            goto label_12;
        }
        
        label_10:
        label_12:
        val_34.上丈丂丁业且丏丞上();
        if(val_36 == 0)
        {
            goto label_13;
        }
        
        if(val_34 == null)
        {
            goto label_14;
        }
        
        val_34.丗世丝丁七丏丏丄世();
        val_34.三丞丐丐丆下且丐丑();
        goto label_15;
        label_13:
        val_35 = 1152921530837094048;
        goto label_16;
        label_26:
        if(this.丝且与丝丒丟万丁专.mailBoxItems != null)
        {
                val_38 = this.丝且与丝丒丟万丁专.mailBoxItems.Count;
        }
        else
        {
                val_38 = this.丝且与丝丒丟万丁专.mailBoxItems.Count;
        }
        
        UnityEngine.Object.Destroy(obj:  this.丝且与丝丒丟万丁专.mailBoxItems.Item[val_38 - 1].gameObject);
        if(this.丝且与丝丒丟万丁专.mailBoxItems != null)
        {
                val_39 = this.丝且与丝丒丟万丁专.mailBoxItems.Count;
        }
        else
        {
                val_39 = this.丝且与丝丒丟万丁专.mailBoxItems.Count;
        }
        
        this.丝且与丝丒丟万丁专.mailBoxItems.RemoveAt(index:  val_39 - 1);
        label_16:
        if(this.丝且与丝丒丟万丁专.mailBoxItems.Count > 0)
        {
            goto label_26;
        }
        
        MailBoxFullContent val_13 = val_34.三业七丗丂丑与丆丗();
        val_13.headerLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1807");
        MailBoxFullContent val_15 = val_34.三业七丗丂丑与丆丗();
        val_40 = "";
        val_15.dateLabel.text = "";
        MailBoxChildFullContet val_17 = val_34.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
        val_17.descOrMessageLabel.text = "";
        MailBoxFullContent val_18 = val_34.三业七丗丂丑与丆丗();
        val_18.desc2Label.text = "";
        MailBoxFullContent val_19 = val_34.三业七丗丂丑与丆丗();
        mem2[0] = 1128792064;
        MailBoxFullContent val_20 = val_34.三业七丗丂丑与丆丗();
        val_20.newsPic.enabled = false;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.urlButton, 丏业丟一东丂东丘丛:  false);
        MailBoxChildFullContet val_22 = val_34.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_22.MailBoxUrlSingle, 丏业丟一东丂东丘丛:  false);
        MailBoxChildFullContet val_24 = val_34.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_24.MailBoxCompleteSubcribeButton, 丏业丟一东丂东丘丛:  false);
        MailBoxChildFullContet val_26 = val_34.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_26.MailBoxAllButtons, 丏业丟一东丂东丘丛:  false);
        val_34 = val_34.三业七丗丂丑与丆丗().丛上且丕丐世一丘丛();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_28.MessageRewardContainer, 丏业丟一东丂东丘丛:  false);
        label_2:
        val_37 = 0;
        return (bool)val_37;
        label_14:
        0.丗世丝丁七丏丏丄世();
        0.三丞丐丐丆下且丐丑();
        label_15:
        val_40 = this.丝且与丝丒丟万丁专.丅丙下丈一专万不丆.Count;
        if((this.七三丞丘丟下丛丛不 != false) && ((丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  this.丝且与丝丒丟万丁专.丁且丟丕丛一东丙丞)) != false))
        {
                val_34.业丗丗丐七七丛丙万();
        }
        else
        {
                val_34.丞丟丒丙上丗七丕丂();
        }
        
        this.丝且与丝丒丟万丁专.newsScroll.enabled = (val_40 > 4) ? 1 : 0;
        UnityEngine.Coroutine val_33 = val_34.StartCoroutine(routine:  val_34.丂丛丝丐丗丅丅丏丐());
        val_37 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_37;
        return (bool)val_37;
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
