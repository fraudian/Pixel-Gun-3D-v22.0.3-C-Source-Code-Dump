using UnityEngine;
public class ClanGiftDynamicWrapItem : DynamicWrapGridItem
{
    // Fields
    private UITexture playerTexture;
    private UITextureMasked giftTexture;
    private UILabel playerLevel;
    private UILabel playerName;
    private UILabel giftTitle;
    private UILabel playerRole;
    private UISprite playerRank;
    private UIButton openButton;
    private PGCompany.GiftSystem.丏下丙丂万且一丑丛 世丙丕丈上丂丟丒丄;
    
    // Methods
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        var val_49;
        var val_50;
        int val_51;
        丌丌丄丂丕丑专万丆 val_52;
        var val_53;
        var val_54;
        val_49 = 三丏丑不业丏不丂丈;
        val_50 = this;
        if(val_49 != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        this.世丙丕丈上丂丟丒丄 = 0;
        val_49 = ???;
        val_50 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_1F8;
        label_2:
        mem2[0] = val_49;
        int val_1 = val_49.丟业丅世丟丗丄丞万();
        int val_2 = PGCompany.GiftSystem.丏下丙丂万且一丑丛.专东下丑丕丆丑丈东();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_50 + 64, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8461")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8461")) + " " + 丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  val_50 + 104.丕不业丟丕丘万世三())(丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  val_50 + 104.丕不业丟丕丘万世三())));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_50 + 56, 丕丗丘丑丛与丑业丒:  丂与专万与丐丌丏不.丑七不且上丗丁一世().七丙丞且世七丙丐下(丄丒且丙三丆丟与丏:  val_50 + 104.丕不业丟丕丘万世三()));
        PGCompany.世东三上七丂丌下丑 val_11 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        PGCompany.三东丏不丗世丅丌丄 val_13 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_50 + 104.丒丑丛丂丟丑丝丘丐());
        if(val_13 == null)
        {
            goto label_15;
        }
        
        if(val_11 != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        PGCompany.丗丟丄丈东丝丕丄世 val_15 = val_11.一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  val_13.业东丅东丌上丗丑不());
        if(val_15 == null)
        {
            goto label_17;
        }
        
        val_51 = val_15;
        if(val_51 != null)
        {
            goto label_18;
        }
        
        label_17:
        val_51 = System.String.alignConst;
        label_18:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_50 + 72, 丕丗丘丑丛与丑业丒:  val_51);
        丞丂丘丒丟丞丑下丄 val_17 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_17 == null)
        {
            goto label_22;
        }
        
        丌丌丄丂丕丑专万丆 val_19 = val_17.三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_50 + 104.丕不业丟丕丘万世三());
        goto label_24;
        label_15:
        if(val_11 != null)
        {
            goto label_25;
        }
        
        goto label_26;
        label_22:
        val_52 = 0;
        label_24:
        string val_20 = 七丈丗不丞丈丝丙七.丕下与与丂七丈业上(丕万丐东与一丈万与:  val_52);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_50 + 80, 丕丗丘丑丛与丑业丒:  (val_20 == null) ? "" : (val_20));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_50 + 88, 丏业丟一东丂东丘丛:  false);
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto label_36;
        }
        
        if(((val_50 + 104) == 0) || ((val_50 + 104.丕不业丟丕丘万世三()) == null))
        {
            goto label_32;
        }
        
        七丈丗不丞丈丝丙七 val_28 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  val_50 + 104.丕不业丟丕丘万世三());
        if(val_28 == null)
        {
            goto label_36;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_50 + 88, 丏业丟一东丂东丘丛:  true);
        val_53 = mem[val_50 + 88];
        val_53 = val_50 + 88;
        val_54 = val_28.与丘且丟不丅丏万丆();
        goto label_41;
        label_32:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_50 + 88, 丏业丟一东丂东丘丛:  true);
        val_53 = mem[val_50 + 88];
        val_53 = val_50 + 88;
        val_54 = 0;
        label_41:
        val_53.spriteName = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  0);
        label_36:
        UnityEngine.Texture2D val_34 = Rilisoft.与丄丁丄丙丞下下丙.丒丘上丌上七丕丟丟(丘丈下丛丙丝世丗丏:  丂与专万与丐丌丏不.丑七不且上丗丁一世().且丆一下丆丙丙丈丄(丄丒且丙三丆丟与丏:  val_50 + 104.丕不业丟丕丘万世三()), 丁丅丈丌丟世丗丗丟:  1);
        PGCompany.世东三上七丂丌下丑 val_35 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        PGCompany.三东丏不丗世丅丌丄 val_37 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_50 + 104.丒丑丛丂丟丑丝丘丐());
        if(val_37 == null)
        {
            goto label_51;
        }
        
        if(val_35 != null)
        {
            goto label_55;
        }
        
        label_56:
        label_55:
        if((val_35.一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  val_37.业东丅东丌上丗丑不())) == null)
        {
            goto label_53;
        }
        
        if((val_50 + 48) != 0)
        {
                return;
        }
        
        return;
        label_51:
        if(val_35 != null)
        {
            goto label_55;
        }
        
        goto label_56;
        label_53:
        if((val_50 + 48) != 0)
        {
                return;
        }
    
    }
    public void U_OpenGift()
    {
        PGCompany.七东万三万丒丏一丁 val_17;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  27);
        PGCompany.世东三上七丂丌下丑 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        PGCompany.三东丏不丗世丅丌丄 val_4 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.世丙丕丈上丂丟丒丄.丒丑丛丂丟丑丝丘丐());
        if(val_4 == null)
        {
            goto label_5;
        }
        
        if(val_2 != null)
        {
            goto label_29;
        }
        
        label_30:
        label_29:
        val_17 = val_2.一丌世丑丄东丞丘三<PGCompany.七东万三万丒丏一丁>(丞世不丒下上上丝丑:  val_4.业东丅东丌上丗丑不());
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_8 = PGCompany.GiftSystem.业三东上与丁丁专三.丑七不且上丗丁一世().上丆丂丆上世三与丘(且丌丒丝不丛上三丆:  this.世丙丕丈上丂丟丒丄);
        if((val_17 == null) && (val_8 != null))
        {
                if(val_8.Count >= 1)
        {
                PGCompany.Analytics.一业丗丆世世上丁且.与丙业丑与东上下不(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丐丅专且专七三丆:  0, 丝七丌丘丅丄七丅丟:  this.世丙丕丈上丂丟丒丄.丕不业丟丕丘万世三(), 丑七不与丛丆一丂丞:  this.世丙丕丈上丂丟丒丄.丒丑丛丂丟丑丝丘丐(), 丐丌丟丕丅且丙三与:  "clan", 丒世丘丘上丆丝东丞:  0);
        }
        
        }
        
        if(val_17 != null)
        {
                BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  46, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丌丙丏丄下万万丄上 = val_8, 丛丗世丛丐丙丐七下 = val_17, 丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            val_17 = this.世丙丕丈上丂丟丒丄.丕不业丟丕丘万世三();
            PGCompany.Analytics.一业丗丆世世上丁且.与丙业丑与东上下不(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丐丅专且专七三丆:  0, 丝七丌丘丅丄七丅丟:  val_17, 丑七不与丛丆一丂丞:  val_8, 丐丌丟丕丅且丙三与:  "clan", 丒世丘丘上丆丝东丞:  0);
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        return;
        label_5:
        if(val_2 != null)
        {
            goto label_29;
        }
        
        goto label_30;
    }
    public ClanGiftDynamicWrapItem()
    {
    
    }

}
