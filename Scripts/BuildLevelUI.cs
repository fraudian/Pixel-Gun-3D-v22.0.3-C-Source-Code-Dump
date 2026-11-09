using UnityEngine;
public class BuildLevelUI : PGBehaviour
{
    // Fields
    private 世专丙丟且丗丄丆丌 上丗丝世世丝东丌上;
    private UILabel levelLabel;
    private UILabel expPointsLabel;
    private UISprite expPointsBar;
    private UISprite expPointsBarGain;
    
    // Methods
    private void OnEnable()
    {
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildLevelUI::东丒不七丝万丌丄三()));
    }
    private void OnDisable()
    {
        ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildLevelUI::东丒不七丝万丌丄三()));
    }
    internal void 丈且东丑丂且万丒丅(世专丙丟且丗丄丆丌 丏丛下与丌且丅丐一)
    {
        世专丙丟且丗丄丆丌 val_16;
        var val_17;
        System.Action<System.Int32> val_18;
        val_16 = this.上丗丝世世丝东丌上;
        if(val_16 != null)
        {
                val_16.丑丈丘专丒七三专丙(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::丄丗丒不丏丒丅丌丕(int 丅专与丒丈丗丒丘丌)));
            this.上丗丝世世丝东丌上.丛丝万丕丆丘一下与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::上丄丐丞丄与下丄丆(int 丈丘丝一丗下丈丐不)));
            this.上丗丝世世丝东丌上.丑丈丘专丒七三专丙(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::丙万丑丛上万且丒丙(int 下丝丘丁专丐丅丛丝)));
            val_16 = Base_BuildingUI.instance;
            if(val_16 != 0)
        {
                Base_BuildingUI.instance.丝丈专且丆业一丄丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildLevelUI::丙万丑丛上万且丒丙()));
            Base_BuildingUI.instance.丄专丏丅丗丐丏万专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildLevelUI::丘丕丆丑丝丟三丁东()));
            val_16 = Base_BuildingUI.instance;
            val_16.丑丕一丁专一三且丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildLevelUI::丘丕丆丑丝丟三丁东()));
        }
        
        }
        
        this.上丗丝世世丝东丌上 = 丏丛下与丌且丅丐一;
        if(丏丛下与丌且丅丐一 == null)
        {
                return;
        }
        
        System.Action<System.Int32> val_8 = null;
        val_17 = 1152921524331627568;
        val_8 = new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::丄丗丒不丏丒丅丌丕(int 丅专与丒丈丗丒丘丌));
        丏丛下与丌且丅丐一.业丂丕丗丄丅三一丝(丙业与丙丗丝不丈东:  val_8);
        this.上丗丝世世丝东丌上.丂丆丒丟七丐丒丘上(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::上丄丐丞丄与下丄丆(int 丈丘丝一丗下丈丐不)));
        this.上丗丝世世丝东丌上.业丂丕丗丄丅三一丝(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::丙万丑丛上万且丒丙(int 下丝丘丁专丐丅丛丝)));
        System.Action<System.Int32> val_11 = null;
        val_18 = val_11;
        val_11 = new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::丙万丑丛上万且丒丙(int 下丝丘丁专丐丅丛丝));
        this.上丗丝世世丝东丌上.丂丆丒丟七丐丒丘上(丙业与丙丗丝不丈东:  val_11);
        this.丘丕丆丑丝丟三丁东();
        if(Base_BuildingUI.instance != 0)
        {
                val_17 = 1152921504615739392;
            Base_BuildingUI.instance.丐丗世三丝丞专三一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildLevelUI::丙万丑丛上万且丒丙()));
            Base_BuildingUI.instance.丌丐与丙东万上丛东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void BuildLevelUI::丘丕丆丑丝丟三丁东()));
            System.Action val_15 = null;
            val_18 = val_15;
            val_15 = new System.Action(object:  this, method:  System.Void BuildLevelUI::丘丕丆丑丝丟三丁东());
            Base_BuildingUI.instance.世业丐丏丗业丟一上(丙业与丙丗丝不丈东:  val_15);
        }
        
        this.东丒不七丝万丌丄三();
    }
    private void OnDestroy()
    {
        if(this.上丗丝世世丝东丌上 == null)
        {
                return;
        }
        
        this.上丗丝世世丝东丌上.丑丈丘专丒七三专丙(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::丄丗丒不丏丒丅丌丕(int 丅专与丒丈丗丒丘丌)));
        this.上丗丝世世丝东丌上.丛丝万丕丆丘一下与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void BuildLevelUI::上丄丐丞丄与下丄丆(int 丈丘丝一丗下丈丐不)));
    }
    private void 丄丗丒不丏丒丅丌丕(int 丅专与丒丈丗丒丘丌)
    {
        this.东丒不七丝万丌丄三();
    }
    private void 上丄丐丞丄与下丄丆(int 丈丘丝一丗下丈丐不)
    {
        this.东丒不七丝万丌丄三();
    }
    private void 东丒不七丝万丌丄三()
    {
        UISprite val_11;
        string val_12;
        val_11 = this;
        if(this.上丗丝世世丝东丌上 == null)
        {
                return;
        }
        
        this.levelLabel.text = this.上丗丝世世丝东丌上.丞丞丘业东丙丏七丌() + 1.ToString();
        RootBuildingLevelData val_4 = this.上丗丝世世丝东丌上.不丒丂丂丂世丒与不();
        if(this.上丗丝世世丝东丌上 == null)
        {
            goto label_4;
        }
        
        if(val_4 == null)
        {
            goto label_5;
        }
        
        label_10:
        this.expPointsLabel.text = this.上丗丝世世丝东丌上.丅丕丆丞丗丒专丏下() + "/"("/") + val_4.pointsForThisLevel;
        val_11 = this.expPointsBar;
        val_12 = val_4.pointsForThisLevel;
        float val_11 = (float)this.上丗丝世世丝东丌上.丅丕丆丞丗丒专丏下();
        val_11 = val_11 / (float)val_12;
        goto label_9;
        label_4:
        if(val_4 != null)
        {
            goto label_10;
        }
        
        label_5:
        RootBuildingLevelData val_8 = this.上丗丝世世丝东丌上.丞丘丕丈丄丛且丝东();
        RootBuildingLevelData val_9 = this.上丗丝世世丝东丌上.丞丘丕丈丄丛且丝东();
        val_12 = val_8.pointsForThisLevel + "/"("/") + val_9.pointsForThisLevel;
        this.expPointsLabel.text = val_12;
        val_11 = this.expPointsBar;
        label_9:
        val_11.fillAmount = 1f;
    }
    private void 丙万丑丛上万且丒丙(int 下丝丘丁专丐丅丛丝)
    {
        this.丙万丑丛上万且丒丙(不且丟丏专丟下丈丒:  true);
    }
    private void 丙万丑丛上万且丒丙()
    {
        this.丙万丑丛上万且丒丙(不且丟丏专丟下丈丒:  false);
    }
    private void 丙万丑丛上万且丒丙(bool 不且丟丏专丟下丈丒)
    {
        UISprite val_10;
        if(this.上丗丝世世丝东丌上 == null)
        {
                return;
        }
        
        val_10 = this.expPointsBarGain;
        if(val_10 == 0)
        {
                return;
        }
        
        val_10 = this.上丗丝世世丝东丌上.丅丕丆丞丗丒专丏下();
        RootBuildingLevelData val_3 = this.上丗丝世世丝东丌上.不丒丂丂丂世丒与不();
        this.expPointsBarGain.fillAmount = 0f;
        if(null == 0)
        {
                return;
        }
        
        if(IsPurchased == false)
        {
                return;
        }
        
        if(丈业丂不三丌不丂丁().丟不一丌丘万丛东业() != 0)
        {
                return;
        }
        
        if(不且丟丏专丟下丈丒 != false)
        {
                int val_7 = NextNextUpRewardPoints;
        }
        
        float val_10 = (float)NextUpRewardPoints + val_10;
        val_10 = val_10 / (float)val_3.pointsForThisLevel;
        this.expPointsBarGain.fillAmount = val_10;
    }
    private void 丘丕丆丑丝丟三丁东()
    {
        if(this.expPointsBarGain == 0)
        {
                return;
        }
        
        this.expPointsBarGain.fillAmount = 0f;
    }
    public void DEV_LevelUp()
    {
    
    }
    public void DEV_LevelDown()
    {
    
    }
    public void DEV_DivisionUp()
    {
    
    }
    public void DEV_DivisionDown()
    {
    
    }
    public void DEV_PointsUp()
    {
    
    }
    public void DEV_PointsDown()
    {
    
    }
    public BuildLevelUI()
    {
    
    }

}
