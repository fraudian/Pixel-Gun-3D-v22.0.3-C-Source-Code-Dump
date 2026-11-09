using UnityEngine;
internal sealed class UniversalRewardOneByOneView : PGBehaviour
{
    // Fields
    private System.Action 丈三下丛丞丝世不丏;
    private System.Action 丄丆丙业世丏与丞丛;
    private ItemRewardView rewardView;
    private ItemCraftBarView itemBarView;
    private TagSpecificObject tagSpecificObject;
    private UnityEngine.GameObject buttonNext;
    private float itemBarDelay;
    private float nextDelay;
    private UnityEngine.GameObject itemsCountHolder;
    private UILabel itemsCountLabel;
    private UILabel infoLabel;
    private UnityEngine.GameObject tapToContinue;
    private float tapToContinueTimer;
    private UnityEngine.AudioClip onSetup;
    private UnityEngine.AudioClip coolnessOne;
    private UnityEngine.AudioClip coolnessTwo;
    private UnityEngine.AudioClip coolnessThree;
    private UnityEngine.AudioClip coolnessFour;
    private UniversalRewardController.与丏下丒与丙丟丝一 丘世不七上且丒丞丅;
    private int 不丛三三专丛一万丝;
    private float 丟丈丕上丒上丌丗世;
    
