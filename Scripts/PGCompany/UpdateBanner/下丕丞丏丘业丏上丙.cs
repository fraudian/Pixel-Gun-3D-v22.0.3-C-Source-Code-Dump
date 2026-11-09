using UnityEngine;

namespace PGCompany.UpdateBanner
{
    internal sealed class 下丕丞丏丘业丏上丙
    {
        // Fields
        private PGCompany.UpdateBanner.丝下丏不丐丘专丑丟 <且丈丁专东丆丄丂与>k__BackingField;
        private string <上丒世丘丗下丌七不>k__BackingField;
        private string <上业丆世下丅丝丁世>k__BackingField;
        private System.Nullable<System.DateTime> <不丒丞丆丛丁一一丈>k__BackingField;
        private int _levelOpen;
        private System.Collections.Generic.Dictionary<string, string> <世丘三万丅丕且丙不>k__BackingField;
        private System.Collections.Generic.Dictionary<string, string> <丈丒丅与丒丑丂下丞>k__BackingField;
        
        // Properties
        internal PGCompany.UpdateBanner.丝下丏不丐丘专丑丟 Type { get; set; }
        internal string EventId { get; set; }
        internal string EventStyle { get; set; }
        internal System.Nullable<System.DateTime> EventEnd { get; set; }
        internal int 丄不丟万丛丒东丝三 { get; set; }
        internal System.Collections.Generic.Dictionary<string, string> TitleTextTable { get; set; }
        internal System.Collections.Generic.Dictionary<string, string> MainTextTable { get; set; }
        internal string 丞七丒丆丆丘丒丙丝 { get; }
        internal string 丅丙世丘七与上丅丞 { get; }
        internal bool 七丑万丕丛世业一世 { get; }
        
        // Methods
        internal PGCompany.UpdateBanner.丝下丏不丐丘专丑丟 不业丙丒丂丞下丆丙()
        {
            return (PGCompany.UpdateBanner.丝下丏不丐丘专丑丟)this.<且丈丁专东丆丄丂与>k__BackingField;
        }
        internal void 东丝丕专丒丏三三与(PGCompany.UpdateBanner.丝下丏不丐丘专丑丟 丙业与丙丗丝不丈东)
        {
            this.<且丈丁专东丆丄丂与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string 丅东丄丛上丁丐万丏()
        {
            return (string)this.<上丒世丘丗下丌七不>k__BackingField;
        }
        internal void 丐与丗上丈丏上丕上(string 丙业与丙丗丝不丈东)
        {
            this.<上丒世丘丗下丌七不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string 丙丂丑下上丏丗丂丘()
        {
            return (string)this.<上业丆世下丅丝丁世>k__BackingField;
        }
        internal void 丆东丐上与丒丒丞丌(string 丙业与丙丗丝不丈东)
        {
            this.<上业丆世下丅丝丁世>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Nullable<System.DateTime> 丞丕丅与且七丄专丐()
        {
            return (System.Nullable<System.DateTime>)this.<不丒丞丆丛丁一一丈>k__BackingField;
        }
        internal void 专丘丒丑下丞专丈三(System.Nullable<System.DateTime> 丙业与丙丗丝不丈东)
        {
            this.<不丒丞丆丛丁一一丈>k__BackingField = 丙业与丙丗丝不丈东;
            mem[1152921559525173312] = ???;
        }
        internal int 丈丒丟下丂丒东与丑()
        {
            return (int)this._levelOpen;
        }
        internal void 三世丗东丆丝七丆丈(int 丙业与丙丗丝不丈东)
        {
            this._levelOpen = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<string, string> 丟与丈丕万丑丂丝丐()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<世丘三万丅丕且丙不>k__BackingField;
        }
        internal void 丂七上丈丟与丝丞上(System.Collections.Generic.Dictionary<string, string> 丙业与丙丗丝不丈东)
        {
            this.<世丘三万丅丕且丙不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<string, string> 七丈上七丗丒丌丅与()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<丈丒丅与丒丑丂下丞>k__BackingField;
        }
        internal void 丄东七丐丅丛丕不丗(System.Collections.Generic.Dictionary<string, string> 丙业与丙丗丝不丈东)
        {
            this.<丈丒丅与丒丑丂下丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string 业丈丂丌丏一一丕上()
        {
            int val_4;
            string val_2 = 0;
            bool val_3 = this.<世丘三万丅丕且丙不>k__BackingField.TryGetValue(key:  丟丏下丂七三下丗丕.丂丁不世且丑丘丅七(), value: out  val_2);
            val_4 = val_2;
            if(val_4 != 0)
            {
                    return (string)val_4;
            }
            
            val_4 = System.String.alignConst;
            return (string)val_4;
        }
        internal string 丒一丞万丆丟丙不丌()
        {
            int val_4;
            string val_2 = 0;
            bool val_3 = this.<丈丒丅与丒丑丂下丞>k__BackingField.TryGetValue(key:  丟丏下丂七三下丗丕.丂丁不世且丑丘丅七(), value: out  val_2);
            val_4 = val_2;
            if(val_4 != 0)
            {
                    return (string)val_4;
            }
            
            val_4 = System.String.alignConst;
            return (string)val_4;
        }
        internal bool 丐丄东丛东丛丕丘且()
        {
            ulong val_3;
            ulong val_4;
            val_3 = this;
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(((-915187072) & 1) == 0)
            {
                goto label_4;
            }
            
            if(( & 1) == 0)
            {
                goto label_4;
            }
            
            val_3 = ;
            val_4 = val_3;
            bool val_2 = System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {});
            goto label_7;
            label_4:
            val_4 = 0;
            label_7:
            val_4 = val_4 & 1;
            return (bool)val_4;
        }
        public 下丕丞丏丘业丏上丙()
        {
        
        }
    
    }

}
