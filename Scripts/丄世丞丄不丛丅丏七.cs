using UnityEngine;
private sealed class SquadController.丄世丞丄不丛丅丏七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SquadController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SquadController.丄世丞丄不丛丅丏七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_48;
        int val_49;
        string val_50;
        var val_51;
        string val_52;
        var val_53;
        var val_54;
        var val_55;
        PhotonView val_56;
        System.Object[] val_57;
        object val_58;
        object val_59;
        object val_60;
        object val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_49 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_49;
        return (bool)val_49;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.IsClanSquad != true)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
        }
        
        int val_4 = UnityEngine.Mathf.Min(a:  this.丝且与丝丒丟万丁专.丛一丆专世丝丄丒与.Count, b:  this.丝且与丝丒丟万丁专.世丗万丏下丆专丁丏);
        if(this.丝且与丝丒丟万丁专.丝不丟丁丘丐丛一不 == 22)
        {
                bool val_48 = this.丝且与丝丒丟万丁专.IsClanSquad;
            if(this.丝且与丝丒丟万丁专.丑业业业丒丏丈丞下 != 0)
        {
                val_50 = this.丝且与丝丒丟万丁专.丑业业业丒丏丈丞下.丙且上丒不下丑下丞();
        }
        else
        {
                val_50 = "";
        }
        
            val_48 = val_48 ^ 1;
            Rilisoft.一丟专且三万丞丁丂.丄丌丟下丂丒丅丛且(丛一丆专世丝丄丒与:  val_48, 丙世不不一丏业三且:  this.丝且与丝丒丟万丁专.IsClanSquad, 丆丗丝丗丂丅丝丏专:  val_4, 七丆丂丂下丈且丟世:  val_50);
        }
        
        System.Collections.Generic.List<System.String> val_11 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.String> val_12 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.Object> val_13 = new System.Collections.Generic.List<System.Object>();
        if(val_4 < 1)
        {
            goto label_21;
        }
        
        val_51 = 1152921516107659296;
        var val_49 = 0;
        label_52:
        val_52 = this.丝且与丝丒丟万丁专.丛一丆专世丝丄丒与.Item[0];
        if((val_14.专丞上七七且丝七丗 == null) || ((System.String.IsNullOrEmpty(value:  val_14.专丞上七七且丝七丗.丞丈业东专丅丆与七())) == true))
        {
            goto label_25;
        }
        
        val_11.Add(item:  val_14.专丞上七七且丝七丗.丞丈业东专丅丆与七());
        object[] val_18 = new object[6];
        string val_19 = val_14.专丞上七七且丝七丗.丞丈业东专丅丆与七();
        if(val_18 == null)
        {
            goto label_29;
        }
        
        if(val_19 != null)
        {
            goto label_30;
        }
        
        goto label_33;
        label_29:
        if(val_19 == null)
        {
            goto label_33;
        }
        
        label_30:
        label_33:
        val_18[0] = val_19;
        val_18[1] = val_14.丆世丘丒丒丏上且丗;
        val_18[2] = val_14.丛三三与丁丘丄丑下;
        val_18[3] = val_14.丑丄丅丟丙丛丒丑丅;
        val_18[4] = val_14.专世专丟丝丌与丘上;
        val_18[5] = "";
        val_13.Add(item:  val_18);
        val_52 = val_14.丆世丘丒丒丏上且丗;
        val_51 = val_51;
        val_12.Add(item:  val_52);
        label_25:
        val_49 = val_49 + 1;
        if(val_4 != val_49)
        {
            goto label_52;
        }
        
        label_21:
        if(val_11.Count >= 1)
        {
                this.丝且与丝丒丟万丁专.丙丂万专丄丙丏东丛 = val_11.ToArray();
            this.丝且与丝丒丟万丁专.专丆专上丘丟丑丘东 = val_12.ToArray();
            val_53 = null;
            val_53 = null;
            SquadController.丅丐丝下丞下下下上 = val_13.ToArray();
        }
        
        if(this.丝且与丝丒丟万丁专.IsClanSquad == false)
        {
            goto label_60;
        }
        
        this.丝且与丝丒丟万丁专.东丏东上七一万丆丌.Clear();
        this.丝且与丝丒丟万丁专.东丏东上七一万丆丌.AddRange(collection:  this.丝且与丝丒丟万丁专.丛一丆专世丝丄丒与);
        this.丝且与丝丒丟万丁专.东丏东上七一万丆丌.Sort(comparison:  new System.Comparison<万丅世丈丕丕丌丅丗>(object:  this.丝且与丝丒丟万丁专, method:  System.Int32 SquadController::丛丂且丆不不万丛丐(SquadController.万丅世丈丕丕丌丅丗 三丟东丕丄丄下下丑, SquadController.万丅世丈丕丕丌丅丗 丒丒丄丁且丄丆丂丌)));
        if(val_4 < 1)
        {
            goto label_71;
        }
        
        val_52 = 1152921540349734000;
        var val_50 = 0;
        do
        {
            if((this.丝且与丝丒丟万丁专.世专三丒丙丗丘丆万(专丞上七七且丝七丗:  this.丝且与丝丒丟万丁专.东丏东上七一万丆丌.Item[0])) != false)
        {
                万丅世丈丕丕丌丅丗 val_28 = this.丝且与丝丒丟万丁专.东丏东上七一万丆丌.Item[0];
            this.丝且与丝丒丟万丁专.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  135, 万丌万丅专丞业丈万:  val_28.专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
            val_50 = val_50 + 1;
        }
        while(val_4 != val_50);
        
        goto label_71;
        label_60:
        this.丝且与丝丒丟万丁专.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  135, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        label_71:
        this.丝且与丝丒丟万丁专.丕丕三世世世一与丄 = this.丝且与丝丒丟万丁专.丏丄丈上东丙丞专丒();
        this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 = this.丝且与丝丒丟万丁专.丑业业业丒丏丈丞下;
        mem2[0] = 1152921516266839504;
        if((GameConnect.丙丏丄万丐与丈丄七(丂丛丑东不丅丈一东:  this.丝且与丝丒丟万丁专.丝不丟丁丘丐丛一不, 丏丈丗世丙万丆丐丅:  this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅)) != false)
        {
                this.丝且与丝丒丟万丁专.一三七丏丑丞且与丗 = this.丝且与丝丒丟万丁专.丆不丈专万丕丂丁世();
        }
        
        if(this.丝且与丝丒丟万丁专.IsClanSquad == false)
        {
            goto label_76;
        }
        
        if(this.丝且与丝丒丟万丁专.丝不丟丁丘丐丛一不 != 20)
        {
            goto label_77;
        }
        
        val_54 = 1152921505323884544;
        val_55 = null;
        val_55 = null;
        SquadController.七丆丆丘业丝与丄业 = this.丝且与丝丒丟万丁专.丁丅丑不丗一丂上丆();
        val_56 = this.丝且与丝丒丟万丁专.丄丈丑丐丆丞丘与丗;
        val_57 = new object[9];
        val_57[0] = this.丝且与丝丒丟万丁专.丝不丟丁丘丐丛一不;
        if(this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 != 0)
        {
            goto label_86;
        }
        
        val_58 = 0;
        goto label_87;
        label_76:
        val_56 = this.丝且与丝丒丟万丁专.丄丈丑丐丆丞丘与丗;
        if(this.丝且与丝丒丟万丁专.丝不丟丁丘丐丛一不 != 20)
        {
            goto label_88;
        }
        
        val_54 = 1152921504622075904;
        val_57 = new object[9];
        val_57[0] = this.丝且与丝丒丟万丁专.丝不丟丁丘丐丛一不;
        if(this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 != 0)
        {
            goto label_95;
        }
        
        val_59 = 0;
        goto label_96;
        label_77:
        val_56 = this.丝且与丝丒丟万丁专.丄丈丑丐丆丞丘与丗;
        object[] val_40 = new object[8];
        val_54 = 1152921504622075904;
        val_57 = val_40;
        val_57[0] = this.丝且与丝丒丟万丁专.丝不丟丁丘丐丛一不;
        if(this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 != 0)
        {
            goto label_103;
        }
        
        val_60 = 0;
        goto label_104;
        label_88:
        object[] val_42 = new object[8];
        val_42[0] = this.丝且与丝丒丟万丁专.丝不丟丁丘丐丛一不;
        if(this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 != 0)
        {
            goto label_111;
        }
        
        val_61 = 0;
        goto label_112;
        label_86:
        val_58 = mem[this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 + 56];
        label_87:
        val_57[1] = val_58;
        val_57[2] = val_58.业上丙丞丐丄丆丅七();
        val_57[3] = val_36.Length;
        val_57[4] = this.丝且与丝丒丟万丁专.丘下丄丗丕业专丟丘;
        val_57[5] = this.丝且与丝丒丟万丁专.丕丕三世世世一与丄;
        val_57[6] = this.丝且与丝丒丟万丁专.丁丏丅丞东且丒下世;
        val_62 = null;
        val_62 = null;
        val_57[7] = SquadController.丅丐丝下丞下下下上;
        val_48 = SquadController.七丆丆丘业丝与丄业;
        val_57[8] = val_48;
        if(val_56 != null)
        {
            goto label_198;
        }
        
        goto label_142;
        label_95:
        val_59 = mem[this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 + 56];
        label_96:
        val_57[1] = val_59;
        val_57[2] = val_59.业上丙丞丐丄丆丅七();
        val_57[3] = val_38.Length;
        val_57[4] = this.丝且与丝丒丟万丁专.丘下丄丗丕业专丟丘;
        val_57[5] = this.丝且与丝丒丟万丁专.丕丕三世世世一与丄;
        val_57[6] = this.丝且与丝丒丟万丁专.丁丏丅丞东且丒下世;
        val_63 = null;
        val_63 = null;
        val_57[7] = SquadController.丅丐丝下丞下下下上;
        val_48 = SquadController.七丆丆丘业丝与丄业;
        val_57[8] = val_48;
        if(val_56 != null)
        {
            goto label_224;
        }
        
        label_225:
        label_224:
        val_64 = 132;
        val_65 = 6;
        goto label_172;
        label_103:
        val_60 = mem[this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 + 56];
        label_104:
        val_57[1] = val_60;
        val_57[2] = val_60.业上丙丞丐丄丆丅七();
        val_57[3] = val_40.Length;
        val_57[4] = this.丝且与丝丒丟万丁专.丘下丄丗丕业专丟丘;
        val_57[5] = this.丝且与丝丒丟万丁专.丕丕三世世世一与丄;
        val_57[6] = this.丝且与丝丒丟万丁专.丁丏丅丞东且丒下世;
        val_66 = null;
        val_66 = null;
        val_48 = SquadController.丅丐丝下丞下下下上;
        val_57[7] = val_48;
        if(val_56 != null)
        {
            goto label_198;
        }
        
        label_142:
        label_198:
        val_64 = 132;
        val_65 = 5;
        label_172:
        val_56.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  132, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_40);
        label_2:
        val_49 = 0;
        return (bool)val_49;
        label_111:
        val_61 = mem[this.丝且与丝丒丟万丁专.上丂东丗丝丈业万丅 + 56];
        label_112:
        val_42[1] = val_61;
        val_42[2] = val_61.业上丙丞丐丄丆丅七();
        val_42[3] = val_42.Length;
        val_42[4] = this.丝且与丝丒丟万丁专.丘下丄丗丕业专丟丘;
        val_42[5] = this.丝且与丝丒丟万丁专.丕丕三世世世一与丄;
        val_42[6] = this.丝且与丝丒丟万丁专.丁丏丅丞东且丒下世;
        val_67 = null;
        val_67 = null;
        val_42[7] = SquadController.丅丐丝下丞下下下上;
        if(val_56 != null)
        {
            goto label_224;
        }
        
        goto label_225;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
