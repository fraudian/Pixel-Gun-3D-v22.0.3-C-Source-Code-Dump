using UnityEngine;

namespace PGCompany.BM
{
    internal class 丅万丂丆丟万三三丁 : 丄不丙万与丙东世丕
    {
        // Methods
        internal override bool 丈丗丒不下丙东东三(PGCompany.BM.丘丆丆丁丝且不丄东 丙丑丆上不丒上丕丛, System.Collections.Generic.List<int> 万专东业世且丏七三)
        {
            System.Collections.Generic.List<PGCompany.三丌上丁一丟丐丟丈> val_10;
            PGCompany.BM.丘丆丆丁丝且不丄东 val_11;
            var val_12;
            val_11 = 丙丑丆上不丒上丕丛;
            if((83479.丈丗丒不下丙东东三(丙丑丆上不丒上丕丛:  val_11, 万专东业世且丏七三:  万专东业世且丏七三)) == false)
            {
                goto label_11;
            }
            
            var val_10 = 0;
            label_8:
            val_10 = 丙丑丆上不丒上丕丛.<不丐丁丕丞丈丐下丄>k__BackingField;
            if(val_10 >= val_10.Count)
            {
                goto label_4;
            }
            
            val_10 = 丙丑丆上不丒上丕丛.<不丐丁丕丞丈丐下丄>k__BackingField.Item[0];
            val_10 = val_10 + 1;
            if(val_10 != (PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丙丑丆上不丒上丕丛.<东七丐丈一丌万丈世>k__BackingField._itemIndex).业东丅东丌上丗丑不()))
            {
                goto label_8;
            }
            
            bool val_6 = 丙丑丆上不丒上丕丛.<不丐丁丕丞丈丐下丄>k__BackingField.Remove(item:  val_10);
            label_4:
            if((丙丑丆上不丒上丕丛.<丑丌三万万丙且丄丕>k__BackingField.Count) >= 1)
            {
                    val_11 = 丙丑丆上不丒上丕丛.<不丐丁丕丞丈丐下丄>k__BackingField;
                var val_9 = (val_11.Count > 0) ? 1 : 0;
                return (bool)val_12;
            }
            
            label_11:
            val_12 = 0;
            return (bool)val_12;
        }
        public 丅万丂丆丟万三三丁()
        {
            val_1 = new System.Object();
        }
    
    }

}
