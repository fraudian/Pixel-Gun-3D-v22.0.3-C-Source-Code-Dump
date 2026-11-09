using UnityEngine;

namespace Rilisoft
{
    public abstract class 丆一一东丞三丞东世 : IDisposable
    {
        // Fields
        private string 万三丒东丕丅不丄丆;
        private Rilisoft.FortItemPlayerLockerInfo 丈丗丑丂七丂丕七丒;
        private Rilisoft.东且东丒丐世丐丞丒 <一丛丌丆丏丁且丄丐>k__BackingField;
        private 丞东丌丟与丅丅万丝.FortItemLockInfo <丅三丕丆且丂丕丛丄>k__BackingField;
        private Rilisoft.FortItemPlayerInfo <丑丝丌丝丄七丘万业>k__BackingField;
        private System.EventHandler 丆丟丞与丆丝一丐万;
        private System.EventHandler 且业丛世丐丘丞丏丗;
        
        // Properties
        public int 丂业上与丕上丝三丄 { get; }
        public int 丕下丅丝丄丕丗上三 { get; set; }
        public int 且三且上丐万七七世 { get; }
        public bool 丐丈丁丈七世不丂丘 { get; }
        private Rilisoft.FortItemPlayerLockerInfo 专丛业丅丕丅丅丅丄 { get; }
        public Rilisoft.东且东丒丐世丐丞丒 东东丛下丕丁丆上丌 { get; set; }
        public 丞东丌丟与丅丅万丝.FortItemLockInfo 万丑丙丁专丝丄丙丐 { get; set; }
        public Rilisoft.FortItemPlayerInfo 三与与一丏丙专丈丗 { get; set; }
        public bool 丟丂丘丝丒七丅丞丁 { get; }
        public string 丛专丈丂丁丘丅世七 { get; }
        
