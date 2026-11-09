using UnityEngine;

namespace Rilisoft
{
    public abstract class 不丆丐丞业丂丁丑业 : IDisposable
    {
        // Fields
        private string 万三丒东丕丅不丄丆;
        private Rilisoft.LobbyItemPlayerLockerInfo 丈丗丑丂七丂丕七丒;
        private Rilisoft.丏丘七丞丄丙丌丞丁 <一丛丌丆丏丁且丄丐>k__BackingField;
        private 丕专丟上与丄丈三丏.LobbyItemLockInfo <丅三丕丆且丂丕丛丄>k__BackingField;
        private Rilisoft.LobbyItemPlayerInfo <丑丝丌丝丄七丘万业>k__BackingField;
        private System.EventHandler 丆丟丞与丆丝一丐万;
        private System.EventHandler 且业丛世丐丘丞丏丗;
        
        // Properties
        public int 丂业上与丕上丝三丄 { get; }
        public int 丕下丅丝丄丕丗上三 { get; set; }
        public int 且三且上丐万七七世 { get; }
        public bool 丐丈丁丈七世不丂丘 { get; }
        private Rilisoft.LobbyItemPlayerLockerInfo 专丛业丅丕丅丅丅丄 { get; }
        public Rilisoft.丏丘七丞丄丙丌丞丁 东东丛下丕丁丆上丌 { get; set; }
        public 丕专丟上与丄丈三丏.LobbyItemLockInfo 万丑丙丁专丝丄丙丐 { get; set; }
        public Rilisoft.LobbyItemPlayerInfo 三与与一丏丙专丈丗 { get; set; }
        public bool 丟丂丘丝丒七丅丞丁 { get; }
        public string 丛专丈丂丁丘丅世七 { get; }
        
