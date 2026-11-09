using UnityEngine;
private sealed class LevelCompleteScript.世丕丌丗业与丂丕丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LevelCompleteScript 丝且与丝丒丟万丁专;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丈丒丈丝丅业世丑丗;
    private UnityEngine.WaitForSeconds 业一下丝丗丌与丙丘;
    private int 上与丆七丌上上与三;
    private int 丌丈上丅丒丛丝业丄;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCompleteScript.世丕丌丗业与丂丕丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 49;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        System.Collections.IEnumerator val_49;
        var val_50;
        var val_51;
        float val_52;
        float val_53;
        int val_54;
        int val_55;
        var val_56;
        var val_57;
        int val_58;
        var val_59;
        var val_60;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_188;
        }
        
        this.丗丏丅丕丆世丁专丟 = -3;
        val_49 = this.丝且与丝丒丟万丁专.TryToShowExpiredBanner();
        UnityEngine.Coroutine val_2 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  val_49);
        this.丈丒丈丝丅业世丑丗 = 0;
        this.业一下丝丗丌与丙丘 = 0;
        this.一世丕丕业且且丅丌();
        goto label_188;
        label_1:
        this.丗丏丅丕丆世丁专丟 = -3;
        this.丝且与丝丒丟万丁专.DisplayLevelResultIsRunning = true;
        this.丝且与丝丒丟万丁专.menuButton.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.retryButton.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.nextButton.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.shopView.专丌丅下万丐三丗丗();
        this.丝且与丝丒丟万丁专.丐丂三丑世与丘丆丑 = false;
        this.丝且与丝丒丟万丁专.万丙丙丆上一丂丈丝 = false;
        System.Collections.Generic.List<UnityEngine.GameObject> val_3 = new System.Collections.Generic.List<UnityEngine.GameObject>(capacity:  3);
        this.丈丒丈丝丅业世丑丗 = null;
        val_50 = 1152921504848912384;
        var val_50 = 0;
        do
        {
            UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝且与丝丒丟万丁专.darkStarPrototypeSprite);
            val_4.transform.parent = this.丝且与丝丒丟万丁专.darkStarPrototypeSprite.transform.parent;
            UnityEngine.Vector3 val_10 = this.丝且与丝丒丟万丁专.darkStarPrototypeSprite.transform.localPosition;
            float val_49 = 0f;
            val_49 = val_49 * 140f;
            val_49 = val_49 + (-140f);
            val_4.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_51 = this.丝且与丝丒丟万丁专.darkStarPrototypeSprite.transform;
            UnityEngine.Vector3 val_13 = val_51.localScale;
            val_52 = val_13.x;
            val_53 = val_13.z;
            val_4.transform.localScale = new UnityEngine.Vector3() {x = val_52, y = val_13.y, z = val_53};
            val_4.SetActive(value:  true);
            this.丈丒丈丝丅业世丑丗.Add(item:  val_4);
            val_50 = val_50 + 1;
        }
        while(val_50 != 3);
        
        val_49 = new UnityEngine.WaitForSeconds();
        val_49 = new UnityEngine.WaitForSeconds(seconds:  0.7f);
        val_54 = 0;
        val_55 = this.丌丈上丅丒丛丝业丄;
        this.业一下丝丗丌与丙丘 = val_49;
        this.上与丆七丌上上与三 = 0;
        this.丌丈上丅丒丛丝业丄 = 0;
        goto label_30;
        label_2:
        this.丗丏丅丕丆世丁专丟 = -3;
        val_50 = 1152921504848912384;
        UnityEngine.GameObject val_15 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝且与丝丒丟万丁专.brightStarPrototypeSprite);
        val_15.transform.parent = this.丝且与丝丒丟万丁专.brightStarPrototypeSprite.transform.parent;
        UnityEngine.Vector3 val_22 = this.丈丒丈丝丅业世丑丗.Item[this.上与丆七丌上上与三].transform.localPosition;
        val_15.transform.localPosition = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
        UnityEngine.Vector3 val_26 = this.丈丒丈丝丅业世丑丗.Item[this.上与丆七丌上上与三].transform.localScale;
        val_15.transform.localScale = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
        val_15.SetActive(value:  true);
        UnityEngine.Object.Destroy(obj:  this.丈丒丈丝丅业世丑丗.Item[this.上与丆七丌上上与三]);
        UnityEngine.GameObject val_28 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.丝且与丝丒丟万丁专.checkboxSpritePrototype);
        val_28.transform.parent = this.丝且与丝丒丟万丁专.checkboxSpritePrototype.transform.parent;
        UnityEngine.Vector3 val_34 = this.丝且与丝丒丟万丁专.checkboxSpritePrototype.transform.localPosition;
        UnityEngine.Vector3 val_36 = this.丝且与丝丒丟万丁专.checkboxSpritePrototype.transform.localPosition;
        val_55 = this;
        UnityEngine.Vector3 val_38 = this.丝且与丝丒丟万丁专.checkboxSpritePrototype.transform.localPosition;
        float val_51 = -45f;
        float val_52 = (float)this.丌丈上丅丒丛丝业丄;
        val_51 = val_52 * val_51;
        val_52 = val_36.y + val_51;
        val_28.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_51 = this.丝且与丝丒丟万丁专.checkboxSpritePrototype.transform;
        UnityEngine.Vector3 val_41 = val_51.localScale;
        val_52 = val_41.x;
        val_53 = val_41.z;
        val_28.transform.localScale = new UnityEngine.Vector3() {x = val_52, y = val_41.y, z = val_53};
        val_28.SetActive(value:  true);
        val_49 = this.丝且与丝丒丟万丁专.starClips;
        if((val_49 != null) && (this.上与丆七丌上上与三 < this.丝且与丝丒丟万丁专.starClips.Length))
        {
                val_49 = val_49[this.上与丆七丌上上与三];
            if(val_49 != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_49 = this.丝且与丝丒丟万丁专.starClips[this.上与丆七丌上上与三];
            UnityEngine.AudioSource val_44 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_49);
        }
        
        }
        
        }
        
        int val_53 = this.上与丆七丌上上与三;
        val_53 = val_53 + 1;
        this.上与丆七丌上上与三 = val_53;
        label_106:
        val_54 = this.丌丈上丅丒丛丝业丄 + 1;
        this.丌丈上丅丒丛丝业丄 = val_54;
        label_30:
        if(val_54 > 2)
        {
                UnityEngine.Object.Destroy(obj:  this.丝且与丝丒丟万丁专.brightStarPrototypeSprite);
            UnityEngine.Object.Destroy(obj:  this.丝且与丝丒丟万丁专.darkStarPrototypeSprite);
            this.丝且与丝丒丟万丁专.menuButton.SetActive(value:  true);
            this.丝且与丝丒丟万丁专.retryButton.SetActive(value:  true);
            this.丝且与丝丒丟万丁专.nextButton.SetActive(value:  true);
            val_49 = this.丝且与丝丒丟万丁专.shopView;
            val_49.业下丛七业丆丛万丂();
            this.丝且与丝丒丟万丁专.丐丂三丑世与丘丆丑 = FacebookController.且丈丄一丁丞丒丑东();
            this.丝且与丝丒丟万丁专.万丙丙丆上一丂丈丝 = TwitterController.上业丗丛三丕丒丗丙();
            if(this.丝且与丝丒丟万丁专.丆世世专丄丑丂丂且 != false)
        {
                val_49 = 1152921505171275776;
            val_56 = null;
            val_56 = null;
            CoinsMessage.丄丝世丒一下丙丗不(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丌丒丝东丌下丕丁丅:  2);
        }
        
            if(this.丝且与丝丒丟万丁专.丑丛丆丙丟与下三下 != false)
        {
                val_57 = null;
            val_57 = null;
            CoinsMessage.丄丝世丒一下丙丗不(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  2);
        }
        
            this.丗丏丅丕丆世丁专丟 = 2;
            val_58 = 1;
            this.丒上七丌业七丟与丐 = this.业一下丝丗丌与丙丘;
            return (bool)val_58;
        }
        
        if(val_54 != 1)
        {
            goto label_99;
        }
        
        val_49 = 1152921505169678336;
        val_59 = null;
        val_59 = null;
        if(丅丌丝丘丐不丒丄专.三与且上丘丞上丕下 == false)
        {
            goto label_106;
        }
        
        val_54 = this.丌丈上丅丒丛丝业丄;
        label_99:
        if(val_54 != 2)
        {
            goto label_103;
        }
        
        val_49 = 1152921505169678336;
        val_60 = null;
        val_60 = null;
        if(丅丌丝丘丐不丒丄专.上丏丗丑丏丕且世上 == false)
        {
            goto label_106;
        }
        
        label_103:
        val_58 = 1;
        this.丗丏丅丕丆世丁专丟 = val_58;
        this.丒上七丌业七丟与丐 = this.业一下丝丗丌与丙丘;
        return (bool)val_58;
        label_188:
        val_58 = 0;
        return (bool)val_58;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.DisplayLevelResultIsRunning = false;
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
