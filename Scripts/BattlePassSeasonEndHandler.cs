using UnityEngine;
internal class BattlePassSeasonEndHandler : BannerWindow
{
    // Fields
    private PGCompany.BattlePass.BPSeasonEnd 世丌专业一三与丘丏;
    
    // Methods
    public override void Show()
    {
        this.Show();
        if((Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝()) == null)
        {
            goto label_2;
        }
        
        if(this.世丌专业一三与丘丏 == 0)
        {
                string val_4 = PGCompany.BattlePass.上丕丁专三丗丝万丆.丏一专东丏丙丐丟丞(丟丈一下东业一丝丆:  "BPSeasonEnd");
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != true)
        {
                UnityEngine.GameObject val_6 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  val_4);
            if(val_6 != 0)
        {
                int val_9 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            UnityEngine.GameObject val_10 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_6, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            PGCompany.BattlePass.BPSeasonEnd val_11 = val_10.GetComponent<PGCompany.BattlePass.BPSeasonEnd>();
            this.世丌专业一三与丘丏 = val_11;
            if(val_11 == 0)
        {
                丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_10);
        }
        
        }
        
        }
        
        }
        
        if(this.世丌专业一三与丘丏 == 0)
        {
            goto label_22;
        }
        
        this = this.世丌专业一三与丘丏.gameObject;
        this.SetActive(value:  true);
        return;
        label_2:
        this.HideSelf();
        return;
        label_22:
        this.HideSelf();
    }
    public override void Hide()
    {
        if(this.世丌专业一三与丘丏 != 0)
        {
                if(this.世丌专业一三与丘丏.gameObject != 0)
        {
                this.世丌专业一三与丘丏.gameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  this.世丌专业一三与丘丏.gameObject);
            this.世丌专业一三与丘丏 = 0;
        }
        
        }
        
        this.Hide();
    }
    public BattlePassSeasonEndHandler()
    {
    
    }

}
