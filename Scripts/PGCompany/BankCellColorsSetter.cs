using UnityEngine;

namespace PGCompany
{
    internal class BankCellColorsSetter : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PGCompany.BankCellColorsSetterData> _data;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(int 世丈三丐丞一丒丛不)
        {
            object val_10;
            var val_11;
            BankCellColorsSetter.丝丂下丂丐丄丁丑丄 val_1 = null;
            val_10 = val_1;
            val_1 = new BankCellColorsSetter.丝丂下丂丐丄丁丑丄();
            .世丈三丐丞一丒丛不 = 世丈三丐丞一丒丛不;
            if((System.Linq.Enumerable.FirstOrDefault<PGCompany.BankCellColorsSetterData>(source:  this._data, predicate:  new System.Func<PGCompany.BankCellColorsSetterData, System.Boolean>(object:  val_1, method:  System.Boolean BankCellColorsSetter.丝丂下丂丐丄丁丑丄::丆一且世上丗上一丗(PGCompany.BankCellColorsSetterData 丐丆丂丒丁万丈丛丅)))) == null)
            {
                    return;
            }
            
            val_10 = val_3.Sprites;
            if(val_10 == null)
            {
                    return;
            }
            
            if(val_3.Colors == null)
            {
                    return;
            }
            
            val_11 = 0;
            goto label_5;
            label_15:
            UIBasicSprite val_4 = val_3.Sprites.Item[0];
            if(val_4 != 0)
            {
                    if(val_11 <= (val_3.Colors.Count - 1))
            {
                    UnityEngine.Color val_8 = val_3.Colors.Item[0];
                val_4.color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
            }
            
            }
            
            val_10 = val_3.Sprites;
            val_11 = 1;
            label_5:
            if(val_11 < val_10.Count)
            {
                goto label_15;
            }
        
        }
        public BankCellColorsSetter()
        {
        
        }
    
    }

}