        // Methods
        public 丆一一东丞三丞东世(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七, 丞东丌丟与丅丅万丝.FortItemLockInfo 三丙专三丅丁七下丒, Rilisoft.FortItemPlayerInfo 东丛下丗且东丄业下)
        {
            val_1 = new System.Object();
            if(下丅丙一丂丗丅丝七 != null)
            {
                    this.<一丛丌丆丏丁且丄丐>k__BackingField = 下丅丙一丂丗丅丝七;
                this.<丅三丕丆且丂丕丛丄>k__BackingField = val_1;
                this.<丑丝丌丝丄七丘万业>k__BackingField = 东丛下丗且东丄业下;
                下丅丙一丂丗丅丝七.丏上不丐丂丆丗三业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丆一一东丞三丞东世::丅丄丒丏丈丘世丙丌()));
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "items is null");
        }
        public int 丗万丆丟丙不与三丌()
        {
            if((this.<丅三丕丆且丂丕丛丄>k__BackingField) == null)
            {
                    return 2147483647;
            }
            
            return (int)this.<丅三丕丆且丂丕丛丄>k__BackingField.ToUnlockPoints;
        }
        public int 丆丕丑丈三丙丁丗丈()
        {
            int val_3;
            if(this.丄丆丟丘丄丙丁三丞() == null)
            {
                    return val_3;
            }
            
            Rilisoft.FortItemPlayerLockerInfo val_2 = this.丄丆丟丘丄丙丁三丞();
            val_3 = val_2.PointsGained;
            return val_3;
        }
        private void 三且丝东东专三三丄(int 丙业与丙丗丝不丈东)
        {
            System.Collections.Generic.List<Rilisoft.FortItemPlayerLockerInfo> val_5;
            if(this.丄丆丟丘丄丙丁三丞() == null)
            {
                    return;
            }
            
            val_5 = this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers;
            if((System.Linq.Enumerable.Any<Rilisoft.FortItemPlayerLockerInfo>(source:  val_5, predicate:  new System.Func<Rilisoft.FortItemPlayerLockerInfo, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.丆一一东丞三丞东世::丛丒下丘世万丞丝丙(Rilisoft.FortItemPlayerLockerInfo 丈丂业丏丕不丆业丑)))) == false)
            {
                    return;
            }
            
            Rilisoft.FortItemPlayerLockerInfo val_4 = this.丄丆丟丘丄丙丁三丞();
            val_4.PointsGained = 丙业与丙丗丝不丈东;
        }
        public int 东丑专丟丅丄业丆丁()
        {
            int val_3;
            if((this.<丅三丕丆且丂丕丛丄>k__BackingField) != null)
            {
                    val_3 = this.<丅三丕丆且丂丕丛丄>k__BackingField.ToUnlockPoints;
                return UnityEngine.Mathf.Max(a:  0, b:  val_3 - this.丆丕丑丈三丙丁丗丈());
            }
            
            val_3 = 2147483647;
            return UnityEngine.Mathf.Max(a:  0, b:  val_3 - this.丆丕丑丈三丙丁丗丈());
        }
        public bool 丛万不业不丁丆七业()
        {
            if(this.丄丆丟丘丄丙丁三丞() != null)
            {
                    return (bool)val_1.IsComplete;
            }
            
            return (bool)val_1.IsComplete;
        }
        private Rilisoft.FortItemPlayerLockerInfo 丄丆丟丘丄丙丁三丞()
        {
            Rilisoft.FortItemPlayerInfo val_5;
            Rilisoft.FortItemPlayerLockerInfo val_6;
            if(this.丈丗丑丂七丂丕七丒 != null)
            {
                    return (Rilisoft.FortItemPlayerLockerInfo)this.丈丗丑丂七丂丕七丒;
            }
            
            val_5 = this.<丑丝丌丝丄七丘万业>k__BackingField;
            if(val_5 == null)
            {
                goto label_2;
            }
            
            if((this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers) != null)
            {
                goto label_3;
            }
            
            this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers = new System.Collections.Generic.List<Rilisoft.FortItemPlayerLockerInfo>();
            val_5 = this.<丑丝丌丝丄七丘万业>k__BackingField;
            if(val_5 == null)
            {
                goto label_4;
            }
            
            label_3:
            Rilisoft.FortItemPlayerLockerInfo val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.FortItemPlayerLockerInfo>(source:  this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers, predicate:  new System.Func<Rilisoft.FortItemPlayerLockerInfo, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.丆一一东丞三丞东世::丏上丌专丒专丞与丝(Rilisoft.FortItemPlayerLockerInfo 丈丂业丏丕不丆业丑)));
            this.丈丗丑丂七丂丕七丒 = val_3;
            if(val_3 != null)
            {
                    return (Rilisoft.FortItemPlayerLockerInfo)this.丈丗丑丂七丂丕七丒;
            }
            
            Rilisoft.FortItemPlayerLockerInfo val_4 = null;
            val_6 = val_4;
            val_4 = new Rilisoft.FortItemPlayerLockerInfo();
            if(val_6 == null)
            {
                goto label_7;
            }
            
            .PointsGained = 0;
            .Type = this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType;
            goto label_8;
            label_2:
            UnityEngine.Debug.LogError(message:  "fail get locker data: nullable player info");
            return (Rilisoft.FortItemPlayerLockerInfo)this.丈丗丑丂七丂丕七丒;
            label_7:
            mem[24] = this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType;
            .PointsGained = 0;
            label_8:
            .IsComplete = false;
            this.丈丗丑丂七丂丕七丒 = val_6;
            if((this.<丑丝丌丝丄七丘万业>k__BackingField) == null)
            {
                    val_6 = this.丈丗丑丂七丂丕七丒;
            }
            
            this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers.Add(item:  val_6);
            return (Rilisoft.FortItemPlayerLockerInfo)this.丈丗丑丂七丂丕七丒;
            label_4:
        }
        public Rilisoft.东且东丒丐世丐丞丒 丌下下丟丂丆丟万万()
        {
            return (Rilisoft.东且东丒丐世丐丞丒)this.<一丛丌丆丏丁且丄丐>k__BackingField;
        }
        private void 丆丗业丑业万丂三与(Rilisoft.东且东丒丐世丐丞丒 丙业与丙丗丝不丈东)
        {
            this.<一丛丌丆丏丁且丄丐>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public 丞东丌丟与丅丅万丝.FortItemLockInfo 丟七丕丛丗一丛一丗()
        {
            return (FortItemLockInfo)this.<丅三丕丆且丂丕丛丄>k__BackingField;
        }
        private void 一上丄丝丑丈且世丑(丞东丌丟与丅丅万丝.FortItemLockInfo 丙业与丙丗丝不丈东)
        {
            this.<丅三丕丆且丂丕丛丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.FortItemPlayerInfo 丌七丌下丙三世丅一()
        {
            return (Rilisoft.FortItemPlayerInfo)this.<丑丝丌丝丄七丘万业>k__BackingField;
        }
        private void 丈东丈丁丕不丗丄丟(Rilisoft.FortItemPlayerInfo 丙业与丙丗丝不丈东)
        {
            this.<丑丝丌丝丄七丘万业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool 丐丟不万不丛上东专()
        {
            if((this.<一丛丌丆丏丁且丄丐>k__BackingField) == null)
            {
                    return (bool)this.<一丛丌丆丏丁且丄丐>k__BackingField;
            }
            
            return this.<一丛丌丆丏丁且丄丐>k__BackingField.丐万且七专丒七丛丞();
        }
        public string 丂丝丅丗丟一丑下与()
        {
            string val_3;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.万三丒东丕丅不丄丆)) == false)
            {
                goto label_3;
            }
            
            丞东丌丟与丅丅万丝.丟丟丁不丛丟丅七三 val_2 = this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType;
            val_2 = val_2 - 1;
            if(val_2 > 4)
            {
                goto label_10;
            }
            
            var val_3 = 106032876;
            val_3 = (106032876 + ((this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType - 1)) << 2) + val_3;
            goto (106032876 + ((this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType - 1)) << 2 + 106032876);
            label_3:
            val_3 = this.万三丒东丕丅不丄丆;
            return (string);
            label_10:
            this.万三丒东丕丅不丄丆 = ;
            return (string);
        }
        public virtual void Dispose()
        {
            this.<一丛丌丆丏丁且丄丐>k__BackingField.丒且丆世专业丁三丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.丆一一东丞三丞东世::丅丄丒丏丈丘世丙丌()));
        }
        public void 丌东三万丄丂丘丈不(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丆丟丞与丆丝一丐万, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丆丟丞与丆丝一丐万 != 1152921542628100824);
        
        }
        public void 专丗专万不一丂丈丂(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丆丟丞与丆丝一丐万, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丆丟丞与丆丝一丐万 != 1152921542628237400);
        
        }
        public void 丄丈丄丂与丛丈业东(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.且业丛世丐丘丞丏丗, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.且业丛世丐丘丞丏丗 != 1152921542628373984);
        
        }
        public void 一丝丝与丒东丅丝不(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.且业丛世丐丘丞丏丗, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.且业丛世丐丘丞丏丗 != 1152921542628510560);
        
        }
        protected void 丑万丞与丆丕上丂丄(int 下丝丘丁专丐丅丛丝)
        {
            下丝丘丁专丐丅丛丝 = this.丆丕丑丈三丙丁丗丈() + 下丝丘丁专丐丅丛丝;
            this.丒丏丝业丐丞三丏专(下丝丘丁专丐丅丛丝:  下丝丘丁专丐丅丛丝);
        }
        protected void 丒丏丝业丐丞三丏专(int 下丝丘丁专丐丅丛丝)
        {
            var val_6;
            int val_7;
            int val_8;
            int val_9;
            var val_10;
            Rilisoft.FortItemPlayerLockerInfo val_1 = this.丄丆丟丘丄丙丁三丞();
            if(val_1.IsComplete == true)
            {
                    return;
            }
            
            if(this.丆丕丑丈三丙丁丗丈() == 下丝丘丁专丐丅丛丝)
            {
                    return;
            }
            
            this.三且丝东东专三三丄(丙业与丙丗丝不丈东:  下丝丘丁专丐丅丛丝);
            if(this.且业丛世丐丘丞丏丗 != null)
            {
                    val_6 = null;
                val_6 = null;
                this.且业丛世丐丘丞丏丗.Invoke(sender:  this, e:  System.EventArgs.Empty);
            }
            
            if((this.<丅三丕丆且丂丕丛丄>k__BackingField) != null)
            {
                    val_7 = this.<丅三丕丆且丂丕丛丄>k__BackingField.ToUnlockPoints;
            }
            else
            {
                    val_7 = 2147483647;
            }
            
            if(this.丆丕丑丈三丙丁丗丈() > val_7)
            {
                    if((this.<丅三丕丆且丂丕丛丄>k__BackingField) != null)
            {
                    val_8 = this.<丅三丕丆且丂丕丛丄>k__BackingField.ToUnlockPoints;
            }
            else
            {
                    val_8 = 2147483647;
            }
            
                this.三且丝东东专三三丄(丙业与丙丗丝不丈东:  2147483647);
            }
            
            if((this.<丅三丕丆且丂丕丛丄>k__BackingField) != null)
            {
                    val_9 = this.<丅三丕丆且丂丕丛丄>k__BackingField.ToUnlockPoints;
            }
            else
            {
                    val_9 = 2147483647;
            }
            
            if(this.丆丕丑丈三丙丁丗丈() != val_9)
            {
                    return;
            }
            
            Rilisoft.FortItemPlayerLockerInfo val_5 = this.丄丆丟丘丄丙丁三丞();
            val_5.IsComplete = true;
            if(this.丆丟丞与丆丝一丐万 == null)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            this.丆丟丞与丆丝一丐万.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        private void 丅丄丒丏丈丘世丙丌()
        {
            this.丈丗丑丂七丂丕七丒 = 0;
        }
        internal static Rilisoft.丆一一东丞三丞东世 丄不且丈丏东丅丈丆(丞东丌丟与丅丅万丝.FortItemLockInfo 三丙专三丅丁七下丒, Rilisoft.东且东丒丐世丐丞丒 三丐业七丘丂丐下丘, Rilisoft.FortItemPlayerInfo 东丛下丗且东丄业下)
        {
            var val_3;
            if(三丐业七丘丂丐下丘 == null)
            {
                goto label_1;
            }
            
            if(三丙专三丅丁七下丒 == null)
            {
                goto label_2;
            }
            
            丞东丌丟与丅丅万丝.丟丟丁不丛丟丅七三 val_3 = 三丙专三丅丁七下丒.LockerType;
            val_3 = val_3 - 1;
            if(val_3 > 4)
            {
                goto label_7;
            }
            
            var val_4 = 106032896 + ((三丙专三丅丁七下丒.LockerType - 1)) << 2;
            val_4 = val_4 + 106032896;
            goto (106032896 + ((三丙专三丅丁七下丒.LockerType - 1)) << 2 + 106032896);
            label_1:
            UnityEngine.Debug.LogError(message:  "failed create FortItemLocker: nullable fortItem");
            goto label_7;
            label_2:
            object[] val_2 = new object[1];
            val_2[0] = 三丐业七丘丂丐下丘;
            UnityEngine.Debug.LogErrorFormat(format:  "failed create FortItemLocker: nullable lockerInfo for item: {0}", args:  val_2);
            label_7:
            val_3 = 0;
            return (Rilisoft.丆一一东丞三丞东世)val_3;
        }
        private bool 丛丒下丘世万丞丝丙(Rilisoft.FortItemPlayerLockerInfo 丈丂业丏丕不丆业丑)
        {
            return (bool)(丈丂业丏丕不丆业丑.Type == (this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType)) ? 1 : 0;
        }
        private bool 丏上丌专丒专丞与丝(Rilisoft.FortItemPlayerLockerInfo 丈丂业丏丕不丆业丑)
        {
            return (bool)(丈丂业丏丕不丆业丑.Type == (this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType)) ? 1 : 0;
        }
    
    }

}
