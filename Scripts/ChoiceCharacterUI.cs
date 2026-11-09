using UnityEngine;
internal sealed class ChoiceCharacterUI : MonoBehaviour
{
    // Fields
    private CharacterCell[] cells;
    private UIGrid grid;
    private Rilisoft.ButtonHandler chooseButton;
    private UnityEngine.GameObject chooseButtonInactive;
    private UnityEngine.GameObject chooseButtonWaiting;
    private UILabel characterNameLabel;
    private UILabel characterDescriptionLabel;
    private UILabel characterClassLabel;
    private WeaponCell primaryWeapon;
    private WeaponCell secondaryWeapon;
    private WeaponCell gadget;
    private UIBasicSprite classIcon;
    private UnityEngine.GameObject normalTimerContainer;
    private UnityEngine.GameObject redTimerContainer;
    private UnityEngine.GameObject suicidePenalty;
    private UILabel timerLabel;
    private UILabel redTimerLabel;
    private UnityEngine.GameObject limitMessage;
    private StoreCharacterHelper characterView;
    private bool 一丈专丏丝丝七丌丒;
    private bool 三丑专丞丕丌丄万万;
    private int 丞一一丄丆丄业丘专;
    private CharactersTracker 世上世丝与不丕且七;
    private float 丙丞万丆丂上下丞丆;
    private float 丁丒丕丆丄与丟万与;
    private float 三丞丗丙丝世三丐万;
    private ChoiceCharacterUI.丆丘丆丞丙下丆丟丅 业丌丑丗业丌丆丂上;
    
    // Properties
    internal bool 专东丘上丒东不丙三 { get; }
    private System.Collections.Generic.List<下丐专一下不不上与> 丝丁且一丌丐丙丄三 { get; }
    private UIBasicSprite 丁丙不丒上下上七丛 { get; }
    
