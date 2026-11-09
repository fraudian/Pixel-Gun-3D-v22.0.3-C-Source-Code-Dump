using UnityEngine;

namespace PGCompany
{
    internal class 丁下丒丕丆下丂丆丌
    {
        // Fields
        private PGCompany.ClanWarMapCellConfig <一丘一丐丝丘且丞丅>k__BackingField;
        internal System.Collections.Generic.List<Rilisoft.OfferItem> 丙一丒丒丐专万丝丐;
        internal System.Collections.Generic.List<Rilisoft.OfferItem> 下丈丛与丄且丝万万;
        private Rilisoft.丝丑丂丛万丐丈丘且 丅万三丆丏丙下世丏;
        private Rilisoft.丒且丐三丁丅丕一业 丑丏丑上万东丟丂丌;
        private int <上七东下丏不丕丐丑>k__BackingField;
        private PGCompany.世丐下丕专东丘丏且 与世七丑丂专专丌丙;
        
        // Properties
        internal PGCompany.ClanWarMapCellConfig 一七且丗不丑丝且三 { get; set; }
        internal int 丌且专丟丐丒丈世丑 { get; }
        internal float 丑丁东丄丕东下丐丈 { get; }
        internal DiscreteVector2 丛丄世七万丗三三且 { get; }
        internal int 下丄丈不与世丐业专 { get; set; }
        internal PGCompany.丒且专三三丄丙丞丞 丟业丛丘一丘丗上七 { get; }
        internal int 丅七丐三与丌丞丝丝 { get; }
        internal float 丟丅丏丄丂丁丈七丙 { get; }
        internal PGCompany.世丐下丕专东丘丏且 万下世三丘丏丑上三 { get; }
        
        // Methods
        internal PGCompany.ClanWarMapCellConfig 世丈丁业丛上丘丗丐()
        {
            return (PGCompany.ClanWarMapCellConfig)this.<一丘一丐丝丘且丞丅>k__BackingField;
        }
        private void 与丟与丂丞丒下七丐(PGCompany.ClanWarMapCellConfig 丙业与丙丗丝不丈东)
        {
            this.<一丘一丐丝丘且丞丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丂一东丝丙万丅且一()
        {
        
        }
        internal float 上上丂与丝丁世业不()
        {
            if(this.丑丏丑上万东丟丂丌 == null)
            {
                    return 0f;
            }
            
            return this.丑丏丑上万东丟丂丌.丝丙丐且丟丅三丛七();
        }
        internal DiscreteVector2 丝专与下丗丐东丛丐()
        {
            if((this.<一丘一丐丝丘且丞丅>k__BackingField) != null)
            {
                    return new DiscreteVector2() {_x = this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate, _y = this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate};
            }
            
            return new DiscreteVector2() {_x = this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate, _y = this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate};
        }
        internal int 业上丙丞丐丄丆丅七()
        {
            return (int)this.<上七东下丏不丕丐丑>k__BackingField;
        }
        private void 丒丞东丈丁丄丑丅且(int 丙业与丙丗丝不丈东)
        {
            this.<上七东下丏不丕丐丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丁下丒丕丆下丂丆丌(PGCompany.ClanWarMapCellConfig 上世丏丁世丟世丆业)
        {
            object val_13;
            var val_14;
            DiscreteVector2 val_15;
            var val_16;
            val_13 = this;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = null;
            val_14 = 1152921537134045936;
            val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.丙一丒丒丐专万丝丐 = val_1;
            this.下丈丛与丄且丝万万 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this.<一丘一丐丝丘且丞丅>k__BackingField = 上世丏丁世丟世丆业;
            if(上世丏丁世丟世丆业.TaskSettings != null)
            {
                    val_14 = 1152921525544440992;
                Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丈丏丑丈丁世丞丒(丐丞与丐世丗与下丗:  上世丏丁世丟世丆业.Complexity).ForEach(action:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.丁下丒丕丆下丂丆丌::丛丒丝上丅丙三丂丒(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑)));
                Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丁七丈丐且丝丐不(丐丞与丐世丗与下丗:  上世丏丁世丟世丆业.Complexity).ForEach(action:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  this, method:  System.Void PGCompany.丁下丒丕丆下丂丆丌::上三丐丄万七丑丏丂(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑)));
                int val_9 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
                this.丅万三丆丏丙下世丏 = 0;
                mem[1152921554201343776] = 0;
                this.丑丏丑上万东丟丂丌 = new Rilisoft.丒且丐三丁丅丕一业(下与且且丞丒丝专丌:  V0.16B);
            }
            
            val_15 = this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate;
            if(上世丏丁世丟世丆业.TaskSettings != null)
            {
                    val_16 = 上世丏丁世丟世丆业.TaskSettings.Id;
            }
            else
            {
                    val_16 = 0;
            }
            
            this.<上七东下丏不丕丐丑>k__BackingField = PGCompany.丂丘丞丂丏七丁丄不.丑丁万下万专丟丙丝(丝丌不东丕丒与丒丅:  new DiscreteVector2() {_x = val_15, _y = val_15}, 丐丑丌丒专上丑丅与:  0);
            if(上世丏丁世丟世丆业.TaskSettings == null)
            {
                    return;
            }
            
            val_15 = 上世丏丁世丟世丆业.TaskSettings.ActionSettings;
            if(上世丏丁世丟世丆业.TaskSettings.ActionSettings.Type != 52)
            {
                    return;
            }
            
            val_13 = this.<上七东下丏不丕丐丑>k__BackingField;
            上世丏丁世丟世丆业.TaskSettings.ActionSettings.cellIndex = val_13;
        }
        internal PGCompany.丒且专三三丄丙丞丞 丏丞丌丁丄东丛下丑()
        {
            PGCompany.ClanWarController val_1 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_1 != null)
            {
                    return val_1.丌与七七且世一丂丁(丝丌不东丕丒与丒丅:  this.<上七东下丏不丕丐丑>k__BackingField);
            }
            
