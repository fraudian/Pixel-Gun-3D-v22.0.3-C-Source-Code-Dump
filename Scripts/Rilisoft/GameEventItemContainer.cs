using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameEventItemContainer
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.GameEventItem> _allItems;
        private Rilisoft.GameEventItem _choisedItem;
        private Rilisoft.GameEventItemContainerData _data;
        
        // Properties
        public int Id { get; }
        public Rilisoft.GameEventContainerDropType DropType { get; }
        public Rilisoft.GameEventItemContainerContentType ContentType { get; }
        public Rilisoft.丒丙丂丛丙且且不丕 DropCategory { get; }
        public float DropChance { get; }
        public System.Collections.Generic.List<Rilisoft.GameEventItem> AllItems { get; }
        public bool AnyItemAvailableToDrop { get; }
        public System.Collections.Generic.List<Rilisoft.GameEventItem> AvailableToDropItems { get; }
        
        // Methods
        public GameEventItemContainer(Rilisoft.GameEventItemContainerData 一丐丗丁丞丆丅丟丄)
        {
            this._allItems = new System.Collections.Generic.List<Rilisoft.GameEventItem>();
            this.丑七丂丌世与七丏与(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        public int get_Id()
        {
            if(this._data != null)
            {
                    return (int)this._data.ContainerId;
            }
            
            return (int)this._data.ContainerId;
        }
        public Rilisoft.GameEventContainerDropType get_DropType()
        {
            if(this._data != null)
            {
                    return (Rilisoft.GameEventContainerDropType)this._data.DropType;
            }
            
            return (Rilisoft.GameEventContainerDropType)this._data.DropType;
        }
        public Rilisoft.GameEventItemContainerContentType get_ContentType()
        {
            if(this._data != null)
            {
                    return (Rilisoft.GameEventItemContainerContentType)this._data.ContentType;
            }
            
            return (Rilisoft.GameEventItemContainerContentType)this._data.ContentType;
        }
        public Rilisoft.丒丙丂丛丙且且不丕 get_DropCategory()
        {
            if(this._data != null)
            {
                    return (Rilisoft.丒丙丂丛丙且且不丕)this._data.DropCategory;
            }
            
            return (Rilisoft.丒丙丂丛丙且且不丕)this._data.DropCategory;
        }
        public float get_DropChance()
        {
            if(this._data != null)
            {
                    return (float)this._data.DropChance;
            }
            
            return (float)this._data.DropChance;
        }
        public System.Collections.Generic.List<Rilisoft.GameEventItem> get_AllItems()
        {
            return (System.Collections.Generic.List<Rilisoft.GameEventItem>)this._allItems;
        }
        public bool get_AnyItemAvailableToDrop()
        {
            var val_2;
            System.Func<Rilisoft.GameEventItem, System.Boolean> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = GameEventItemContainer.<>c.<>9__17_0;
            if(val_4 != null)
            {
                    return System.Linq.Enumerable.Any<Rilisoft.GameEventItem>(source:  this._allItems, predicate:  System.Func<Rilisoft.GameEventItem, System.Boolean> val_1 = null);
            }
            
            val_4 = val_1;
            val_1 = new System.Func<Rilisoft.GameEventItem, System.Boolean>(object:  GameEventItemContainer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameEventItemContainer.<>c::丙丟丄丑丆丗丄七世(Rilisoft.GameEventItem 七丞丙丒三丕且丌丟));
            GameEventItemContainer.<>c.<>9__17_0 = val_4;
            return System.Linq.Enumerable.Any<Rilisoft.GameEventItem>(source:  this._allItems, predicate:  val_1);
        }
        public System.Collections.Generic.List<Rilisoft.GameEventItem> get_AvailableToDropItems()
        {
            var val_3;
            System.Func<Rilisoft.GameEventItem, System.Boolean> val_5;
            val_3 = null;
            val_3 = null;
            val_5 = GameEventItemContainer.<>c.<>9__19_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.ToList<Rilisoft.GameEventItem>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItem>(source:  this._allItems, predicate:  System.Func<Rilisoft.GameEventItem, System.Boolean> val_1 = null));
            }
            
            val_5 = val_1;
            val_1 = new System.Func<Rilisoft.GameEventItem, System.Boolean>(object:  GameEventItemContainer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameEventItemContainer.<>c::东万丂丂与三丆丕丑(Rilisoft.GameEventItem 七丞丙丒三丕且丌丟));
            GameEventItemContainer.<>c.<>9__19_0 = val_5;
            return System.Linq.Enumerable.ToList<Rilisoft.GameEventItem>(source:  System.Linq.Enumerable.Where<Rilisoft.GameEventItem>(source:  this._allItems, predicate:  val_1));
        }
        public void 丑七丂丌世与七丏与(Rilisoft.GameEventItemContainerData 一丐丗丁丞丆丅丟丄)
        {
            this._data = 一丐丗丁丞丆丅丟丄;
            this._allItems.Clear();
            List.Enumerator<T> val_1 = this._data.Items.GetEnumerator();
            label_6:
            if(((-338576296) & 1) == 0)
            {
                goto label_4;
            }
            
            new Rilisoft.GameEventItem() = new System.Object();
            ._data = 0.丐丏七丌丕丗业且上();
            this._allItems.Add(item:  new Rilisoft.GameEventItem());
            goto label_6;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public void 且七丙丄丘一丄上不()
        {
            var val_3;
            this._choisedItem = 0;
            List.Enumerator<T> val_1 = this._allItems.GetEnumerator();
            val_3 = 1152921542706402784;
            label_4:
            if(((-338427384) & 1) == 0)
            {
                goto label_2;
            }
            
            if(0.丐丏七丌丕丗业且上() != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public Rilisoft.GameEventItem 丙业丈专万下丄丙丏()
        {
            System.Object[] val_8;
            Rilisoft.GameEventItem val_9;
            System.Func<Rilisoft.GameEventItem, System.Single> val_10;
            var val_11;
            val_8 = this;
            val_9 = this._choisedItem;
            if(val_9 != null)
            {
                    return val_7;
            }
            
            System.Collections.Generic.List<Rilisoft.GameEventItem> val_1 = this.AvailableToDropItems;
            val_10 = 1152921542706720640;
            if(val_1.Count == 0)
            {
                goto label_3;
            }
            
            if(val_1.Count != 1)
            {
                goto label_5;
            }
            
            Rilisoft.GameEventItem val_4 = val_1.Item[0];
            goto label_7;
            label_3:
            object[] val_5 = new object[1];
            val_8 = val_5;
            val_8[0] = this._data.ContainerId;
            UnityEngine.Debug.LogErrorFormat(format:  "no available items in container \'{0}\'", args:  val_5);
            val_9 = 0;
            return val_7;
            label_5:
            val_11 = null;
            val_11 = null;
            val_10 = GameEventItemContainer.<>c.<>9__22_0;
            if(val_10 == null)
            {
                    System.Func<Rilisoft.GameEventItem, System.Single> val_6 = null;
                val_10 = val_6;
                val_6 = new System.Func<Rilisoft.GameEventItem, System.Single>(object:  GameEventItemContainer.<>c.__il2cppRuntimeField_static_fields, method:  System.Single GameEventItemContainer.<>c::丑丐丞丟三丞丐丄丏(Rilisoft.GameEventItem 下丅丙一丂丗丅丝七));
                GameEventItemContainer.<>c.<>9__22_0 = val_10;
            }
            
            Rilisoft.GameEventItem val_7 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<Rilisoft.GameEventItem>(丑东与丅丐丅丂丞业:  val_1, 丆万丒下万下业且丑:  val_6);
            label_7:
            this._choisedItem = val_7;
            return val_7;
        }
        public override string ToString()
        {
            return System.String.Format(format:  "{0}", arg0:  System.Linq.Enumerable.FirstOrDefault<Rilisoft.GameEventItem>(source:  this.AvailableToDropItems));
        }
    
    }

}
