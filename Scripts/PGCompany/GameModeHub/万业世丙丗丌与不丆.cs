using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class 万业世丙丗丌与不丆 : 三丙专上下万七丛东
    {
        // Fields
        internal int 丐丒且丝丛丁丕丟丅;
        internal PGCompany.GameModeHub.丕业丞七丄七丒万东 丐丂丄丘丈专七万下;
        internal Rilisoft.七丕丟丏三丈一丄世 一丗丟丛丈专丙三丌;
        internal string 丝丏丘丁丝上丅丆下;
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆.丘丆专丑七丙丘三丂 丁业丛且一丂一丟丁;
        internal int 丌丛丒丏上业丟丞不;
        
        // Properties
        internal bool 丞上下丄丐丒丈下丌 { get; }
        
        // Methods
        internal bool 丄丟七东万丁上三与()
        {
            return (bool)(this.丌丛丒丏上业丟丞不 > 0) ? 1 : 0;
        }
        internal PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丌丐东业专丑丘丑丗()
        {
            PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅 val_1 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  this.丌丛丒丏上业丟丞不);
            }
            
            return val_1.丗世丑丄丈业与上丌(丞丅上丏丂且下丅与:  this.丌丛丒丏上业丟丞不);
        }
        internal int 丄专专丅七丝丛丙丝()
        {
            int val_5;
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_1 = this.丌丐东业专丑丘丑丗();
            if(val_1 != null)
            {
                    System.Nullable<System.TimeSpan> val_2 = val_1.丙世丑丅丒丑业与不();
                if((8589104 & 1) != 0)
            {
                    System.Nullable<System.TimeSpan> val_3 = val_1.丙世丑丅丒丑业与不();
                val_5 = (int)val_3.HasValue.TotalSeconds;
                return (int)val_5;
            }
            
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        internal override string 丘丄业丞丏与与丅丐()
        {
            return this.丘丄业丞丏与与丅丐();
        }
        internal bool 丑下不丅一丘丒丄丑()
        {
            return GameConnect.丞丗东丆下丈丒东业(丂丛丑东不丅丈一东:  this.一丗丟丛丈专丙三丌);
        }
        public 万业世丙丗丌与不丆()
        {
        
        }
    
    }

}
