using UnityEngine;
internal sealed class ClanBuildingPointsView : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView itemView;
    private UILabel currentUpgrade_Label;
    private UILabel currentNextUpgrade_Label;
    private UILabel currentPoints_Label;
    private UISprite currentPoints_Bar;
    private ClanBuildingGraphicView buildingGraphicView;
    private UnityEngine.GameObject _blinkObject;
    private float _blinkTime;
    internal PGCompany.丏丌丝丕丐七丈且丒 丕万丌世丆下丈丟与;
    private int 丙丝丗万丆丏世丕东;
    private UnityEngine.Coroutine 世丛丙丌丙丘与万业;
    
    // Methods
    public void Setup(PGCompany.丏丌丝丕丐七丈且丒 下丅丙一丂丗丅丝七)
    {
        UILabel val_12;
        var val_13;
        this.丕万丌世丆下丈丟与 = 下丅丙一丂丗丅丝七;
        if(下丅丙一丂丗丅丝七 == null)
        {
            goto label_1;
        }
        
        this.buildingGraphicView.丛不丈不丙丟不三上 = 下丅丙一丂丗丅丝七;
        this.buildingGraphicView.UpdateView();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentUpgrade_Label, 丕丗丘丑丛与丑业丒:  下丅丙一丂丗丅丝七.丁丕丁三丁丗不三丟());
        int val_2 = 下丅丙一丂丗丅丝七.且丆丟业丞丕丑上且();
        if(下丅丙一丂丗丅丝七.丙丅丗丏丆丆世世丙() == false)
        {
            goto label_5;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentPoints_Label, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} / {1}", arg0:  val_2, arg1:  下丅丙一丂丗丅丝七.丏丈丁专专丘丒丂丂()));
        float val_12 = (float)val_2;
        val_12 = val_12 / (float)下丅丙一丂丗丅丝七.丏丈丁专专丘丒丂丂();
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this.currentPoints_Bar, 丙业与丙丗丝不丈东:  val_12);
        val_12 = this.currentNextUpgrade_Label;
        val_13 = null;
        int val_8 = 下丅丙一丂丗丅丝七.丁丕丁三丁丗不三丟() + 1;
        goto label_8;
        label_1:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentUpgrade_Label, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentPoints_Label, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this.currentPoints_Bar, 丙业与丙丗丝不丈东:  0f);
        return;
        label_5:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentPoints_Label, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  this.currentPoints_Bar, 丙业与丙丗丝不丈东:  1f);
        val_12 = this.currentNextUpgrade_Label;
        val_13 = null;
        label_8:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_12, 丕丗丘丑丛与丑业丒:  下丅丙一丂丗丅丝七.丁丕丁三丁丗不三丟());
        if(this.itemView != 0)
        {
                this.itemView.Setup(与且专丈不万东一万:  下丅丙一丂丗丅丝七);
        }
        
        if(this._blinkObject == 0)
        {
                return;
        }
        
        if(((this.丙丝丗万丆丏世丕东 & 2147483648) == 0) && (val_2 > this.丙丝丗万丆丏世丕东))
        {
                this.世丅丟专丄丘万丒丟();
        }
        
        this.丙丝丗万丆丏世丕东 = val_2;
    }
    internal void 世丅丟专丄丘万丒丟()
    {
        if(this.世丛丙丌丙丘与万业 != null)
        {
                this.StopCoroutine(routine:  this.世丛丙丌丙丘与万业);
        }
        
        if(this._blinkObject == 0)
        {
                return;
        }
        
        this.世丛丙丌丙丘与万业 = this.StartCoroutine(routine:  this.丛丒丝下业丐丝上七());
    }
    private System.Collections.IEnumerator 丛丒丝下业丐丝上七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanBuildingPointsView.下丄丗丑下业一三丝();
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._blinkObject, 丏业丟一东丂东丘丛:  false);
    }
    private void OnDisable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._blinkObject, 丏业丟一东丂东丘丛:  false);
    }
    public ClanBuildingPointsView()
    {
        this._blinkTime = 3f;
        this.丙丝丗万丆丏世丕东 = 0;
    }

}