        // Methods
        public 不丆丐丞业丂丁丑业(Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七, 丕专丟上与丄丈三丏.LobbyItemLockInfo 三丙专三丅丁七下丒, Rilisoft.LobbyItemPlayerInfo 东丛下丗且东丄业下)
        {
            val_1 = new System.Object();
            if(下丅丙一丂丗丅丝七 != null)
            {
                    this.<一丛丌丆丏丁且丄丐>k__BackingField = 下丅丙一丂丗丅丝七;
                this.<丅三丕丆且丂丕丛丄>k__BackingField = val_1;
                this.<丑丝丌丝丄七丘万业>k__BackingField = 东丛下丗且东丄业下;
                下丅丙一丂丗丅丝七.丏上不丐丂丆丗三业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.不丆丐丞业丂丁丑业::丅丄丒丏丈丘世丙丌()));
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "items is null");
        }
        public int 丗万丆丟丙不与三丌()
        {
            丕专丟上与丄丈三丏.LobbyItemLockInfo val_7;
            string val_8;
            int val_9;
            val_7 = this;
            if((this.<丅三丕丆且丂丕丛丄>k__BackingField) != null)
            {
                    val_8 = this.<一丛丌丆丏丁且丄丐>k__BackingField.业上丙丞丐丄丆丅七();
                if((BalanceController.七丌三丗丑且丁丛专().ContainsKey(key:  val_8)) != false)
            {
                    val_8 = this.<一丛丌丆丏丁且丄丐>k__BackingField.业上丙丞丐丄丆丅七();
                val_9 = BalanceController.七丌三丗丑且丁丛专();
                if(val_9.Item[val_8] > 0)
            {
                    return (int)val_9;
            }
            
            }
            
                val_7 = this.<丅三丕丆且丂丕丛丄>k__BackingField;
                val_9 = this.<丅三丕丆且丂丕丛丄>k__BackingField.ToUnlockPoints;
                return (int)val_9;
            }
            
            val_9 = 2147483647;
            return (int)val_9;
        }
        public int 丆丕丑丈三丙丁丗丈()
        {
            int val_3;
            if(this.丄丆丟丘丄丙丁三丞() == null)
            {
                    return val_3;
            }
            
            Rilisoft.LobbyItemPlayerLockerInfo val_2 = this.丄丆丟丘丄丙丁三丞();
            val_3 = val_2.PointsGained;
            return val_3;
        }
        private void 三且丝东东专三三丄(int 丙业与丙丗丝不丈东)
        {
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerLockerInfo> val_6;
            if(this.丄丆丟丘丄丙丁三丞() == null)
            {
                    return;
            }
            
            string val_2 = this.<一丛丌丆丏丁且丄丐>k__BackingField.业上丙丞丐丄丆丅七();
            val_2.丙世万丄丐丗万丈世(世七丘丐一且下三丘:  val_2, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            val_6 = this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers;
            if((System.Linq.Enumerable.Any<Rilisoft.LobbyItemPlayerLockerInfo>(source:  val_6, predicate:  new System.Func<Rilisoft.LobbyItemPlayerLockerInfo, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.不丆丐丞业丂丁丑业::丛丒下丘世万丞丝丙(Rilisoft.LobbyItemPlayerLockerInfo 丈丂业丏丕不丆业丑)))) == false)
            {
                    return;
            }
            
            Rilisoft.LobbyItemPlayerLockerInfo val_5 = this.丄丆丟丘丄丙丁三丞();
            val_5.PointsGained = 丙业与丙丗丝不丈东;
        }
        public int 东丑专丟丅丄业丆丁()
        {
            return UnityEngine.Mathf.Max(a:  0, b:  this.丗万丆丟丙不与三丌() - this.丆丕丑丈三丙丁丗丈());
        }
        public bool 丛万不业不丁丆七业()
        {
            if(this.丄丆丟丘丄丙丁三丞() != null)
            {
                    return (bool)val_1.IsComplete;
            }
            
            return (bool)val_1.IsComplete;
        }
        private Rilisoft.LobbyItemPlayerLockerInfo 丄丆丟丘丄丙丁三丞()
        {
            Rilisoft.LobbyItemPlayerInfo val_7;
            Rilisoft.LobbyItemPlayerLockerInfo val_8;
            if(this.丈丗丑丂七丂丕七丒 != null)
            {
                    return (Rilisoft.LobbyItemPlayerLockerInfo)this.丈丗丑丂七丂丕七丒;
            }
            
            val_7 = this.<丑丝丌丝丄七丘万业>k__BackingField;
            if(val_7 == null)
            {
                goto label_2;
            }
            
            if((this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers) != null)
            {
                goto label_3;
            }
            
            this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerLockerInfo>();
            val_7 = this.<丑丝丌丝丄七丘万业>k__BackingField;
            if(val_7 == null)
            {
                goto label_4;
            }
            
            label_3:
            Rilisoft.LobbyItemPlayerLockerInfo val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.LobbyItemPlayerLockerInfo>(source:  this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers, predicate:  new System.Func<Rilisoft.LobbyItemPlayerLockerInfo, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.不丆丐丞业丂丁丑业::丏上丌专丒专丞与丝(Rilisoft.LobbyItemPlayerLockerInfo 丈丂业丏丕不丆业丑)));
            this.丈丗丑丂七丂丕七丒 = val_3;
            if(val_3 != null)
            {
                    return (Rilisoft.LobbyItemPlayerLockerInfo)this.丈丗丑丂七丂丕七丒;
            }
            
            Rilisoft.LobbyItemPlayerLockerInfo val_4 = null;
            val_8 = val_4;
            val_4 = new Rilisoft.LobbyItemPlayerLockerInfo();
            .Type = this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType;
            string val_5 = this.<一丛丌丆丏丁且丄丐>k__BackingField.业上丙丞丐丄丆丅七();
            .PointsGained = val_5.七丘丌丕不下不东七(世七丘丐一且下三丘:  val_5);
            .IsComplete = false;
            this.丈丗丑丂七丂丕七丒 = val_8;
            if((this.<丑丝丌丝丄七丘万业>k__BackingField) == null)
            {
                    val_8 = this.丈丗丑丂七丂丕七丒;
            }
            
            this.<丑丝丌丝丄七丘万业>k__BackingField.Lockers.Add(item:  val_8);
            return (Rilisoft.LobbyItemPlayerLockerInfo)this.丈丗丑丂七丂丕七丒;
            label_2:
            UnityEngine.Debug.LogError(message:  "fail get locker data: nullable player info");
            return (Rilisoft.LobbyItemPlayerLockerInfo)this.丈丗丑丂七丂丕七丒;
            label_4:
        }
        internal int 七丘丌丕不下不东七(string 世七丘丐一且下三丘)
        {
            return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  世七丘丐一且下三丘 + "LockPoints", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        internal void 丙世万丄丐丗万丈世(string 世七丘丐一且下三丘, int 丙业与丙丗丝不丈东)
        {
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  世七丘丐一且下三丘 + "LockPoints", 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        public Rilisoft.丏丘七丞丄丙丌丞丁 丌下下丟丂丆丟万万()
        {
            return (Rilisoft.丏丘七丞丄丙丌丞丁)this.<一丛丌丆丏丁且丄丐>k__BackingField;
        }
        private void 丆丗业丑业万丂三与(Rilisoft.丏丘七丞丄丙丌丞丁 丙业与丙丗丝不丈东)
        {
            this.<一丛丌丆丏丁且丄丐>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public 丕专丟上与丄丈三丏.LobbyItemLockInfo 丟七丕丛丗一丛一丗()
        {
            return (LobbyItemLockInfo)this.<丅三丕丆且丂丕丛丄>k__BackingField;
        }
        private void 一上丄丝丑丈且世丑(丕专丟上与丄丈三丏.LobbyItemLockInfo 丙业与丙丗丝不丈东)
        {
            this.<丅三丕丆且丂丕丛丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.LobbyItemPlayerInfo 丌七丌下丙三世丅一()
        {
            return (Rilisoft.LobbyItemPlayerInfo)this.<丑丝丌丝丄七丘万业>k__BackingField;
        }
        private void 丈东丈丁丕不丗丄丟(Rilisoft.LobbyItemPlayerInfo 丙业与丙丗丝不丈东)
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
            
            丕专丟上与丄丈三丏.下专丕丐丌丂丑丄丒 val_2 = this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType;
            val_2 = val_2 - 1;
            if(val_2 > 4)
            {
                goto label_10;
            }
            
            var val_3 = 106044744;
            val_3 = (106044744 + ((this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType - 1)) << 2) + val_3;
            goto (106044744 + ((this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType - 1)) << 2 + 106044744);
            label_3:
            val_3 = this.万三丒东丕丅不丄丆;
            return (string);
            label_10:
            this.万三丒东丕丅不丄丆 = ;
            return (string);
        }
        public virtual void Dispose()
        {
            this.<一丛丌丆丏丁且丄丐>k__BackingField.丒且丆世专业丁三丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.不丆丐丞业丂丁丑业::丅丄丒丏丈丘世丙丌()));
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
            while(this.丆丟丞与丆丝一丐万 != 1152921543093759368);
        
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
            while(this.丆丟丞与丆丝一丐万 != 1152921543093895944);
        
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
            while(this.且业丛世丐丘丞丏丗 != 1152921543094032528);
        
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
            while(this.且业丛世丐丘丞丏丗 != 1152921543094169104);
        
        }
        protected void 丑万丞与丆丕上丂丄(int 下丝丘丁专丐丅丛丝)
        {
            下丝丘丁专丐丅丛丝 = this.丆丕丑丈三丙丁丗丈() + 下丝丘丁专丐丅丛丝;
            this.丒丏丝业丐丞三丏专(下丝丘丁专丐丅丛丝:  下丝丘丁专丐丅丛丝);
        }
        protected void 丒丏丝业丐丞三丏专(int 下丝丘丁专丐丅丛丝)
        {
            var val_10;
            var val_11;
            Rilisoft.LobbyItemPlayerLockerInfo val_1 = this.丄丆丟丘丄丙丁三丞();
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
                    val_10 = null;
                val_10 = null;
                this.且业丛世丐丘丞丏丗.Invoke(sender:  this, e:  System.EventArgs.Empty);
            }
            
            if(this.丆丕丑丈三丙丁丗丈() > this.丗万丆丟丙不与三丌())
            {
                    this.三且丝东东专三三丄(丙业与丙丗丝不丈东:  this.丗万丆丟丙不与三丌());
            }
            
            if(this.丆丕丑丈三丙丁丗丈() != this.丗万丆丟丙不与三丌())
            {
                    return;
            }
            
            Rilisoft.LobbyItemPlayerLockerInfo val_8 = this.丄丆丟丘丄丙丁三丞();
            val_8.IsComplete = true;
            if(this.丆丟丞与丆丝一丐万 != null)
            {
                    val_11 = null;
                val_11 = null;
                this.丆丟丞与丆丝一丐万.Invoke(sender:  this, e:  System.EventArgs.Empty);
            }
            
            this.<一丛丌丆丏丁且丄丐>k__BackingField.丙丕丞且丕不丘丙丑().一专丂丛丝丆丗丘丌(丙业与丙丗丝不丈东:  true);
        }
        private void 丅丄丒丏丈丘世丙丌()
        {
            this.丈丗丑丂七丂丕七丒 = 0;
        }
        internal static Rilisoft.不丆丐丞业丂丁丑业 丄不且丈丏东丅丈丆(丕专丟上与丄丈三丏.LobbyItemLockInfo 三丙专三丅丁七下丒, Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙, Rilisoft.LobbyItemPlayerInfo 东丛下丗且东丄业下)
        {
            var val_3;
            if(丑丘丕且丆东丏丘丙 == null)
            {
                goto label_1;
            }
            
            if(三丙专三丅丁七下丒 == null)
            {
                goto label_2;
            }
            
            丕专丟上与丄丈三丏.下专丕丐丌丂丑丄丒 val_3 = 三丙专三丅丁七下丒.LockerType;
            val_3 = val_3 - 1;
            if(val_3 > 4)
            {
                goto label_7;
            }
            
            var val_4 = 106044764 + ((三丙专三丅丁七下丒.LockerType - 1)) << 2;
            val_4 = val_4 + 106044764;
            goto (106044764 + ((三丙专三丅丁七下丒.LockerType - 1)) << 2 + 106044764);
            label_1:
            UnityEngine.Debug.LogError(message:  "failed create LobbyItemLocker: nullable lobbyItem");
            goto label_7;
            label_2:
            object[] val_2 = new object[1];
            val_2[0] = 丑丘丕且丆东丏丘丙;
            UnityEngine.Debug.LogErrorFormat(format:  "failed create LobbyItemLocker: nullable lockerInfo for item: {0}", args:  val_2);
            label_7:
            val_3 = 0;
            return (Rilisoft.不丆丐丞业丂丁丑业)val_3;
        }
        private bool 丛丒下丘世万丞丝丙(Rilisoft.LobbyItemPlayerLockerInfo 丈丂业丏丕不丆业丑)
        {
            return (bool)(丈丂业丏丕不丆业丑.Type == (this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType)) ? 1 : 0;
        }
        private bool 丏上丌专丒专丞与丝(Rilisoft.LobbyItemPlayerLockerInfo 丈丂业丏丕不丆业丑)
        {
            return (bool)(丈丂业丏丕不丆业丑.Type == (this.<丅三丕丆且丂丕丛丄>k__BackingField.LockerType)) ? 1 : 0;
        }
    
    }

}
