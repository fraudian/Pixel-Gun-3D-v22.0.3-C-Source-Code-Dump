using UnityEngine;

namespace LocalNotification
{
    internal class 丝东上丅丟一东丗丗 : IComparable<LocalNotification.丝东上丅丟一东丗丗>
    {
        // Fields
        private readonly string <上七东下丏不丕丐丑>k__BackingField;
        private readonly PGCompany.DataObjects.丑丑丘不一丈丞丐且 <且丈丁专东丆丄丂与>k__BackingField;
        private readonly int <丏万丑万七丅丝丏丅>k__BackingField;
        private readonly System.DateTime <丒丙丝七丞丑东东丝>k__BackingField;
        private readonly object <七下万丏上东上与东>k__BackingField;
        
        // Properties
        internal string 下丄丈不与世丐业专 { get; }
        internal PGCompany.DataObjects.丑丑丘不一丈丞丐且 丒三丝一上丙专丗丒 { get; }
        internal int 丏丕与下丗业丌东丈 { get; }
        internal System.DateTime 丗不不专且丙丑世一 { get; }
        internal object 丈业丐丒专世七三丆 { get; }
        
        // Methods
        internal string 业上丙丞丐丄丆丅七()
        {
            return (string)this.<上七东下丏不丕丐丑>k__BackingField;
        }
        internal PGCompany.DataObjects.丑丑丘不一丈丞丐且 不业丙丒丂丞下丆丙()
        {
            return (PGCompany.DataObjects.丑丑丘不一丈丞丐且)this.<且丈丁专东丆丄丂与>k__BackingField;
        }
        internal int 丏丘丑丈专丈丁丏世()
        {
            return (int)this.<丏万丑万七丅丝丏丅>k__BackingField;
        }
        internal System.DateTime 且丂丞丞三下不万丒()
        {
            return (System.DateTime)this.<丒丙丝七丞丑东东丝>k__BackingField;
        }
        internal object 不且上丆不东丈丑丗()
        {
            return (object)this.<七下万丏上东上与东>k__BackingField;
        }
        internal 丝东上丅丟一东丗丗(string 丞丅上丏丂且下丅与, PGCompany.DataObjects.丑丑丘不一丈丞丐且 丁丅丈丌丟世丗丗丟, int 与丈丂一丌三丈丟丅, System.DateTime 专七世丄丝丙丏丅三, object 丑丘且丁上丒丙丁丕)
        {
            val_1 = new System.Object();
            this.<上七东下丏不丕丐丑>k__BackingField = 丞丅上丏丂且下丅与;
            this.<且丈丁专东丆丄丂与>k__BackingField = 丁丅丈丌丟世丗丗丟;
            this.<丏万丑万七丅丝丏丅>k__BackingField = 与丈丂一丌三丈丟丅;
            this.<丒丙丝七丞丑东东丝>k__BackingField = 专七世丄丝丙丏丅三;
            this.<七下万丏上东上与东>k__BackingField = val_1;
        }
        public int CompareTo(LocalNotification.丝东上丅丟一东丗丗 丘丛丏丘丝七世七丅)
        {
            if((System.Collections.Generic.Comparer<System.Int32>.Default) == null)
            {
                
            }
        
        }
        public bool 万一丅上东七七丆下(LocalNotification.丝东上丅丟一东丗丗 丘丛丏丘丝七世七丅)
        {
            string val_4;
            var val_5;
            val_4 = this.<上七东下丏不丕丐丑>k__BackingField;
            if((((System.String.op_Equality(a:  val_4, b:  丘丛丏丘丝七世七丅.<上七东下丏不丕丐丑>k__BackingField)) != false) && ((this.<且丈丁专东丆丄丂与>k__BackingField) == (丘丛丏丘丝七世七丅.<且丈丁专东丆丄丂与>k__BackingField))) && ((this.<丏万丑万七丅丝丏丅>k__BackingField) == (丘丛丏丘丝七世七丅.<丏万丑万七丅丝丏丅>k__BackingField)))
            {
                    val_4 = this.<丒丙丝七丞丑东东丝>k__BackingField;
                if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_4}, d2:  new System.DateTime() {dateData = 丘丛丏丘丝七世七丅.<丒丙丝七丞丑东东丝>k__BackingField})) != false)
            {
                    var val_3 = ((this.<七下万丏上东上与东>k__BackingField) == (丘丛丏丘丝七世七丅.<七下万丏上东上与东>k__BackingField)) ? 1 : 0;
                return (bool)val_5;
            }
            
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public override string ToString()
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.InvariantCulture;
            return (string)this.<且丈丁专东丆丄丂与>k__BackingField.ToString()(this.<且丈丁专东丆丄丂与>k__BackingField.ToString()) + ": "(": ") + this.<丒丙丝七丞丑东东丝>k__BackingField(this.<丒丙丝七丞丑东东丝>k__BackingField);
        }
    
    }

}
