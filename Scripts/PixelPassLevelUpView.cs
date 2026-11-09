using UnityEngine;
internal sealed class PixelPassLevelUpView : SimpleBunner
{
    // Fields
    private static System.Action 丛丄业丘不丆丄三丞;
    private static System.Action 业丙丘丈七不下下丐;
    private float animationTime;
    private float lerpSpeed;
    private UILabel lavelLabel;
    private UILabel oldLevelLabel;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableOnEndAnimation;
    private bool 丐丙丕丘丗丐不丞丅;
    private int 丘丆丘丞丅上专三丌;
    private int 丙与丛下丂丗七丐丗;
    
    // Methods
    internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  PixelPassLevelUpView.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  PixelPassLevelUpView.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 万专丆且七丈业丅丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  PixelPassLevelUpView.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PixelPassLevelUpView.业丙丘丈七不下下丐 != 1152921505241780232);
    
    }
    internal static void 丟丑丟丑丂丄丕丆丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  PixelPassLevelUpView.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(PixelPassLevelUpView.业丙丘丈七不下下丐 != 1152921505241780232);
    
    }
    internal void 下与丞三丅丛丄七丕(int 与丗丟丝丞上东且丞, int 丁丅丄丗不丁丟丈世)
    {
        this.丘丆丘丞丅上专三丌 = 与丗丟丝丞上东且丞;
        this.丙与丛下丂丗七丐丗 = 丁丅丄丗不丁丟丈世;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.oldLevelLabel, 丕丗丘丑丛与丑业丒:  与丗丟丝丞上东且丞);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.lavelLabel, 丕丗丘丑丛与丑业丒:  this.丙与丛下丂丗七丐丗);
        this.丐丙丕丘丗丐不丞丅 = true;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnEndAnimation, 丏业丟一东丂东丘丛:  false);
        this.Show();
        UnityEngine.Coroutine val_2 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  new System.Action(object:  this, method:  System.Void PixelPassLevelUpView::丗丅丄丗丙世万下丗()), 丆丐七丅丆丗丛上与:  this.animationTime);
        if(PixelPassLevelUpView.业丙丘丈七不下下丐 == null)
        {
                return;
        }
        
        PixelPassLevelUpView.业丙丘丈七不下下丐.Invoke();
    }
    public override void Hide()
    {
        if(this.丐丙丕丘丗丐不丞丅 != false)
        {
                return;
        }
        
        this.Hide();
        if(PixelPassLevelUpView.丛丄业丘不丆丄三丞 == null)
        {
                return;
        }
        
        PixelPassLevelUpView.丛丄业丘不丆丄三丞.Invoke();
    }
    public PixelPassLevelUpView()
    {
        this.animationTime = 2.5f;
        this.lerpSpeed = 2.5f;
    }
    private void 丗丅丄丗丙世万下丗()
    {
        if(this == 0)
        {
                return;
        }
        
        this.丐丙丕丘丗丐不丞丅 = false;
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnEndAnimation, 丏业丟一东丂东丘丛:  true);
    }

}
