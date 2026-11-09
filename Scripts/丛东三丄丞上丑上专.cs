using UnityEngine;
internal class ModulesContainer.丛东三丄丞上丑上专
{
    // Fields
    internal System.Collections.Generic.List<PGCompany.ModulesContainer.丛东三丄丞上丑上专.与世东且丈丞丏上丅> Modules;
    internal string Gadget;
    
    // Properties
    internal bool 丌丒与丞万七丄万三 { get; }
    internal string 七丌丌丏丗东丕且丅 { get; }
    internal System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丗丈不丌丗三丙下丞 { get; }
    
    // Methods
    internal bool 丆丕上丏专丅丈丌丟()
    {
        return ModulesSetGadgetsStorage.下丗上丑丒与七专丆(丗丑丐丕丟丝且下丕:  this.Gadget);
    }
    internal string 丒万丕七专不丏丞丌()
    {
        ModuleCategory val_4;
        var val_5;
        val_4 = this;
        if(this.Modules.Count >= 1)
        {
                与世东且丈丞丏上丅 val_2 = this.Modules.Item[0];
            val_4 = val_2.Category;
            val_5 = val_4.ToString();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            return (string)val_5;
        }
        
        val_5 = "";
        return (string)val_5;
    }
    internal System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丟上丅丝丐业丟丌丌()
    {
        var val_5;
        int val_11;
        PGCompany.丏丂一丗丙世丏丐三 val_12;
        val_11 = this.Modules.Count;
        System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_2 = new System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三>(capacity:  val_11);
        List.Enumerator<T> val_3 = this.Modules.GetEnumerator();
        label_10:
        if(((-356385840) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        val_12 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  126, 丞丅上丏丂且下丅与:  System.String.Format(format:  "mod_{0}_{1}", arg0:  val_6.m_stringLength, arg1:  val_6.m_firstChar).ToLower());
        if((val_12 != null) && (null != null))
        {
                val_12 = 0;
        }
        
        val_2.Add(item:  val_12);
        goto label_10;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_2;
    }
    public ModulesContainer.丛东三丄丞上丑上专()
    {
        this.Modules = new System.Collections.Generic.List<与世东且丈丞丏上丅>();
    }

}
