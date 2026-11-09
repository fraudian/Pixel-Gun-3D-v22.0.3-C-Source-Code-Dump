using UnityEngine;

namespace PGCompany.LootBoxSystem
{
    internal sealed class 丏丛且不丏与万一上
    {
        // Fields
        internal Rilisoft.丝丑丂丛万丐丈丘且 LootRateIndex;
        internal string LootGroup;
        internal Rilisoft.丂上丐丄丛一一丒七 Chance;
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> Rewards;
        internal int Order;
        internal Rilisoft.丝丑丂丛万丐丈丘且 Priority;
        
        // Methods
        public override string ToString()
        {
            string[] val_1 = new string[8];
            string val_2 = System.String.Format(format:  "idx={0} ", arg0:  this.LootRateIndex);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = "group=";
            val_1[2] = this.LootGroup;
            val_1[3] = " ";
            val_1[4] = System.String.Format(format:  "chance={0} ", arg0:  this.Chance);
            val_1[5] = System.String.Format(format:  "order={0} ", arg0:  this.Order);
            val_1[6] = "rewards=";
            val_1[7] = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.Rewards);
            return (string)+val_1;
        }
        public 丏丛且不丏与万一上()
        {
        
        }
    
    }

}
