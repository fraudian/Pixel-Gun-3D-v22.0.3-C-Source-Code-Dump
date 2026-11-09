using UnityEngine;
internal sealed class CW_VandalsView : PGBehaviour
{
    // Fields
    private 不上丌世万丁丝丏丆 丐丌丞东上万万丈丂;
    private UIWidget titleBG;
    private UILabel title;
    private UILabel timer;
    private UITextureMasked texture;
    private UIWidget topContainer;
    private PGCompany.TimerUI leftTime;
    private PGCompany.GameTaskView taskView;
    private UILabel rewardLabel;
    private UnityEngine.GameObject enableIfActive;
    private UnityEngine.GameObject enableIfNotActive;
    private string textureName;
    private UnityEngine.Color titleBGColor;
    private UILabel vandalsDicription;
    private UIWidget widget;
    private UnityEngine.GameObject containerModuleTables;
    private ModulesTableUI modulesTableUIForEnemy;
    private ModulesTableUI modulesTableUIForBosses;
    
    // Properties
    internal int 丐丌下丛丄丏业丘且 { get; }
    
    // Methods
    internal int 世万丞丒丈且三与丈()
    {
        if(this.widget == 0)
        {
                return 0;
        }
        
        if(this.widget != null)
        {
                return this.widget.height;
        }
        
        return this.widget.height;
    }
    internal void 下与丞三丅丛丄七丕(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘)
    {
        System.Collections.Generic.IEnumerable<TSource> val_9;
        var val_13;
        UnityEngine.GameObject val_31;
        object val_32;
        this.丐丌丞东上万万丈丂 = 丌丝万上丅丒一丈丘;
        this.titleBG.color = new UnityEngine.Color() {r = this.titleBGColor, g = V9.16B, b = V10.16B, a = V11.16B};
        this.texture.isOfferTexture = false;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "LevelLoadings/"("LevelLoadings/") + this.textureName));
        this.enableIfActive.SetActive(value:  false);
        val_31 = this.enableIfNotActive;
        val_31.SetActive(value:  false);
        if(丌丝万上丅丒一丈丘.丛丆东上上丗丗业丕() != PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂())
        {
            goto label_10;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.title, 丕丗丘丑丛与丑业丒:  "");
        PGCompany.与丐业一丂丗与七丟 val_6 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.与丐业一丂丗与七丟>(且下丕七丙丗丄不七:  1);
        if(val_6 == null)
        {
            goto label_14;
        }
        
        this.enableIfActive.SetActive(value:  true);
        this.taskView.业不丝丄丙丌丌丈丄(万不且且丛丆东丒业:  val_6.下三下东业丘且丟业(), 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        this.taskView.丝一丅丆三东丂丞七();
        PGCompany.ClanWarEventConfig val_8 = val_6.世丈丁业丛上丘丗丐();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rewardLabel, 丕丗丘丑丛与丑业丒:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_9).丂丁丏一丙丛业且丌());
        PGCompany.ClanWarEventConfig val_12 = val_6.世丈丁业丛上丘丗丐();
        if(val_13.Count >= 2)
        {
                PGCompany.ClanWarEventConfig val_15 = val_6.世丈丁业丛上丘丗丐();
            if(val_9.Item[1] != null)
        {
                PGCompany.ClanWarEventConfig val_17 = val_6.世丈丁业丛上丘丗丐();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rewardLabel, 丕丗丘丑丛与丑业丒:  val_9.Item[1].丂丁丏一丙丛业且丌());
        }
        
        }
        
        if(this.leftTime != null)
        {
                this.leftTime.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_6.丘丒不不丌丘下丒一(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        
        if(val_6.下三下东业丘且丟业() == null)
        {
            goto label_30;
        }
        
        val_32 = val_6.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
        goto label_32;
        label_10:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.containerModuleTables, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.title, 丕丗丘丑丛与丑业丒:  "");
        goto label_49;
        label_14:
        this.enableIfNotActive.SetActive(value:  true);
        if(this.leftTime == null)
        {
            goto label_39;
        }
        
        this.leftTime.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丈丏丗万丑丕丗东丘(且下丕七丙丗丄不七:  1), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        goto label_39;
        label_30:
        val_32 = 1;
        label_32:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.vandalsDicription, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8463"), arg0:  val_32));
        label_39:
        val_31 = 1152921504848912384;
        if(this.modulesTableUIForEnemy != 0)
        {
                if(this.modulesTableUIForBosses != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.containerModuleTables, 丏业丟一东丂东丘丛:  true);
            this.modulesTableUIForEnemy.丙不丑丆丂三三丞下(丐丐丄丞丏丗专丏与:  false);
            this.modulesTableUIForBosses.丙不丑丆丂三三丞下(丐丐丄丞丏丗专丏与:  true);
        }
        
        }
        
        label_49:
        this.gameObject.SetActive(value:  true);
    }
    public void DEV_TaskIncrement()
    {
    
    }
    public void DEV_TaskComplete()
    {
    
    }
    public CW_VandalsView()
    {
        this.textureName = "Loading_Dungeon_dead_city";
    }

}