            return val_1.丌与七七且世一丂丁(丝丌不东丕丒与丒丅:  this.<上七东下丏不丕丐丑>k__BackingField);
        }
        internal string 下丁丙一丄丈不不丁()
        {
            if((this.<一丘一丐丝丘且丞丅>k__BackingField.Type) == 2)
            {
                    return PGCompany.丂丘丞丂丏七丁丄不.丒不世丌业不一丆丏(丄丝丏上丄丛丘丟丆:  this.<一丘一丐丝丘且丞丅>k__BackingField.NumClan);
            }
            
            PGCompany.丒且专三三丄丙丞丞 val_2 = this.丏丞丌丁丄东丛下丑();
            if(val_2 != null)
            {
                    return val_2.丙丗丏丂业且不东丞();
            }
            
            return val_2.丙丗丏丂业且不东丞();
        }
        internal int 丒丝丄丆东丘三上丝()
        {
            PGCompany.丒且专三三丄丙丞丞 val_1 = this.丏丞丌丁丄东丛下丑();
            if(val_1 != null)
            {
                    return val_1.专丌丛丞上一业丆丕();
            }
            
            return val_1.专丌丛丞上一业丆丕();
        }
        internal float 下丕丘丟三丞丘上万()
        {
            if(this.下三下东业丘且丟业() == null)
            {
                    return 0f;
            }
            
            float val_5 = (float)this.丒丝丄丆东丘三上丝();
            val_5 = val_5 / (float)this.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
            return 0f;
        }
        internal bool 下下丟丛万丟下上丟()
        {
            return (bool)((this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings) != 0) ? 1 : 0;
        }
        internal PGCompany.世丐下丕专东丘丏且 下三下东业丘且丟业()
        {
            if(this.与世七丑丂专专丌丙 != null)
            {
                    if(this.与世七丑丂专专丌丙.丁丝丞与丟与丟丌三() == this.丁丂丛丂一三不专丁())
            {
                    return (PGCompany.世丐下丕专东丘丏且)this.与世七丑丂专专丌丙;
            }
            
                this.与世七丑丂专专丌丙.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  false);
                PGCompany.世丐下丕专东丘丏且 val_4 = this.且丆丄丂万七丅东与();
                this.与世七丑丂专专丌丙 = val_4;
                if(this.与世七丑丂专专丌丙.丈丐丞丐上丑且丕万() == false)
            {
                    return (PGCompany.世丐下丕专东丘丏且)this.与世七丑丂专专丌丙;
            }
            
                val_4.不上丕不丞业一丗丂(丛丅丘一丏丙且丌上:  true);
                return (PGCompany.世丐下丕专东丘丏且)this.与世七丑丂专专丌丙;
            }
            
            if((this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings) == null)
            {
                    return (PGCompany.世丐下丕专东丘丏且)this.与世七丑丂专专丌丙;
            }
            
