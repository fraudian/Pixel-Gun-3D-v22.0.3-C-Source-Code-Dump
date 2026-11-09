using UnityEngine;
public class EggIncubatorController : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject eggTexture;
    private UnityEngine.GameObject readyParticles;
    private UnityEngine.GameObject startParticles;
    private UnityEngine.GameObject emptyTexture;
    private UnityEngine.GameObject startTexture;
    private UnityEngine.GameObject startTexture2;
    private UnityEngine.GameObject pauseTexture;
    private UnityEngine.GameObject pauseTexture2;
    private UILabel labelTimer;
    private UISprite panelColor;
    private UIToggle selectedToggle;
    private UnityEngine.GameObject createEffect;
    private UnityEngine.GameObject connectingWaiting;
    private UnityEngine.AudioClip eggSound;
    private EggIncubatorController.业丐七东丘专丏丟丁 丟丄丈上丌东丑丝三;
    private EggIncubatorController.业丐七东丘专丏丟丁 且东丁丄业世丞丁不;
    private UIBasicSprite icon;
    protected const string 丂丐丌一丏丄专七东 = "Unlit/TransparentRGBMasked";
    
    // Properties
    public UIBasicSprite 丛丙丂丝不丏上东不 { get; }
    
    // Methods
    public UIBasicSprite get_Icon()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.icon);
        this.icon = val_1;
        return val_1;
    }
    private void OnDisable()
    {
        this.StopCoroutine(routine:  this.丝丂丕东专世丅丝丁());
    }
    public void UpdateState(EggIncubatorController.业丐七东丘专丏丟丁 丏业丟一东丂东丘丛)
    {
        this.丟丄丈上丌东丑丝三 = 丏业丟一东丂东丘丛;
        this.且东丁丄业世丞丁不 = this.丟丄丈上丌东丑丝三;
        this.UpdateState();
    }
    public void ActiveStartParticles()
    {
        if(this.startParticles == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startParticles, 丏业丟一东丂东丘丛:  true);
    }
    public void ShowCreate()
    {
        if(this.createEffect == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.createEffect, 丏业丟一东丂东丘丛:  true);
    }
    public void UpdateState()
    {
        UnityEngine.GameObject val_39 = this;
        if(this.createEffect != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.createEffect, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.eggTexture != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eggTexture, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.emptyTexture != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.emptyTexture, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.startTexture != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startTexture, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.startTexture2 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startTexture2, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.pauseTexture != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.pauseTexture, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.pauseTexture2 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.pauseTexture2, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.startParticles != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startParticles, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.丟丄丈上丌东丑丝三 > 4)
        {
                return;
        }
        
        var val_39 = 106038500 + (this.丟丄丈上丌东丑丝三) << 2;
        val_39 = val_39 + 106038500;
        goto (106038500 + (this.丟丄丈上丌东丑丝三) << 2 + 106038500);
    }
    private void OnClick()
    {
        bool val_1 = this.selectedToggle.value;
    }
    private void OnDoubleClick()
    {
    
    }
    public void OnIncubatorClick()
    {
    
    }
    private System.Collections.IEnumerator 丝丂丕东专世丅丝丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new EggIncubatorController.丌丑下丁丙丐丐一丏();
    }
    public EggIncubatorController()
    {
    
    }

}
