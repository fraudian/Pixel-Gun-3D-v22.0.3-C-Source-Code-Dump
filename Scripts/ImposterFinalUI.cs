using UnityEngine;
public class ImposterFinalUI : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject outroObject;
    public UnityEngine.GameObject defeatObj;
    public UnityEngine.GameObject winObj;
    public UILabel reasonLabel;
    internal UIGrid grid;
    internal PlayerIconImposterModeUI playerIcon;
    private System.Collections.Generic.List<PlayerIconImposterModeUI> 丏丙丁专且丁丒丅三;
    private bool 且丐下世丂上丕东与;
    private UnityEngine.AudioSource impostersWinsSound;
    private UnityEngine.AudioSource crewmenWinSound;
    private System.Collections.Generic.Dictionary<ImposterFinalUI.丌一七丑七丟三丏丐, string> 世丂丂丁与与丁且万;
    
    // Methods
    internal void 上东与丛丞下丈专丈(ImposterFinalUI.丌一七丑七丟三丏丐 丛丄东丅世且丆丝上, bool 三三丅丐丐不业丅丟, bool 业东丞丏丒业万丏丘, System.Collections.Generic.List<丈万且丗丂丝丙一东> 三世丈丆丆丄丗一业)
    {
        var val_23;
        UIGrid val_24;
        var val_25;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.defeatObj, 丏业丟一东丂东丘丛:  (~业东丞丏丒业万丏丘) & 1);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.winObj, 丏业丟一东丂东丘丛:  业东丞丏丒业万丏丘);
        this.reasonLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.世丂丂丁与与丁且万.Item[丛丄东丅世且丆丝上]);
        this.丏丙丁专且丁丒丅三.Add(item:  this.playerIcon);
        val_23 = this.丏丙丁专且丁丒丅三.Count;
        goto label_9;
        label_17:
        this.丏丙丁专且丁丒丅三.Add(item:  不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.playerIcon.gameObject, 丑且不丕与专丄业丙:  this.playerIcon.gameObject).GetComponent<PlayerIconImposterModeUI>());
        val_23 = val_23 + 1;
        label_9:
        val_24 = this.grid;
        if(val_23 < 三世丈丆丆丄丗一业.Count)
        {
            goto label_17;
        }
        
        this.且丐下世丂上丕东与 = true;
        val_25 = 0;
        goto label_18;
        label_36:
        丈万且丗丂丝丙一东 val_12 = 三世丈丆丆丄丗一业.Item[0];
        this.丏丙丁专且丁丒丅三.Item[0].丄丐丁不七丂丁业丌(丒东三丌专丗三丂丟:  (val_12.专丞专丆丄丛丞三丕 == true) ? 1 : 0);
        丈万且丗丂丝丙一东 val_15 = 三世丈丆丆丄丗一业.Item[0];
        this.丏丙丁专且丁丒丅三.Item[0].下丞丛世下丅且丈三(专丛下不丄且丌丛丕:  (val_15.专丛下不丄且丌丛丕 == true) ? 1 : 0);
        丈万且丗丂丝丙一东 val_18 = 三世丈丆丆丄丗一业.Item[0];
        this.丏丙丁专且丁丒丅三.Item[0].丈丑丅上七丑丅一丒(与丟丅七丞且且丛丕:  val_18.与丟丅七丞且且丛丕);
        val_24 = this.丏丙丁专且丁丒丅三.Item[0];
        丈万且丗丂丝丙一东 val_20 = 三世丈丆丆丄丗一业.Item[0];
        val_24.三丅东丕丆丐三丞丄(丞丞下东且丗丄丒丏:  val_20.丒丘丏上丙丟丑丕丈);
        val_25 = 1;
        label_18:
        if(val_25 < 三世丈丆丆丄丗一业.Count)
        {
            goto label_36;
        }
        
        this.丒丙丌丛丁丂上专丒(三三丅丐丐不业丅丟:  三三丅丐丐不业丅丟);
    }
    private void 丒丙丌丛丁丂上专丒(bool 三三丅丐丐不业丅丟)
    {
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(三三丅丐丐不业丅丟 == false)
        {
            goto label_4;
        }
        
        if(this.impostersWinsSound != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        this.impostersWinsSound.Play();
        return;
        label_4:
        if(this.crewmenWinSound != null)
        {
            goto label_6;
        }
        
        goto label_7;
    }
    private void LateUpdate()
    {
        if(this.且丐下世丂上丕东与 == false)
        {
                return;
        }
        
        this.且丐下世丂上丕东与 = false;
        if(this.grid == null)
        {
            
        }
    
    }
    public ImposterFinalUI()
    {
        this.丏丙丁专且丁丒丅三 = new System.Collections.Generic.List<PlayerIconImposterModeUI>();
        System.Collections.Generic.Dictionary<丌一七丑七丟三丏丐, System.String> val_2 = new System.Collections.Generic.Dictionary<丌一七丑七丟三丏丐, System.String>();
        if(val_2 != null)
        {
                val_2.Add(key:  0, value:  "Key_10265");
        }
        else
        {
                val_2.Add(key:  0, value:  "Key_10265");
        }
        
        val_2.Add(key:  1, value:  "Key_10266");
        if(val_2 != null)
        {
                val_2.Add(key:  2, value:  "Key_10267");
        }
        else
        {
                val_2.Add(key:  2, value:  "Key_10267");
        }
        
        val_2.Add(key:  3, value:  "Key_10268");
        val_2.Add(key:  4, value:  "Key_10269");
        this.世丂丂丁与与丁且万 = val_2;
    }

}
