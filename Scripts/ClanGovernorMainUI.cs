using UnityEngine;
internal sealed class ClanGovernorMainUI : BannerWindowWithBack, 丑且丆万丏丝丘丙丟
{
    // Fields
    public UIScrollView tasksScroll;
    public UIGrid tasksGrid;
    public ClanGovernorTaskCellView taskCellViewExample;
    public GovernorCellRowLocked cellRowLockeExample;
    public UILabel opendCellsCountLabel;
    public PGTweener opendCellsCountAnim;
    public ClanBuildingProgress buildingProgress;
    public ClanBuildingSelectorView buildingSelectorView;
    private System.Collections.Generic.List<ClanGovernorTaskCellView> 业且丗丗东丛下丞业;
    private System.Collections.Generic.List<GovernorCellRowLocked> 丝丁丄丌丈丏且丙上;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        this.buildingSelectorView.丐丗丗丅丐世七万七(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丏丌丝丕丐七丈且丒>(object:  this, method:  System.Void ClanGovernorMainUI::万丞丐丕丆丘丒丌上(PGCompany.丏丌丝丕丐七丈且丒 丌丗三丐丗七丟东业)));
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        this.buildingSelectorView.丁专一世丆丄丟丝上(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丏丌丝丕丐七丈且丒>(object:  this, method:  System.Void ClanGovernorMainUI::万丞丐丕丆丘丒丌上(PGCompany.丏丌丝丕丐七丈且丒 丌丗三丐丗七丟东业)));
    }
    public override void Show()
    {
        this.Show();
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        this.丘丑丘丂丛丙与丌丁();
        PGCompany.ClanGovernorController.丅丘丆业万七业世丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanGovernorMainUI::丝一丅丆三东丂丞七()));
        PGCompany.ClanGovernorController.丄丈丘七丌上专东丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanGovernorMainUI::丝一丅丆三东丂丞七()));
        PGCompany.丁丏丝上丘丝丒丞丒.东丏丏不丗丒丞不丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanGovernorMainUI::丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)));
    }
    public override void Hide()
    {
        this.Hide();
        PGCompany.ClanGovernorController.不丈丘丒万丈且丏丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanGovernorMainUI::丝一丅丆三东丂丞七()));
        PGCompany.ClanGovernorController.三丌三且丑七丗一丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanGovernorMainUI::丝一丅丆三东丂丞七()));
        PGCompany.丁丏丝上丘丝丒丞丒.丂丕上丒丁丘丐七不(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanGovernorMainUI::丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)));
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    private void 丘丑丘丂丛丙与丌丁()
    {
        this.buildingProgress.丈且东丑丂且万丒丅(丕万丌世丆下丈丟与:  PGCompany.七丄三丝丐业丄丅丝.世丕丛上东专万世不());
        this.opendCellsCountAnim.丄与丒丂丂丘专丝万();
        this.业丌丘一丐丕专丆丞();
        this.丝一丅丆三东丂丞七();
    }
    private void 业丌丘一丐丕专丆丞()
    {
        var val_5;
        var val_10;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskCellViewExample, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.cellRowLockeExample, 丏业丟一东丂东丘丛:  false);
        this.丝丛丙不丅下上上丆();
        this.丑丕丛丝且专专一丙();
        List.Enumerator<T> val_3 = PGCompany.ClanGovernorController.丑七不且上丗丁一世().专丕不丆丆丆丒丘东().GetEnumerator();
        label_16:
        if((1923912128 & 1) == 0)
        {
            goto label_7;
        }
        
        ClanGovernorTaskCellView val_8 = UnityEngine.Object.Instantiate<ClanGovernorTaskCellView>(original:  this.taskCellViewExample, parent:  this.tasksGrid.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_8.transform);
        val_8.三下丌且与丘丆丏且 = val_5.丐丏七丌丕丗业且上();
        val_8.丝一丅丆三东丂丞七();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
        this.业且丗丗东丛下丞业.Add(item:  val_8);
        goto label_16;
        label_7:
        val_10 = public System.Void List.Enumerator<丛丗丅丆万不丕七丏>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.tasksGrid.repositionNow = true;
        this.业丄丞丞世丗丛与丞();
    }
    private void 业丄丞丞世丗丛与丞()
    {
        var val_2;
        var val_3;
        this.丑丕丛丝且专专一丙();
        List.Enumerator<T> val_1 = this.业且丗丗东丛下丞业.GetEnumerator();
        label_16:
        if((1924116288 & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_2 == 4)
        {
                if(0 < X22.丘丆丐不丟丛丞丝与())
        {
                GovernorCellRowLocked val_7 = UnityEngine.Object.Instantiate<GovernorCellRowLocked>(original:  this.cellRowLockeExample, parent:  this.tasksScroll.transform);
            丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_7.transform);
            val_7.Setup(丙丈丌丗丅三丙万丁:  val_4);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  true);
            this.丝丁丄丌丈丏且丙上.Add(item:  val_7);
        }
        
        }
        
        int val_9 = val_4.丘丆丐不丟丛丞丝与();
        goto label_16;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丝丛丙不丅下上上丆()
    {
        List.Enumerator<T> val_1 = this.业且丗丗东丛下丞业.GetEnumerator();
        label_6:
        if((1924278504 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Object.Destroy(obj:  0.丐丏七丌丕丗业且上().gameObject);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.业且丗丗东丛下丞业.Clear();
    }
    private void 丑丕丛丝且专专一丙()
    {
        List.Enumerator<T> val_1 = this.丝丁丄丌丈丏且丙上.GetEnumerator();
        label_6:
        if((1924428392 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Object.Destroy(obj:  0.丐丏七丌丕丗业且上().gameObject);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝丁丄丌丈丏且丙上.Clear();
    }
    private void 丝一丅丆三东丂丞七()
    {
        string val_23;
        if(PGCompany.ClanGovernorController.丑七不且上丗丁一世().丌七丝三世东丟丘世().Count >= 1)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buildingSelectorView, 丏业丟一东丂东丘丛:  true);
            this.buildingSelectorView.丈且东丑丂且万丒丅(丑且丞且丛丂丒丈且:  PGCompany.ClanGovernorController.丑七不且上丗丁一世().丌七丝三世东丟丘世(), 丛丗七丅下丞丗且丐:  PGCompany.ClanGovernorController.丑七不且上丗丁一世().丞东丗丕三且丈丑丘());
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buildingSelectorView, 丏业丟一东丂东丘丛:  false);
        }
        
        val_23 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9056"), arg0:  PGCompany.ClanGovernorController.丑七不且上丗丁一世().不丛丞不丁上丈丈丅(), arg1:  PGCompany.ClanGovernorController.丑七不且上丗丁一世().丙丌上丞丘七专丛世());
        System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_15 = PGCompany.ClanGovernorController.丑七不且上丗丁一世().GetNextCellsCountIncrease();
        if(val_15.Value.GetHashCode() >= 1)
        {
                val_23 = val_23 + " " + System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9057"), arg0:  val_15.Value, arg1:  val_15.Value.GetHashCode())(System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9057"), arg0:  val_15.Value, arg1:  val_15.Value.GetHashCode()));
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.opendCellsCountLabel, 丕丗丘丑丛与丑业丒:  val_23);
        List.Enumerator<T> val_21 = this.业且丗丗东丛下丞业.GetEnumerator();
        label_31:
        if((1924651160 & 1) == 0)
        {
            goto label_29;
        }
        
        0.丐丏七丌丕丗业且上().丝一丅丆三东丂丞七();
        goto label_31;
        label_29:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.业丄丞丞世丗丛与丞();
    }
    private void 丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)
    {
        if(PGCompany.七丄三丝丐业丄丅丝.世丕丛上东专万世不().业东丅东丌上丗丑不() != 丛丑丅丞丝丈丘丆三)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    public void DEV_LevelUp()
    {
    
    }
    public void DEV_LevelDown()
    {
    
    }
    public void AnimateCellsCount()
    {
        UnityEngine.Debug.LogError(message:  "Animate Cells Count");
        this.opendCellsCountAnim.丗万丞丒东万丂丛三();
    }
    private void 万丞丐丕丆丘丒丌上(PGCompany.丏丌丝丕丐七丈且丒 丌丗三丐丗七丟东业)
    {
        bool val_3 = PGCompany.ClanGovernorController.丑七不且上丗丁一世().丆专丈丅丕丂丐不丏(丛丑丅丞丝丈丘丆三:  丌丗三丐丗七丟东业.业东丅东丌上丗丑不());
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    public ClanGovernorMainUI()
    {
        this.业且丗丗东丛下丞业 = new System.Collections.Generic.List<ClanGovernorTaskCellView>();
        this.丝丁丄丌丈丏且丙上 = new System.Collections.Generic.List<GovernorCellRowLocked>();
    }

}