            this.与世七丑丂专专丌丙 = this.且丆丄丂万七丅东与();
            return (PGCompany.世丐下丕专东丘丏且)this.与世七丑丂专专丌丙;
        }
        private PGCompany.世丐下丕专东丘丏且 且丆丄丂万七丅东与()
        {
            val_1.cellIndex = this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.ActionSettings.cellIndex;
            PGCompany.丟丒丅丐万丈七且万 val_3 = new PGCompany.丟丒丅丐万丈七且万(丁丅丈丌丟世丗丗丟:  2, 丞丅上丏丂且下丅与:  this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.Id, 丗七丗丒丌三世丌丁:  this.丑丕不且丕丒丝丘丐());
            val_3.丑下丒丄丙七丁丁不(丙业与丙丗丝不丈东:  this.丁丂丛丂一三不专丁());
            int val_5 = this.丒一丂专丈丄丄专丕();
            if(val_3 != null)
            {
                    val_3.且丙丅万且一下丗且(丙业与丙丗丝不丈东:  val_5);
                .丈丝丄不丈万丁丁下 = 3;
                .丛东下丌一丕丌一丁 = this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.Description;
                .三丘丛三丂丙七东一 = this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.HumanReadableId;
            }
            else
            {
                    val_3.且丙丅万且一下丗且(丙业与丙丗丝不丈东:  val_5);
                mem[64] = this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.Description;
                mem[32] = 3;
                mem[72] = this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.HumanReadableId;
            }
            
            val_3.丈丏丁东上与东丙丕().AddRange(collection:  this.丙一丒丒丐专万丝丐);
            return (PGCompany.世丐下丕专东丘丏且)new PGCompany.世丐下丕专东丘丏且(上世丏丁世丟世丆业:  val_3);
        }
        private int 丁丂丛丂一三不专丁()
        {
            return PGCompany.丂丘丞丂丏七丁丄不.丘上不丙丑丌丟一东(丛丌丌丁丌丁丐丈上:  this, 丑且七三丝丁丛下丈:  this.丏丞丌丁丄东丛下丑().上与丌与上下丙丟业());
        }
        private PGCompany.GameTaskActionSettings 丑丕不且丕丒丝丘丐()
        {
            object val_12;
            PGCompany.GameTaskActionSettings val_13;
            val_12 = this;
            PGCompany.GameTaskActionSettings val_4 = 0;
            if(((this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.OptionalActionSettings) != null) && ((this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.OptionalActionSettings.Count) >= 1))
            {
                    val_13 = val_4;
                if(val_13 != 0)
            {
                    if((this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.OptionalActionSettings.TryGetValue(下上丐丆丝丟丝丒不:  this.丏丞丌丁丄东丛下丑().上与丌与上下丙丟业(), 丙业与丙丗丝不丈东: out  val_4)) == true)
            {
                    return val_13;
            }
            
            }
            
                if(val_9.Length != 0)
            {
                    val_12 = this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.OptionalActionSettings;
                val_13 = val_12.Item[System.Linq.Enumerable.Max(source:  System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Where<System.Int32>(source:  this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.OptionalActionSettings.Keys, predicate:  new System.Func<System.Int32, System.Boolean>(object:  this, method:  System.Boolean PGCompany.丁下丒丕丆下丂丆丌::上不丗下丆丅丄丕丐(int 下上丐丆丝丟丝丒不)))))];
                return val_13;
            }
            
            }
            
            val_12 = this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings;
            val_13 = this.<一丘一丐丝丘且丞丅>k__BackingField.TaskSettings.ActionSettings;
            return val_13;
        }
        internal int 丒一丂专丈丄丄专丕()
        {
            return PGCompany.丂丘丞丂丏七丁丄不.丘上不丙丑丌丟一东(丛丌丌丁丌丁丐丈上:  this, 丑且七三丝丁丛下丈:  UnityEngine.Mathf.Max(a:  this.丏丞丌丁丄东丛下丑().上与丌与上下丙丟业() - 1, b:  0));
        }
        internal string 专七东万不下丗丙世()
        {
            return (string)this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate.X.ToString()(this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate.X.ToString()) + "_" + this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate.ToString()(this.<一丘一丐丝丘且丞丅>k__BackingField.Coordinate.ToString());
        }
        private void 丛丒丝上丅丙三丂丒(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑)
        {
            Rilisoft.OfferItemType val_7;
            string val_8;
            if(三丟东丕丄丄下下丑 != null)
            {
                    val_7 = 三丟东丕丄丄下下丑.不业丙丒丂丞下丆丙();
                val_8 = 三丟东丕丄丄下下丑.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_7 = 0.不业丙丒丂丞下丆丙();
                val_8 = 0.业上丙丞丐丄丆丅七();
            }
            
            this.丙一丒丒丐专万丝丐.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  val_7, 丞一丁业丄一一业且:  val_8, 丂丕丂丏专丂丄丕且:  三丟东丕丄丄下下丑.丂丁丏一丙丛业且丌()));
        }
        private void 上三丐丄万七丑丏丂(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑)
        {
            Rilisoft.OfferItemType val_7;
            string val_8;
            if(三丟东丕丄丄下下丑 != null)
            {
                    val_7 = 三丟东丕丄丄下下丑.不业丙丒丂丞下丆丙();
                val_8 = 三丟东丕丄丄下下丑.业上丙丞丐丄丆丅七();
            }
            else
            {
                    val_7 = 0.不业丙丒丂丞下丆丙();
                val_8 = 0.业上丙丞丐丄丆丅七();
            }
            
            this.下丈丛与丄且丝万万.Add(item:  new Rilisoft.OfferItem(下丗丁丒丘东丂不丑:  val_7, 丞一丁业丄一一业且:  val_8, 丂丕丂丏专丂丄丕且:  三丟东丕丄丄下下丑.丂丁丏一丙丛业且丌()));
        }
        private bool 上不丗下丆丅丄丕丐(int 下上丐丆丝丟丝丒不)
        {
            return (bool)(this.丏丞丌丁丄东丛下丑().上与丌与上下丙丟业() >= 下上丐丆丝丟丝丒不) ? 1 : 0;
        }
    
    }

}