    // Methods
    internal bool 丕丗丛丄丂下世丐丕()
    {
        return (bool)this.三丑专丞丕丌丄万万;
    }
    private System.Collections.Generic.List<下丐专一下不不上与> 一丏且丄世且丆丅世()
    {
        万且三丛丗丐且东丑 val_1 = 万且三丛丗丐且东丑.丑七不且上丗丁一世();
        if(val_1 != null)
        {
                return val_1.丄丗丟丕三丑丗不丅();
        }
        
        return val_1.丄丗丟丕三丑丗不丅();
    }
    private UIBasicSprite 与业丁一丂丗且丄丟()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.classIcon);
        this.classIcon = val_1;
        return val_1;
    }
    internal void 丆丙丗三东专丐不上(bool 丙业与丙丗丝不丈东)
    {
        UnityEngine.GameObject val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_1 = (this.三丑专丞丕丌丄万万 == true) ? 1 : 0;
        val_1 = val_1 ^ 丙业与丙丗丝不丈东;
        if(val_1 == false)
        {
                return;
        }
        
        this.三丑专丞丕丌丄万万 = 丙业与丙丗丝不丈东;
        val_8 = null;
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_2;
        }
        
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_19;
        }
        
        val_10 = null;
        val_10 = null;
        三丕不且丌丈丞丟丌();
        goto label_19;
        label_2:
        val_11 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_12 = null;
            val_12 = null;
            丝丞一丂万与丙不丛();
        }
        
        label_19:
        val_7 = this.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_7, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        this.丕万丆丁丅丁丄世丏();
    }
    internal void 丕万丆丁丅丁丄世丏()
    {
        var val_2;
        if(this.一丈专丏丝丝七丌丒 != false)
        {
                this.万丁丛七丑丂丑丄专();
            return;
        }
        
        val_2 = null;
        val_2 = null;
        bool val_1 = MutationController.丆丕丝丒不丙且丐丗.丄丂丏丌丕不世下七();
    }
    internal void 上丛丌丆丑上七世三(CharactersTracker 世上世丝与不丕且七)
    {
        if(this.一丈专丏丝丝七丌丒 != false)
        {
                return;
        }
        
        this.世上世丝与不丕且七 = 世上世丝与不丕且七;
        世上世丝与不丕且七.丈且丟且丝丙丕丄一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ChoiceCharacterUI::专丙不下丐丐丞丄七()));
        世上世丝与不丕且七.丛丄丑下丒丐丙业丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ChoiceCharacterUI::业业丄与丈丒一丁丞()));
        世上世丝与不丕且七.下专不丆丄丘丏丛丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ChoiceCharacterUI::丐丂丆丌下东东丙与()));
        this.一丈专丏丝丝七丌丒 = true;
        this.万丁丛七丑丂丑丄专();
    }
    private void 丐丂丆丌下东东丙与()
    {
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        this.万丁丛七丑丂丑丄专();
    }
    private void 专丙不下丐丐丞丄七()
    {
        var val_4;
        var val_5;
        var val_6;
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        if(MutationController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        if(this.业丌丑丗业丌丆丂上 == 2)
        {
                val_5 = null;
            val_5 = null;
            if((MutationController.丆丕丝丒不丙且丐丗.上世上丏丛丛丆丘丟() != false) && (this.世上世丝与不丕且七 != null))
        {
                this.世上世丝与不丕且七.丄七丗上专丈一不丅();
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        MutationController.丆丕丝丒不丙且丐丗.丕丌专丕丟一丒上丌(丙业与丙丗丝不丈东:  false);
    }
    private void 丗丅丟丑东不丄三丂(bool 丛与丙丒丒下丌丟且)
    {
        if(this.limitMessage == 0)
        {
                return;
        }
        
        this.limitMessage.SetActive(value:  false);
        this.limitMessage.SetActive(value:  丛与丙丒丒下丌丟且);
        if(丛与丙丒丒下丌丟且 == false)
        {
                return;
        }
        
        this.丙丞万丆丂上下丞丆 = 3.5f;
    }
    private void 业业丄与丈丒一丁丞()
    {
        this.万丁丛七丑丂丑丄专();
    }
    private void 万丁丛七丑丂丑丄专()
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_4;
        if(this.一丈专丏丝丝七丌丒 == false)
        {
                return;
        }
        
        val_4 = 0;
        if(this.世上世丝与不丕且七 != 0)
        {
                val_4 = this.世上世丝与不丕且七.丈丗丐东丝世不丆三(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
        }
        
        this.业丌丘一丐丕专丆丞(专丁丘三丂丝丅不丐:  val_4);
        this.丅丁七丝丁不一丌一();
    }
    internal void 丛丅丝丆丝丞丟丗丌()
    {
        this.业丌丑丗业丌丆丂上 = 0;
    }
    internal void 与丟丂丘丘一丗与三()
    {
        var val_2;
        var val_3;
        var val_5;
        var val_6;
        this.业丌丑丗业丌丆丂上 = 1;
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(MutationController.丆丕丝丒不丙且丐丗 == null)
        {
                val_2 = null;
        }
        
        if(MutationController.丆丕丝丒不丙且丐丗.丕丙一下丕上下丆丙 != false)
        {
                val_3 = null;
            MutationController.丆丕丝丒不丙且丐丗.丝且下万万丟不丁一
        }
        else
        {
                val_5 = null;
            MutationController.丆丕丝丒不丙且丐丗.丝丐上丘丟且丗一不
        }
        
        this.丁丒丕丆丄与丟万与 = (float)MutationController.丆丕丝丒不丙且丐丗.丝丐上丘丟且丗一不;
        val_6 = null;
        val_6 = null;
        this.三丞丗丙丝世三丐万 = (float)MutationController.丆丕丝丒不丙且丐丗.丞专丏丙丅丗丙七七;
    }
    internal void 丞丞丗丐丈丐丒丝丏(float 丌七不丏丝专专丁丒)
    {
        var val_2;
        this.业丌丑丗业丌丆丂上 = 2;
        this.丁丒丕丆丄与丟万与 = 丌七不丏丝专专丁丒;
        if(this.世上世丝与不丕且七 != null)
        {
                this.世上世丝与不丕且七.丙丏与丅专丟且丄丘(丆且丆上丝下丁且丆:  true);
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        this.三丞丗丙丝世三丐万 = (float)MutationController.丆丕丝丒不丙且丐丗.丞专丏丙丅丗丙七七;
    }
    private void 业丌丘一丐丕专丆丞(System.Collections.Generic.Dictionary<string, int> 专丁丘三丂丝丅不丐)
    {
        var val_15;
        var val_16;
        var val_17;
        CharactersTracker val_18;
        int val_19;
        val_15 = 0;
        goto label_1;
        label_29:
        val_16 = 0;
        CharacterCell val_15 = this.cells[val_16];
        bool val_1 = UnityEngine.Object.op_Inequality(x:  val_15, y:  0);
        if(val_1 == false)
        {
            goto label_6;
        }
        
        System.Collections.Generic.List<下丐专一下不不上与> val_2 = val_1.一丏且丄世且丆丅世();
        if(val_2 == null)
        {
            goto label_9;
        }
        
        val_16 = val_2.一丏且丄世且丆丅世();
        int val_4 = val_16.Count;
        if(val_15 >= val_4)
        {
            goto label_9;
        }
        
        val_15.上东与丛丞下丈专丈(丙丑丆上不丒上丕丛:  val_4.一丏且丄世且丆丅世().Item[0]);
        下丐专一下不不上与 val_8 = val_15.一丏且丄世且丆丅世().Item[0];
        if((专丁丘三丂丝丅不丐 == null) || ((专丁丘三丂丝丅不丐.ContainsKey(key:  val_8.七丛业丘丕与丝不丝)) == false))
        {
            goto label_15;
        }
        
        val_16 = 专丁丘三丂丝丅不丐.Item[val_8.七丛业丘丕与丝不丝];
        goto label_16;
        label_9:
        UnityEngine.GameObject val_11 = val_15.gameObject;
        val_17 = 0;
        goto label_19;
        label_15:
        val_16 = 0;
        label_16:
        val_18 = this.世上世丝与不丕且七;
        if(val_18 == 0)
        {
            goto label_22;
        }
        
        val_18 = this.世上世丝与不丕且七;
        val_19 = val_18.丂一丌丘丙与丗丙丅(七丛业丘丕与丝不丝:  val_8.七丛业丘丕与丝不丝);
        if(val_15 == null)
        {
            goto label_24;
        }
        
        label_26:
        val_15.下丗三与丅丕三下上(丌丒丝东丌下丕丁丅:  0, 一丁丘丅丟与七丘与:  val_19);
        goto label_25;
        label_22:
        val_19 = 0;
        if(val_15 != null)
        {
            goto label_26;
        }
        
        label_24:
        val_15.下丗三与丅丕三下上(丌丒丝东丌下丕丁丅:  0, 一丁丘丅丟与七丘与:  0);
        label_25:
        val_17 = 1;
        label_19:
        val_15.gameObject.SetActive(value:  true);
        label_6:
        val_15 = 1;
        label_1:
        if(val_15 < this.cells.Length)
        {
            goto label_29;
        }
    
    }
    private void Awake()
    {
        goto label_1;
        label_12:
        CharacterCell val_7 = this.cells[0];
        if(val_7 != 0)
        {
                Rilisoft.ButtonHandler val_2 = val_7.GetComponent<Rilisoft.ButtonHandler>();
            if(val_2 != 0)
        {
                val_2.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ChoiceCharacterUI::丒丂丙丂一丞丟且万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < this.cells.Length)
        {
            goto label_12;
        }
        
        if(this.chooseButton == 0)
        {
                return;
        }
        
        this.chooseButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ChoiceCharacterUI::三丟丒丅丝且下专丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 三丟丒丅丝且下专丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.世上世丝与不丕且七, y:  0);
        if(val_1 == false)
        {
                return;
        }
        
        下丐专一下不不上与 val_3 = val_1.一丏且丄世且丆丅世().Item[this.丞一一丄丆丄业丘专];
        this.世上世丝与不丕且七.三丟三丌丒且丑万专(业东丘丈丁且丏丑丈:  val_3.七丛业丘丕与丝不丝);
    }
    private void 丅丁七丝丁不一丌一()
    {
        var val_31;
        var val_32;
        var val_33;
        UILabel val_34;
        int val_35;
        val_31 = 0;
        goto label_1;
        label_9:
        CharacterCell val_31 = this.cells[0];
        if(val_31 != 0)
        {
                val_31.与丆与丂丄丞丒丏丑(丙业与丙丗丝不丈东:  (val_31 == this.丞一一丄丆丄业丘专) ? 1 : 0);
        }
        
        val_31 = 1;
        label_1:
        if(val_31 < this.cells.Length)
        {
            goto label_9;
        }
        
        下丐专一下不不上与 val_4 = this.一丏且丄世且丆丅世().Item[this.丞一一丄丆丄业丘专];
        this.primaryWeapon.上东与丛丞下丈专丈(下丅丙一丂丗丅丝七:  val_4.与世且不丝丈且专世());
        this.secondaryWeapon.上东与丛丞下丈专丈(下丅丙一丂丗丅丝七:  val_4.专丌丑万丂丙丂上下());
        this.gadget.丁万丁丙三丞不丅且(丙丗丕丟七丟上丈丌:  val_4.三丟丆丄丅丄丅丝丐());
        UIBasicSprite val_8 = this.与业丁一丂丗且丄丟();
        UnityEngine.Texture val_10 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  CharacterCell.七丗世业业丌丐专丒(丛三丈丟丌丑丘丒丕:  val_4.丛三丈丟丌丑丘丒丕));
        if(this.世上世丝与不丕且七 != 0)
        {
                val_32 = this.世上世丝与不丕且七.丂一丌丘丙与丗丙丅(七丛业丘丕与丝不丝:  val_4.七丛业丘丕与丝不丝);
        }
        else
        {
                val_32 = 0;
        }
        
        if(this.世上世丝与不丕且七 == 0)
        {
            goto label_31;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_15 = this.世上世丝与不丕且七.丈丗丐东丝世不丆三(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
        if(val_15 == null)
        {
            goto label_32;
        }
        
        if((val_15.ContainsKey(key:  val_4.七丛业丘丕与丝不丝)) == false)
        {
            goto label_31;
        }
        
        val_33 = val_15;
        int val_17 = val_33.Item[val_4.七丛业丘丕与丝不丝];
        goto label_32;
        label_31:
        val_33 = 0;
        label_32:
        this.丗丅丟丑东不丄三丂(丛与丙丒丒下丌丟且:  ((val_32 > 0) ? 1 : 0) & ((val_33 >= val_32) ? 1 : 0));
        万且三丛丗丐且东丑 val_21 = 万且三丛丗丐且东丑.丑七不且上丗丁一世();
        if(val_21 == null)
        {
            goto label_35;
        }
        
        丏下业丈丏下一丐丂 val_22 = val_21.上七专上丁丞与业世(七丛业丘丕与丝不丝:  val_4.七丛业丘丕与丝不丝);
        val_34 = this.characterDescriptionLabel;
        if(val_22 == null)
        {
            goto label_36;
        }
        
        string val_23 = val_22.丒丗丝不丕丈世丏丞();
        if(val_23 == null)
        {
            goto label_37;
        }
        
        label_56:
        val_34.text = val_23;
        if(1 == 0)
        {
            goto label_39;
        }
        
        val_35 = val_22.东丙上东业丆不丟丘();
        if(val_35 != null)
        {
            goto label_41;
        }
        
        label_39:
        val_35 = System.String.alignConst;
        label_41:
        this.characterNameLabel.text = val_35;
        this.characterClassLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  万且三丛丗丐且东丑.丒丄丁丒不丂丟丕且(丛三丈丟丌丑丘丒丕:  val_4.丛三丈丟丌丑丘丒丕));
        if(this.characterView == 0)
        {
                return;
        }
        
        this.characterView.与丕丆上丛丐下丕丂().专业丞丞专下丒丌下(东世丛丘丐下丏丄丈:  false);
        this.characterView.丒一丛丈七丂一与世(丐丒丈丌与丈丏不上:  val_4.一丗丆专丆上七不不(), 东世丛丘丐下丏丄丈:  true);
        this.characterView.丂丄丗丝丌丌丝世丘(丈丄不七三万丄丁不:  val_4.丞且七丆丙专一七丅(业上丛丒丁不不丌万:  true), 万下万丘丌丄丝丐丆:  true, 丙万丘丗丅万丐一世:  true);
        return;
        label_35:
        val_34 = this.characterDescriptionLabel;
        label_36:
        label_37:
        if(val_34 != null)
        {
            goto label_56;
        }
        
        goto label_56;
    }
    private void 丆丅专丗丛丄丏东丙(bool 丙业与丙丗丝不丈东)
    {
        if(this.characterView == 0)
        {
                return;
        }
        
        this.characterView.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void 丒丂丙丂一丞丟且万(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        int val_8;
        UnityEngine.Object val_9;
        CharacterCell[] val_10;
        if((CharactersTracker.丆丗不丂丕丏丛七丐(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())) == false)
        {
                return;
        }
        
        val_8 = 0;
        goto label_4;
        label_20:
        CharacterCell val_8 = this.cells[0];
        if(不丟丗丏丛丕不丁丌 != null)
        {
                var val_3 = (null == null) ? 不丟丗丏丛丕不丁丌 : 0;
        }
        else
        {
                val_9 = 0;
        }
        
        if((val_9 == 0) || (val_8 == 0))
        {
            goto label_14;
        }
        
        val_10 = val_9.gameObject;
        if((val_8.gameObject & 1) != 0)
        {
            goto label_18;
        }
        
        label_14:
        val_8 = 1;
        label_4:
        val_10 = this.cells;
        if(val_8 < this.cells.Length)
        {
            goto label_20;
        }
        
        goto label_21;
        label_18:
        this.丞一一丄丆丄业丘专 = val_8;
        label_21:
        this.丅丁七丝丁不一丌一();
    }
    private void 丑不丗三丕丌万丁丙(ChoiceCharacterUI.丝下丐丁专丂丈业一 丏业丟一东丂东丘丛)
    {
        丝下丐丁专丂丈业一 val_5 = 丏业丟一东丂东丘丛;
        this.chooseButton.gameObject.SetActive(value:  ((val_5 & 255) != 0) ? 1 : 0);
        val_5 = val_5 & 255;
        this.chooseButtonInactive.SetActive(value:  (val_5 == 1) ? 1 : 0);
        this.chooseButtonWaiting.SetActive(value:  (val_5 == 2) ? 1 : 0);
    }
    private void 万丌专丏专三东丑东(float 七上与丄丅丒业三业, float 专丛与丂丆丛丟丈七)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        丝下丐丁专丂丈业一 val_19;
        val_15 = null;
        val_15 = null;
        if(MutationController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        if((CharactersTracker.一丛丐丗丈东上东丄(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())) != false)
        {
                return;
        }
        
        if(七上与丄丅丒业三业 <= 0f)
        {
            goto label_9;
        }
        
        this.redTimerLabel.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  UnityEngine.Mathf.CeilToInt(f:  七上与丄丅丒业三业), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.redTimerContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.normalTimerContainer, 丏业丟一东丂东丘丛:  false);
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_25;
        }
        
        val_16 = null;
        val_16 = null;
        if((MutationController.丆丕丝丒不丙且丐丗 == 0) || (this.业丌丑丗业丌丆丂上 != 1))
        {
            goto label_25;
        }
        
        val_17 = null;
        val_17 = null;
        var val_8 = (MutationController.丆丕丝丒不丙且丐丗.丕丙一下丕上下丆丙 == true) ? 1 : 0;
        goto label_29;
        label_9:
        bool val_10 = CharactersTracker.不丏一东与丆下世业(专丞上七七且丝七丗:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上());
        if(val_10 == false)
        {
            goto label_32;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.normalTimerContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.redTimerContainer, 丏业丟一东丂东丘丛:  false);
        val_18 = 0;
        val_19 = 2;
        goto label_36;
        label_25:
        val_18 = 0;
        label_29:
        val_19 = 1;
        goto label_36;
        label_32:
        if(专丛与丂丆丛丟丈七 > 0f)
        {
                this.timerLabel.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  UnityEngine.Mathf.CeilToInt(f:  专丛与丂丆丛丟丈七), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            val_19 = 0;
        }
        else
        {
                下丐专一下不不上与 val_14 = val_10.一丏且丄世且丆丅世().Item[this.丞一一丄丆丄业丘专];
            if(this.世上世丝与不丕且七 != null)
        {
                this.世上世丝与不丕且七.丛丞丕丒丆丌丝丕丒(业东丘丈丁且丏丑丈:  val_14.七丛业丘丕与丝不丝);
        }
        
            val_19 = 2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.redTimerContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.normalTimerContainer, 丏业丟一东丂东丘丛:  true);
        val_18 = 0;
        label_36:
        this.丑不丗三丕丌万丁丙(丏业丟一东丂东丘丛:  val_19);
        this.suicidePenalty.SetActive(value:  false);
    }
    private void 下丒丘丅丞丘丐世一()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(MutationController.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        this.万丌专丏专三东丑东(七上与丄丅丒业三业:  (float)MutationController.丆丕丝丒不丙且丐丗.goTimer, 专丛与丂丆丛丟丈七:  MutationController.丆丕丝丒不丙且丐丗.mutationStartTimer);
    }
    private void 万丁丒丌世丆丐丅丏()
    {
        float val_3;
        float val_5;
        val_3 = this.丁丒丕丆丄与丟万与;
        if(val_3 > 0f)
        {
                val_3 = val_3 - UnityEngine.Time.deltaTime;
            this.丁丒丕丆丄与丟万与 = val_3;
        }
        
        val_5 = this.三丞丗丙丝世三丐万;
        if((val_3 <= 0f) && (val_5 > 0f))
        {
                val_3 = this.丁丒丕丆丄与丟万与;
            val_5 = val_5 - UnityEngine.Time.deltaTime;
            this.三丞丗丙丝世三丐万 = val_5;
        }
        
        this.万丌专丏专三东丑东(七上与丄丅丒业三业:  val_3, 专丛与丂丆丛丟丈七:  val_5);
    }
    private void Update()
    {
        var val_18;
        与丅丕丈丘东丝世丟 val_19;
        float val_20;
        bool val_21;
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_11;
        }
        
        val_18 = null;
        val_18 = null;
        if(MutationController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_11;
        }
        
        丆丘丆丞丙下丆丟丅 val_17 = this.业丌丑丗业丌丆丂上;
        if(val_17 == 0)
        {
            goto label_9;
        }
        
        val_17 = val_17 - 1;
        if(val_17 > 1)
        {
            goto label_11;
        }
        
        this.万丁丒丌世丆丐丅丏();
        goto label_11;
        label_9:
        this.下丒丘丅丞丘丐世一();
        label_11:
        val_19 = 1152921504848912384;
        if(this.limitMessage != 0)
        {
                val_20 = this.丙丞万丆丂上下丞丆;
            if(val_20 > 0f)
        {
                val_20 = val_20 - UnityEngine.Time.deltaTime;
            this.丙丞万丆丂上下丞丆 = val_20;
        }
        
            if(val_20 <= 0f)
        {
                if(this.limitMessage.activeSelf != false)
        {
                this.limitMessage.SetActive(value:  false);
        }
        
        }
        
        }
        
        if(this.chooseButton.gameObject.activeSelf != false)
        {
                if(this.世上世丝与不丕且七 != 0)
        {
                与丅丕丈丘东丝世丟 val_9 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
            val_19 = val_9;
            下丐专一下不不上与 val_11 = val_9.一丏且丄世且丆丅世().Item[this.丞一一丄丆丄业丘专];
            与丅丕丈丘东丝世丟 val_18 = val_19;
            val_18 = (~(this.世上世丝与不丕且七.CheckCharacter(专丞上七七且丝七丗:  val_18, 丐丒丟丕七丝丗东专:  val_11.七丛业丘丕与丝不丝))) & 1;
            this.丑不丗三丕丌万丁丙(丏业丟一东丂东丘丛:  val_18);
        }
        
        }
        
        if(this.primaryWeapon.专丌不丄与丗丞东万() != true)
        {
                if(this.secondaryWeapon.专丌不丄与丗丞东万() == false)
        {
            goto label_34;
        }
        
        }
        
        val_21 = 0;
        goto label_35;
        label_34:
        val_21 = this.gadget.专丌不丄与丗丞东万() ^ 1;
        label_35:
        this.丆丅专丗丛丄丏东丙(丙业与丙丗丝不丈东:  val_21);
    }
    private void OnDestroy()
    {
        if(this.世上世丝与不丕且七 == 0)
        {
                return;
        }
        
        System.Action val_2 = 1152921536494851024;
        val_2 = new System.Action(object:  this, method:  System.Void ChoiceCharacterUI::专丙不下丐丐丞丄七());
        this.世上世丝与不丕且七.业专丄丄丞丟与丕业(丙业与丙丗丝不丈东:  val_2);
        System.Action val_3 = 1152921536494851024;
        val_3 = new System.Action(object:  this, method:  System.Void ChoiceCharacterUI::业业丄与丈丒一丁丞());
        this.世上世丝与不丕且七.丐三丅世丅丁丂丐东(丙业与丙丗丝不丈东:  val_3);
        System.Action val_4 = 1152921536494851024;
        val_4 = new System.Action(object:  this, method:  System.Void ChoiceCharacterUI::丐丂丆丌下东东丙与());
        this.世上世丝与不丕且七.丅丘三东丒不世丞业(丙业与丙丗丝不丈东:  val_4);
    }
    public ChoiceCharacterUI()
    {
    
    }

}
