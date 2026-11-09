using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class DroppedItemData
    {
        // Fields
        public int ChestId;
        public int ContainerId;
        public string EventId;
        public bool IsFreeSpin;
        public Rilisoft.GameEventItemData ItemData;
        public Rilisoft.丒丙丂丛丙且且不丕 DropCategory;
        
        // Methods
        public void 丅专下万丕丑丆丅丝(Rilisoft.GameEventItemData 丏专丕万丘丝与万三, Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌, Rilisoft.GameEventItemContainer 万三丂且丆三且丝且, Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, bool 丄丆丂下不丝东丂一)
        {
            var val_10;
            int val_11;
            Rilisoft.GameEventItemData val_12;
            Rilisoft.丒丙丂丛丙且且不丕 val_13;
            string val_14;
            val_10 = 丅东专与不三丂丁丝;
            val_11 = 丐下丝丘丑丟丟丗丌;
            if(丏专丕万丘丝与万三 != null)
            {
                    val_12 = 丏专丕万丘丝与万三.Clone();
                if(val_12 != null)
            {
                    val_12 = 0;
            }
            
                this.ItemData = val_12;
                mem[104] = 丏专丕万丘丝与万三.Count;
            }
            
            if(val_11 != null)
            {
                    Rilisoft.GameEventChestData val_5 = val_11.丁专丗万三上丟三丆();
                val_11 = val_5.ChestId;
            }
            
            this.ChestId = val_11;
            if(万三丂且丆三且丝且 != null)
            {
                    this.ContainerId = 万三丂且丆三且丝且.Id;
                Rilisoft.丒丙丂丛丙且且不丕 val_7 = 万三丂且丆三且丝且.DropCategory;
            }
            else
            {
                    val_13 = 0;
                this.ContainerId = 0;
            }
            
            this.DropCategory = val_13;
            if(val_10 != null)
            {
                    val_10 = val_10.丁专丗万三上丟三丆();
                val_14 = val_8.EventId;
            }
            
            this.IsFreeSpin = 丄丆丂下不丝东丂一;
            this.EventId = System.String.__il2cppRuntimeField_static_fields;
        }
        public Rilisoft.GameEventItem 丘丗下业东世万丂专()
        {
            object val_8;
            var val_9;
            System.Object[] val_10;
            string val_11;
            val_8 = this;
            Rilisoft.GameEventItemContainer val_1 = this.一一一不万专东下业();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            val_9 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  val_1.AllItems, predicate:  new System.Func<Rilisoft.GameEventItem, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.DroppedItemData::丅丕丙七丛与与丏丟(Rilisoft.GameEventItem 七丞丙丒三丕且丌丟)));
            if(val_9 == null)
            {
                goto label_2;
            }
            
            if(this.ItemData.PresettedCount < 1)
            {
                    return (Rilisoft.GameEventItem)val_9;
            }
            
            val_8 = val_9.Data;
            val_5.PresettedCount = this.ItemData.PresettedCount;
            return (Rilisoft.GameEventItem)val_9;
            label_1:
            val_10 = new object[1];
            val_8 = val_8;
            val_10[0] = val_8;
            val_11 = "event item container for saved item not found. saved item: \'{0}\'";
            goto label_14;
            label_2:
            object[] val_7 = new object[1];
            val_10 = val_7;
            val_8 = val_8;
            val_10[0] = val_8;
            val_11 = "event item for saved item not found. saved item: \'{0}\'";
            label_14:
            UnityEngine.Debug.LogErrorFormat(format:  val_11, args:  val_7);
            val_9 = 0;
            return (Rilisoft.GameEventItem)val_9;
        }
        public Rilisoft.GameEventItemContainer 一一一不万专东下业()
        {
            var val_9;
            if((this.ItemData != null) && (this.ContainerId >= 1))
            {
                    val_9 = 0;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.EventId)) == true)
            {
                    return (Rilisoft.GameEventItemContainer)val_9;
            }
            
                Rilisoft.丛且世丐丆上七业丁 val_3 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  this.EventId);
                if(val_3 == null)
            {
                    return (Rilisoft.GameEventItemContainer)val_9;
            }
            
                Rilisoft.上专业三丟丁丞专下 val_6 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.上专业三丟丁丞专下>(source:  val_3.丄三丐丟丗丄丟上丞(), predicate:  new System.Func<Rilisoft.上专业三丟丁丞专下, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.DroppedItemData::丟丁七丆下丕丏丟丆(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙)));
                if(val_6 == null)
            {
                    return (Rilisoft.GameEventItemContainer)val_9;
            }
            
                Rilisoft.GameEventItemContainer val_8 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItemContainer>(source:  val_6, predicate:  new System.Func<Rilisoft.GameEventItemContainer, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.DroppedItemData::不丑丝丄七一东三丛(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)));
                return (Rilisoft.GameEventItemContainer)val_9;
            }
            
            val_9 = 0;
            return (Rilisoft.GameEventItemContainer)val_9;
        }
        public Rilisoft.丛且世丐丆上七业丁 丌丐东业专丑丘丑丗()
        {
            Rilisoft.三一丈七且丄与丝东 val_1 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  this.EventId);
            }
            
            return val_1.丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  this.EventId);
        }
        public override string ToString()
        {
            var val_3;
            int val_4;
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this.EventId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.EventId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.EventId;
            val_1[1] = this.ChestId;
            if((this.ContainerId != 0) && (this.ContainerId == 0))
            {
                    val_3 = 0;
            }
            
            if(val_1.Length <= 2)
            {
                    val_3 = 0;
            }
            
            val_1[2] = this.ContainerId;
            if(this.ItemData == null)
            {
                goto label_13;
            }
            
            val_4 = this.ItemData;
            if(val_4 != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            val_4 = System.String.alignConst;
            if(val_4 == 0)
            {
                goto label_17;
            }
            
            label_14:
            label_17:
            val_1[3] = val_4;
            return (string)System.String.Format(format:  "event:\'{0}\', chest:\'{1}\', container:\'{2}\', item: {3}", args:  val_1);
        }
        public DroppedItemData()
        {
        
        }
        private bool 丅丕丙七丛与与丏丟(Rilisoft.GameEventItem 七丞丙丒三丕且丌丟)
        {
            int val_10;
            string val_11;
            var val_12;
            val_10 = this;
            val_11 = 七丞丙丒三丕且丌丟.Data.Id;
            if((System.String.op_Equality(a:  val_11, b:  this.ItemData.Id)) != false)
            {
                    val_11 = 七丞丙丒三丕且丌丟.Data.Type;
                if(val_11 == this.ItemData.Type)
            {
                    Rilisoft.GameEventItemData val_8 = 七丞丙丒三丕且丌丟.Data;
                val_11 = this.ItemData;
                val_10 = val_8.SubType;
                var val_9 = (val_10 == this.ItemData.SubType) ? 1 : 0;
                return (bool)val_12;
            }
            
            }
            
            val_12 = 0;
            return (bool)val_12;
        }
        private bool 丟丁七丆下丕丏丟丆(Rilisoft.上专业三丟丁丞专下 丁丂专业丁丅丅丈丙)
        {
            Rilisoft.GameEventChestData val_1 = 丁丂专业丁丅丅丈丙.丁专丗万三上丟三丆();
            return (bool)(val_1.ChestId == this.ChestId) ? 1 : 0;
        }
        private bool 不丑丝丄七一东三丛(Rilisoft.GameEventItemContainer 丁丂专业丁丅丅丈丙)
        {
            return (bool)(丁丂专业丁丅丅丈丙.Id == this.ContainerId) ? 1 : 0;
        }
    
    }

}
