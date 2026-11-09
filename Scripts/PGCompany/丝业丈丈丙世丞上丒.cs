using UnityEngine;

namespace PGCompany
{
    internal sealed class 丝业丈丈丙世丞上丒
    {
        // Fields
        internal System.Action 不丝七丕丐与与上丕;
        private bool <专上丅丈丒丞万不且>k__BackingField;
        private bool 丏丏丒三丑业丒与丅;
        private bool 丟丒丅三丁丏业专下;
        private static PGCompany.丝业丈丈丙世丞上丒 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.丝业丈丈丙世丞上丒 丆丕丝丒不丙且丐丗 { get; }
        internal bool 丝丟七丈丄不业下且 { get; set; }
        
        // Methods
        internal static PGCompany.丝业丈丈丙世丞上丒 丑七不且上丗丁一世()
        {
            PGCompany.丝业丈丈丙世丞上丒.丙丌专东丌丏东丗丕();
            return (PGCompany.丝业丈丈丙世丞上丒)PGCompany.丝业丈丈丙世丞上丒.丝业丆丁业三丈丟东;
        }
        internal bool 丄丙丙丑丝专世上丌()
        {
            return (bool)this.<专上丅丈丒丞万不且>k__BackingField;
        }
        private void 丛上世丙丅丙丞丕丏(bool 丙业与丙丗丝不丈东)
        {
            this.<专上丅丈丒丞万不且>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丝业丈丈丙世丞上丒()
        {
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丝业丈丈丙世丞上丒::丟三丐丈丄丗且丑丒()));
        }
        private void 丟三丐丈丄丗且丑丒()
        {
            this.<专上丅丈丒丞万不且>k__BackingField = false;
            this.丏丏丒三丑业丒与丅 = false;
            if((Rilisoft.Singleton<ClansController>.Instance.丒丆丘上丕丐不丞业()) == true)
            {
                    return;
            }
            
            this.丟丒丅三丁丏业专下 = false;
        }
        internal void 东上丙丙丌丑丆丘丗()
        {
            this.丏丏丒三丑业丒与丅 = true;
            this.万三万丗丄丆且丆丏();
        }
        internal void 业与丏丘一世下三丙()
        {
            this.丟丒丅三丁丏业专下 = true;
            this.万三万丗丄丆且丆丏();
        }
        private void 万三万丗丄丆且丆丏()
        {
            if(this.丏丏丒三丑业丒与丅 == false)
            {
                    return;
            }
            
            if(this.丟丒丅三丁丏业专下 == false)
            {
                    return;
            }
            
            this.<专上丅丈丒丞万不且>k__BackingField = true;
            if(this.不丝七丕丐与与上丕 != null)
            {
                    this.不丝七丕丐与与上丕.Invoke();
            }
            
            this.丏丏丒三丑业丒与丅 = false;
            this.丟丒丅三丁丏业专下 = false;
        }
        private void 且七丙丄丘一丄上不()
        {
            this.丏丏丒三丑业丒与丅 = false;
            this.丟丒丅三丁丏业专下 = false;
        }
        internal static void 丙丌专东丌丏东丗丕()
        {
            PGCompany.丝业丈丈丙世丞上丒 val_2;
            if(PGCompany.丝业丈丈丙世丞上丒.丝业丆丁业三丈丟东 != null)
            {
                    return;
            }
            
            PGCompany.丝业丈丈丙世丞上丒 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.丝业丈丈丙世丞上丒();
            PGCompany.丝业丈丈丙世丞上丒.丝业丆丁业三丈丟东 = val_2;
        }
    
    }

}