    // Methods
    internal void 业丗与丗三且丝丏不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈三下丛丞丝世不丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈三下丛丞丝世不丏 != 1152921539485027400);
    
    }
    internal void 丝不丘丛上丕万与七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈三下丛丞丝世不丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈三下丛丞丝世不丏 != 1152921539485163976);
    
    }
    internal void 丘丏丘丄丈且上丕东(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丄丆丙业世丏与丞丛, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丆丙业世丏与丞丛 != 1152921539485300560);
    
    }
    internal void 丁丁丁东业丒下丈业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丄丆丙业世丏与丞丛, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丄丆丙业世丏与丞丛 != 1152921539485437136);
    
    }
    public void Setup(UniversalRewardController.与丏下丒与丙丟丝一 丁东丛丅业七丏丌丑)
    {
        this.丘世不七上且丒丞丅 = 丁东丛丅业七丏丌丑;
        this.不丛三三专丛一万丝 = 0;
        this.gameObject.SetActive(value:  true);
        if(this.丈三下丛丞丝世不丏 != null)
        {
                this.丈三下丛丞丝世不丏.Invoke();
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.onSetup);
        }
        
        this.丛丕丗丅丂上丁丙丐();
    }
    private void 丛丕丗丅丂上丁丙丐()
    {
        System.Action val_11;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonNext, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToContinue, 丏业丟一东丂东丘丛:  false);
        this.丟丈丕上丒上丌丗世 = 0f;
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void UniversalRewardOneByOneView::下三上不丛丂丄七丑()), 丆丐七丅丆丗丛上与:  this.nextDelay);
        int val_11 = this.不丛三三专丛一万丝;
        val_11 = val_11 + 1;
        this.不丛三三专丛一万丝 = val_11;
        val_11 = 1152921539220832272;
        int val_12 = this.不丛三三专丛一万丝;
        val_12 = this.丘世不七上且丒丞丅.丆丌丙丛丄丂丘丟丟.Count - val_12;
        int val_4 = val_12 - 1;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.itemsCountLabel, 丕丗丘丑丛与丑业丒:  val_4);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.itemsCountHolder, 丏业丟一东丂东丘丛:  (val_4 > 0) ? 1 : 0);
        if(this.不丛三三专丛一万丝 < this.丘世不七上且丒丞丅.丆丌丙丛丄丂丘丟丟.Count)
        {
                .丝且与丝丒丟万丁专 = this;
            .丘丂丅且丄丑丞万丟 = this.丘世不七上且丒丞丅.丆丌丙丛丄丂丘丟丟.Item[this.不丛三三专丛一万丝];
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemBarView, 丏业丟一东丂东丘丛:  false);
            this.tagSpecificObject.世业丒万丘丆专丘丐();
            丌东一万丗上丝丌三.丌丛东不丝三丒丌丅(丒丘丏上丙丟丑丕丈:  "UniversalRewardOneByOne_ItemBar");
            System.Action val_9 = null;
            val_11 = val_9;
            val_9 = new System.Action(object:  new UniversalRewardOneByOneView.丄丆丌丌丕丈丆丆业(), method:  System.Void UniversalRewardOneByOneView.丄丆丌丌丕丈丆丆业::丏丝且丗且丑丑丈业());
            一丛丟世丗丈丘丏万 val_10 = 丌东一万丗上丝丌三.七丄丂丆万一与丅丕(丒丘丏上丙丟丑丕丈:  "UniversalRewardOneByOne_ItemBar", 丘丁三丅丆与丆业业:  this.itemBarDelay, 七丐丅专且专七三丆:  val_9);
            this.丘上七一丆丐一丝丘(丗七丟丈三不丕一三:  (UniversalRewardOneByOneView.丄丆丌丌丕丈丆丆业)[1152921539485883664].丘丂丅且丄丑丞万丟);
            return;
        }
        
        this.End();
    }
    public void U_MoveNext()
    {
        this.丛丕丗丅丂上丁丙丐();
    }
    public void End()
    {
        this.gameObject.SetActive(value:  false);
        if(this.丄丆丙业世丏与丞丛 == null)
        {
                return;
        }
        
        this.丄丆丙业世丏与丞丛.Invoke();
    }
    private void 丘上七一丆丐一丝丘(PGCompany.丄与丘丑业专丞七丅 丗七丟丈三不丕一三)
    {
        UnityEngine.AudioClip val_7;
        UnityEngine.AudioClip val_8;
        if((丗七丟丈三不丕一三.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "One")) == false)
        {
            goto label_3;
        }
        
        val_7 = this.coolnessOne;
        goto label_10;
        label_3:
        if((丗七丟丈三不丕一三.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "Two")) == false)
        {
            goto label_6;
        }
        
        val_7 = this.coolnessTwo;
        goto label_10;
        label_6:
        if((丗七丟丈三不丕一三.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "Three")) == false)
        {
            goto label_9;
        }
        
        val_7 = this.coolnessThree;
        goto label_10;
        label_9:
        val_8 = 0;
        if((丗七丟丈三不丕一三.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "Four")) == false)
        {
            goto label_12;
        }
        
        val_7 = this.coolnessFour;
        label_10:
        val_8 = mem[this.coolnessFour];
        label_12:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_8);
    }
    private void 丐丄丘丟丂丆丂丘丏()
    {
        UnityEngine.Debug.LogError(message:  "OnBarAnimationFinish");
        if(this.不丛三三专丛一万丝 >= this.丘世不七上且丒丞丅.丆丌丙丛丄丂丘丟丟.Count)
        {
                return;
        }
        
        this.tagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  val_2.Tag);
        this.万丗不丅下专丈丗七(丘丂丅且丄丑丞万丟:  this.丘世不七上且丒丞丅.丆丌丙丛丄丂丘丟丟.Item[this.不丛三三专丛一万丝]);
    }
    private void 万丗不丅下专丈丗七(PGCompany.丄与丘丑业专丞七丅 丘丂丅且丄丑丞万丟)
    {
        string val_7;
        TagSystem.三与下丘七丘丌丏丄 val_8;
        if(丘丂丅且丄丑丞万丟.ItemParams.不业丙丒丂丞下丆丙() == 80)
        {
                val_7 = "Key_10533";
        }
        else
        {
                val_7 = "Key_10532";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_7));
        val_8 = 丘丂丅且丄丑丞万丟.Tag;
        if((val_8.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "item_rewars.can_create")) != false)
        {
                val_8 = this.infoLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_8, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10530"));
        }
        
        if((丘丂丅且丄丑丞万丟.Tag.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "item_rewars.can_upgrade")) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.infoLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10531"));
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = this.丟丈丕上丒上丌丗世 + val_1;
        this.丟丈丕上丒上丌丗世 = val_1;
        if(val_1 <= this.tapToContinueTimer)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToContinue, 丏业丟一东丂东丘丛:  true);
    }
    public UniversalRewardOneByOneView()
    {
        this.itemBarDelay = Infinityf;
        this.nextDelay = 2f;
        this.tapToContinueTimer = 5f;
        this.不丛三三专丛一万丝 = 0;
    }
    private void 下三上不丛丂丄七丑()
    {
        if(this == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonNext, 丏业丟一东丂东丘丛:  true);
    }

}
