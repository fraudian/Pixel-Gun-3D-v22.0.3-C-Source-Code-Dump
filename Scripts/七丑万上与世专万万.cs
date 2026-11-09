using UnityEngine;
private sealed class ClanLootBoxInfoUI.七丑万上与世专万万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ClanLootBoxInfoUI 丝且与丝丒丟万丁专;
    public PGCompany.三东丏不丗世丅丌丄 丈丒七下世业丄世专;
    private int 与业与一丙下丁丌丂;
    private int 丑世丟丅丝丞世下一;
    private int 丛三万丐且丑且专丙;
    private float 丙丕丒下丑丏丙上丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanLootBoxInfoUI.七丑万上与世专万万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        UnityEngine.GameObject val_30;
        PGCompany.七东万三万丒丏一丁 val_31;
        float val_32;
        var val_33;
        var val_34;
        int val_35;
        int val_36;
        string val_37;
        int val_38;
        var val_39;
        val_30 = this;
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
        val_31 = this.丝且与丝丒丟万丁专.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与();
        if(val_31 == null)
        {
            goto label_8;
        }
        
        if(null == null)
        {
            goto label_7;
        }
        
        goto label_8;
        label_2:
        val_31 = val_30;
        val_32 = this.丙丕丒下丑丏丙上丈;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  24);
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_33 = this.丝且与丝丒丟万丁专.与丞丆丑东东丟丆丌();
            val_34 = this.丝且与丝丒丟万丁专;
        }
        else
        {
                val_33 = 0.与丞丆丑东东丟丆丌();
            val_34 = 0;
        }
        
        val_35 = this.丝且与丝丒丟万丁专.丆丑丆七丏七且不丒;
        val_33.丏丝丘七丕与世丅丆<System.Int32>(丞万丕丏东与丑下丕:  val_35);
        if(this.丝且与丝丒丟万丁专.丆丑丆七丏七且不丒 >= 1)
        {
                val_36 = "chest_info";
            var val_30 = 0;
            do
        {
            val_35 = this.丈丒七下世业丄世专;
            PGCompany.Analytics.一业丗丆世世上丁且.三与丆丏下丐不丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丅丘丌且丈丘丄丗丄:  val_34.与丞丆丑东东丟丆丌(), 丒世丘丘上丆丝东丞:  val_35, 丐丅丒专丛丏上与业:  "chest_info");
            val_30 = val_30 + 1;
        }
        while(val_30 < this.丝且与丝丒丟万丁专.丆丑丆七丏七且不丒);
        
        }
        
        val_31 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_31.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        val_37 = "Free";
        if((this.丈丒七下世业丄世专.业上丙丞丐丄丆丅七().Equals(value:  val_37)) != false)
        {
                val_37 = 0;
            NotificationWindowController.世丛上丕专上且且三(丁丅丈丌丟世丗丗丟:  9);
        }
        
        this.丝且与丝丒丟万丁专.不三丛业下业丈丟一 = false;
        val_30 = this.丝且与丝丒丟万丁专.sliderMultiplyChestBlocer;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_30, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._progressIncreaseGlow, 丏业丟一东丂东丘丛:  false);
        label_3:
        val_38 = 0;
        return (bool)val_38;
        label_7:
        int val_31 = this.丝且与丝丒丟万丁专.丆丑丆七丏七且不丒;
        val_31 = val_31 * ((PGCompany.丁丑上丞业丞丟丛上.丂丘丒丕丑七丙丈丑(与丁专世丈且东丌丅:  val_31)) + val_31.丂万丞与丈丙丅丝七());
        this.与业与一丙下丁丌丂 = val_31;
        this.丑世丟丅丝丞世下一 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丏丘丒丗丛丁且七丐();
        this.丛三万丐且丑且专丙 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丗丕丂丅与七丕丅丝();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._progressIncreaseGlow, 丏业丟一东丂东丘丛:  true);
        val_31 = val_30;
        this.丙丕丒下丑丏丙上丈 = 0f;
        val_32 = 0f;
        label_10:
        if(val_32 < 0)
        {
            goto label_42;
        }
        
        label_8:
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = 2;
        val_38 = 1;
        return (bool)val_38;
        label_42:
        float val_32 = this.丙丕丒下丑丏丙上丈;
        float val_20 = UnityEngine.Time.unscaledDeltaTime;
        val_32 = val_32 + val_20;
        this.丙丕丒下丑丏丙上丈 = val_32;
        val_20 = val_32 * (float)this.与业与一丙下丁丌丂;
        val_20 = val_20 / this.丝且与丝丒丟万丁专._progressAnimationTime;
        val_31 = this.丝且与丝丒丟万丁专._progressFill;
        val_32 = UnityEngine.Mathf.Clamp(value:  val_20, min:  0f, max:  (float)this.与业与一丙下丁丌丂);
        if(val_31 != 0)
        {
                val_39 = null;
            val_36 = this.丑世丟丅丝丞世下一;
            val_35 = this.丛三万丐且丑且专丙;
            val_39 = null;
            float val_24 = UnityEngine.Mathf.Max(a:  (float)val_36, b:  UnityEngine.Mathf.Epsilon);
            val_24 = ((float)val_35 + (int)val_32) / val_24;
            float val_26 = UnityEngine.Mathf.Clamp01(value:  val_24);
            val_3 = 0;
            this.丝且与丝丒丟万丁专._progressFill.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if(this.丝且与丝丒丟万丁专._progressLabel != null)
        {
                int val_33 = this.丛三万丐且丑且专丙;
            val_36 = 1152921504622075904;
            val_33 = val_33 + (int)val_32;
            val_3 = val_33;
            val_35 = val_3;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.丝且与丝丒丟万丁专._progressLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  this.丝且与丝丒丟万丁专.丟且下丂丛世丁丅丟, arg0:  val_3, arg1:  this.丑世丟丅丝丞世下一));
        }
        
            val_31 = this.丝且与丝丒丟万丁专._progressIncreaseLabel;
            if(val_31 != null)
        {
                int val_34 = this.与业与一丙下丁丌丂;
            val_34 = val_34 - (int)val_32;
            val_3 = val_34;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_31, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  this.丝且与丝丒丟万丁专.不东丏丘丏世丒下丘, arg0:  val_3));
        }
        
        }
        
        val_38 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_38;
        return (bool)val_38;
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
