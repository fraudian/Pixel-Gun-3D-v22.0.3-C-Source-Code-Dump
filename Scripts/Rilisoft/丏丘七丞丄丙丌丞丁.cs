using UnityEngine;

namespace Rilisoft
{
    public class 丏丘七丞丄丙丌丞丁 : IDisposable
    {
        // Fields
        private Rilisoft.LobbyItemsBundle 丑不且东丛专丁丌丘;
        private System.Nullable<bool> 七东且丙一丝丙一世;
        private 丕专丟上与丄丈三丏 <丒丘丁上丆丂一上业>k__BackingField;
        private Rilisoft.LobbyItemPlayerInfo <丑丝丌丝丄七丘万业>k__BackingField;
        private System.Collections.Generic.List<Rilisoft.不丆丐丞业丂丁丑业> <丗丌上丏丒世世丛丕>k__BackingField;
        private System.Action 上东业丐万丈丗丌丕;
        
        // Properties
        public 丕专丟上与丄丈三丏 丁丏专且丙下丒丕不 { get; set; }
        public Rilisoft.LobbyItemPlayerInfo 三与与一丏丙专丈丗 { get; set; }
        public 丕专丟上与丄丈三丏.LobbyItemSlot 丙丕丈一一丝丑七丈 { get; }
        public System.Collections.Generic.List<Rilisoft.不丆丐丞业丂丁丑业> 七万丐丘丛丗丏丒下 { get; set; }
        public string 下丄丈不与世丐业专 { get; }
        public bool 丆丑丈丌丐且丞丈丆 { get; }
        public bool 且丗丈丈世丐丐万七 { get; }
        public long 专且不丗丘丌丒丛一 { get; }
        public long 丝世丌丛丄丘与丂七 { get; }
        public long 世丌且丙丑不业丁专 { get; }
        public bool 不丌丝丗丒丛丏丙丌 { get; }
        public bool 丏丆丒丛丁丄丆专丂 { get; }
        internal 丈丞丕丘丕丗与上一 世业丁且丏丕上且不 { get; }
        public string 丟丈三丏三丂丈丁七 { get; }
        public string 万业丒丗且丑丌丝下 { get; }
        public string 万不三丗丕上丌与专 { get; }
        public string 专业下三业丕丑丙丙 { get; }
        public bool 丛且一与丑丅下丌丏 { get; }
        public bool 业一丌万丝丅上丌下 { get; }
        public bool 不与业万丌丏丌丛一 { get; set; }
        public bool 与丁上丌丝丟丑一丏 { get; }
        public bool 丙三丝丏专丘丈丐业 { get; }
        public bool 且丙丆丏下丘万丆丌 { get; }
        public bool 三丂万下三丂丗业丛 { get; }
        public bool 丁丁一且丆不丛一与 { get; }
        public int 下丅丂专与丗一下与 { get; }
        public int 不丞丐丐丄丞丙下丛 { get; }
        public int 丝丙且下丑丅且丟不 { get; }
        public bool 丒丟丝丑丏丒丅丞一 { get; }
        public Rilisoft.LobbyItemsBundle 丙万丞丆一专与丁与 { get; }
        
        // Methods
        public 丏丘七丞丄丙丌丞丁(丕专丟上与丄丈三丏 东一丁世丑丞业丄丐, Rilisoft.LobbyItemPlayerInfo 东丛下丗且东丄业下)
        {
            丕专丟上与丄丈三丏 val_17;
            var val_18;
            Rilisoft.不丆丐丞业丂丁丑业 val_19;
            string val_20;
            System.Object[] val_21;
            val_17 = 东一丁世丑丞业丄丐;
            val_1 = new System.Object();
            this.<丒丘丁上丆丂一上业>k__BackingField = val_17;
            this.<丑丝丌丝丄七丘万业>k__BackingField = val_1;
            if(val_17.一丘万丑丅丆丐上与() == null)
            {
                    return;
            }
            
            LobbyItemLockInfo[] val_3 = val_17.一丘万丑丅丆丐上与();
            if(val_3.Length == 0)
            {
                    return;
            }
            
            if((this.<丒丘丁上丆丂一上业>k__BackingField.业一业丂世丄专不东()) == true)
            {
                    return;
            }
            
            this.<丗丌上丏丒世世丛丕>k__BackingField = new System.Collections.Generic.List<Rilisoft.不丆丐丞业丂丁丑业>();
            val_17 = val_17.一丘万丑丅丆丐上与();
            val_18 = 0;
            goto label_9;
            label_44:
            丏丘七丞丄丙丌丞丁.丛与丒丞丁丛上丄丆 val_7 = new 丏丘七丞丄丙丌丞丁.丛与丒丞丁丛上丄丆();
            LobbyItemLockInfo val_17 = val_17[0];
            if(val_7 == null)
            {
                goto label_11;
            }
            
            .三丙专三丅丁七下丒 = val_17;
            if(val_17 == null)
            {
                goto label_12;
            }
            
            label_20:
            if((val_1 != null) && (东丛下丗且东丄业下.Lockers != null))
            {
                    if(东丛下丗且东丄业下.Lockers.Count >= 1)
            {
                    Rilisoft.LobbyItemPlayerLockerInfo val_10 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.LobbyItemPlayerLockerInfo>(source:  东丛下丗且东丄业下.Lockers, predicate:  new System.Func<Rilisoft.LobbyItemPlayerLockerInfo, System.Boolean>(object:  val_7, method:  System.Boolean 丏丘七丞丄丙丌丞丁.丛与丒丞丁丛上丄丆::下不丕丈万丑不丛下(Rilisoft.LobbyItemPlayerLockerInfo 丈丂业丏丕不丆业丑)));
            }
            
            }
            
            val_19 = Rilisoft.不丆丐丞业丂丁丑业.丄不且丈丏东丅丈丆(三丙专三丅丁七下丒:  .三丙专三丅丁七下丒, 丑丘丕且丆东丏丘丙:  this, 东丛下丗且东丄业下:  this.<丑丝丌丝丄七丘万业>k__BackingField);
            if(val_19 == null)
            {
                goto label_17;
            }
            
            val_19.丌东三万丄丂丘丈不(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.丏丘七丞丄丙丌丞丁::丟丏一万七上专丆三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.<丗丌上丏丒世世丛丕>k__BackingField.Add(item:  val_19);
            goto label_19;
            label_11:
            mem[16] = val_17;
            if(mem[16] != 0)
            {
                goto label_20;
            }
            
            label_12:
            object[] val_13 = new object[1];
            val_19 = this.<丒丘丁上丆丂一上业>k__BackingField.业上丙丞丐丄丆丅七();
            if(val_13 == null)
            {
                goto label_22;
            }
            
            if(val_19 != null)
            {
                goto label_23;
            }
            
            goto label_39;
            label_17:
            val_19 = new object[2];
            val_19[0] = this.<丒丘丁上丆丂一上业>k__BackingField.业上丙丞丐丄丆丅七();
            val_19[1] = val_6[0x0][0].LockerType;
            val_20 = "nullable locker created in lobby item: \'{0}\', failed create locker type: \'{1}\'";
            val_21 = val_19;
            goto label_37;
            label_22:
            if(val_19 == null)
            {
                goto label_39;
            }
            
            label_23:
            label_39:
            val_13[0] = val_19;
            val_20 = "nullable locker info in lobby item \'{0}\'";
            val_21 = val_13;
            label_37:
            UnityEngine.Debug.LogErrorFormat(format:  val_20, args:  val_13);
            label_19:
            val_18 = 1;
            label_9:
            if(val_18 < val_6.Length)
            {
                goto label_44;
            }
        
        }
        public 丕专丟上与丄丈三丏 丙丕丞且丕不丘丙丑()
        {
            return (丕专丟上与丄丈三丏)this.<丒丘丁上丆丂一上业>k__BackingField;
        }
        private void 丆一丙丁上丁丞丄丒(丕专丟上与丄丈三丏 丙业与丙丗丝不丈东)
        {
            this.<丒丘丁上丆丂一上业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.LobbyItemPlayerInfo 丌七丌下丙三世丅一()
        {
            return (Rilisoft.LobbyItemPlayerInfo)this.<丑丝丌丝丄七丘万业>k__BackingField;
        }
        public void 丈东丈丁丕不丗丄丟(Rilisoft.LobbyItemPlayerInfo 丙业与丙丗丝不丈东)
        {
            this.<丑丝丌丝丄七丘万业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public 丕专丟上与丄丈三丏.LobbyItemSlot 丘专上世与丟丝丟丛()
        {
            if((this.<丒丘丁上丆丂一上业>k__BackingField) != null)
            {
                    return this.<丒丘丁上丆丂一上业>k__BackingField.丘专上世与丟丝丟丛();
            }
            
            return this.<丒丘丁上丆丂一上业>k__BackingField.丘专上世与丟丝丟丛();
        }
        public System.Collections.Generic.List<Rilisoft.不丆丐丞业丂丁丑业> 不丑三丌丈丞丈一丆()
        {
            return (System.Collections.Generic.List<Rilisoft.不丆丐丞业丂丁丑业>)this.<丗丌上丏丒世世丛丕>k__BackingField;
        }
        private void 不丌丁丝丏丒丌不一(System.Collections.Generic.List<Rilisoft.不丆丐丞业丂丁丑业> 丙业与丙丗丝不丈东)
        {
            this.<丗丌上丏丒世世丛丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public string 业上丙丞丐丄丆丅七()
        {
            if((this.<丒丘丁上丆丂一上业>k__BackingField) != null)
            {
                    return this.<丒丘丁上丆丂一上业>k__BackingField.业上丙丞丐丄丆丅七();
            }
            
            return this.<丒丘丁上丆丂一上业>k__BackingField.业上丙丞丐丄丆丅七();
        }
        public bool 丐业丞丘七丈业丏丗()
        {
            if(this.丒丙丙世丅且下丁丐() != null)
            {
                    bool val_3 = this.丒丙丙世丅且下丁丐().Available;
                val_3 = (~val_3) & 1;
                return (bool)val_3;
            }
            
            if((this.<丒丘丁上丆丂一上业>k__BackingField) != null)
            {
                    return this.<丒丘丁上丆丂一上业>k__BackingField.丐业丞丘七丈业丏丗();
            }
            
            return this.<丒丘丁上丆丂一上业>k__BackingField.丐业丞丘七丈业丏丗();
        }
        public bool 丑丆丑三且丛上且丟()
        {
            Rilisoft.LobbyItemPlayerInfo val_4;
            if(this.丝丞世丕丒下东丌丄() == true)
            {
                goto label_0;
            }
            
            val_4 = this.<丑丝丌丝丄七丘万业>k__BackingField;
            if(val_4 == null)
            {
                    return (bool)val_4;
            }
            
            if((this.<丑丝丌丝丄七丘万业>k__BackingField.IsCrafted) == false)
            {
                goto label_2;
            }
            
            label_0:
            val_4 = 0;
            return (bool)val_4;
            label_2:
            var val_3 = (val_4.CraftStartedTime > 0) ? 1 : 0;
            return (bool)val_4;
        }
        public long 下丞丘丏丂丕丄丐丘()
        {
            var val_10;
            System.Nullable<System.Int64> val_1 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(((-194036528) & 1) == 0)
            {
                    return (long)this.丅丞上丘丆下上丘丅();
            }
            
            if(this.丝丞世丕丒下东丌丄() != true)
            {
                    if((this.<丑丝丌丝丄七丘万业>k__BackingField.IsCrafted) == false)
            {
                goto label_6;
            }
            
            }
            
            val_10 = 0;
            return (long)this.丅丞上丘丆下上丘丅();
            label_6:
            long val_9 = this.丅丞上丘丆下上丘丅();
            System.Nullable<System.Int64> val_6 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if(((-194036528) & 1) == 0)
            {
                    return (long)this.丅丞上丘丆下上丘丅();
            }
            
            val_9 = val_9 + ((this.<丑丝丌丝丄七丘万业>k__BackingField.CraftStartedTime) << );
            long val_8 = val_9 - val_6.HasValue.丐丏七丌丕丗业且上();
            return (long)this.丅丞上丘丆下上丘丅();
        }
        public long 丅丞上丘丆下上丘丅()
        {
            var val_4;
            long val_5;
            val_4 = this;
            if(this.丝丞世丕丒下东丌丄() != false)
            {
                    val_5 = 0;
                return val_5;
            }
            
            val_4 = this.<丒丘丁上丆丂一上业>k__BackingField.丅丞上丘丆下上丘丅();
            float val_3 = Rilisoft.LobbyItemsController.丒丈东丟丁七丏万下(丏丟丌丙丏丏丒三丆:  9);
            val_3 = val_3 + 1f;
            val_3 = val_3 * (float)val_4;
            val_5 = (long)val_3;
            return val_5;
        }
        public long 不丅丟上丁丆世丞七()
        {
            long val_2 = this.下丞丘丏丂丕丄丐丘();
            val_2 = this.丅丞上丘丆下上丘丅() - val_2;
            return (long)val_2;
        }
        public bool 且丅一一三七专丑丏()
        {
            var val_8;
            var val_9;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_11;
            if(this.丒丙丙世丅且下丁丐() != null)
            {
                    if(this.丒丙丙世丅且下丁丐().IsMyBandle != true)
            {
                    if(((this.<丑丝丌丝丄七丘万业>k__BackingField) == null) || ((this.<丑丝丌丝丄七丘万业>k__BackingField.IsCrafted) == false))
            {
                goto label_5;
            }
            
            }
            
                val_8 = 1;
                return (bool)val_8;
            }
            
            if((this.<丑丝丌丝丄七丘万业>k__BackingField) == null)
            {
                goto label_7;
            }
            
            var val_4 = ((this.<丑丝丌丝丄七丘万业>k__BackingField.IsCrafted) == true) ? 1 : 0;
            return (bool)val_8;
            label_5:
            val_9 = null;
            val_9 = null;
            val_11 = 丏丘七丞丄丙丌丞丁.<>c.<>9__30_0;
            if(val_11 != null)
            {
                    return System.Linq.Enumerable.All<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丒丙丙世丅且下丁丐().Items, predicate:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_7 = null);
            }
            
            val_11 = val_7;
            val_7 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  丏丘七丞丄丙丌丞丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丏丘七丞丄丙丌丞丁.<>c::丁丈丙下万专丕一丙(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            丏丘七丞丄丙丌丞丁.<>c.<>9__30_0 = val_11;
            return System.Linq.Enumerable.All<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  this.丒丙丙世丅且下丁丐().Items, predicate:  val_7);
            label_7:
            val_8 = 0;
            return (bool)val_8;
        }
        public bool 不专丌丅且丝丗丞下()
        {
            System.Func<TSource, System.Boolean> val_8;
            var val_9;
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_11;
            var val_12;
            if(this.丒丙丙世丅且下丁丐() != null)
            {
                    System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_4 = null;
                val_8 = val_4;
                val_4 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.丏丘七丞丄丙丌丞丁::丈丝丞丙丐下丄业下(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                val_9 = null;
                val_9 = null;
                val_11 = 丏丘七丞丄丙丌丞丁.<>c.<>9__32_1;
                if(val_11 != null)
            {
                    return System.Linq.Enumerable.All<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  val_4), predicate:  System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_6 = null);
            }
            
                val_11 = val_6;
                val_6 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  丏丘七丞丄丙丌丞丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丏丘七丞丄丙丌丞丁.<>c::丟丛丆且一专一上三(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
                丏丘七丞丄丙丌丞丁.<>c.<>9__32_1 = val_11;
                return System.Linq.Enumerable.All<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  System.Linq.Enumerable.Where<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  val_4), predicate:  val_6);
            }
            
            if((this.<丑丝丌丝丄七丘万业>k__BackingField) != null)
            {
                    var val_7 = ((this.<丑丝丌丝丄七丘万业>k__BackingField.IsEquiped) == true) ? 1 : 0;
                return (bool)val_12;
            }
            
            val_12 = 0;
            return (bool)val_12;
        }
        internal 丈丞丕丘丕丗与上一 且丕三丙七且且东下()
        {
            var val_15;
            var val_16;
            var val_17;
            if(this.丝丞世丕丒下东丌丄() == false)
            {
                goto label_1;
            }
            
            val_15 = null;
            val_15 = null;
            丈丞丕丘丕丗与上一 val_2 = null;
            val_16 = val_2;
            label_22:
            val_2 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
            return (丈丞丕丘丕丗与上一)val_16;
            label_1:
            System.Nullable<System.Int64> val_3 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
            if((( & 1) != 0) && ((this.<丑丝丌丝丄七丘万业>k__BackingField) != null))
            {
                    if((this.<丑丝丌丝丄七丘万业>k__BackingField.IsCrafted) == false)
            {
                goto label_9;
            }
            
            }
            
            label_11:
            val_16 = this.<丒丘丁上丆丂一上业>k__BackingField.丑丘上七业丏丅丄丁();
            return (丈丞丕丘丕丗与上一)val_16;
            label_9:
            if((this.<丑丝丌丝丄七丘万业>k__BackingField.CraftStartedTime) <= 0)
            {
                goto label_11;
            }
            
            if((this.<丒丘丁上丆丂一上业>k__BackingField.丑丘上七业丏丅丄丁().丟丂丞不专丆万丒世()) != 0)
            {
                    float val_15 = (float)this.下丞丘丏丂丕丄丐丘();
                val_15 = val_15 / (float)this.丅丞上丘丆下上丘丅();
                int val_17 = this.<丒丘丁上丆丂一上业>k__BackingField.丑丘上七业丏丅丄丁().丟丂丞不专丆万丒世();
                float val_16 = (float)val_17;
                val_16 = val_15 * val_16;
                int val_12 = UnityEngine.Mathf.RoundToInt(f:  val_16);
                val_17 = (val_12 > 1) ? (val_12) : (0 + 1);
            }
            else
            {
                    val_17 = 0;
            }
            
            string val_14 = this.<丒丘丁上丆丂一上业>k__BackingField.丑丘上七业丏丅丄丁().东与三丌丅三丒丏业();
            goto label_22;
        }
        public string 丆丗丒丌且专丒丘七()
        {
            return this.<丒丘丁上丆丂一上业>k__BackingField.业上丙丞丐丄丆丅七()(this.<丒丘丁上丆丂一上业>k__BackingField.业上丙丞丐丄丆丅七()) + "_icon1_big";
        }
        public string 丙三专万丛丟万丝丘()
        {
            return "OfferIcons/"("OfferIcons/") + this.丆丗丒丌且专丒丘七();
        }
        public string 三与丛丑且丐丈业丌()
        {
            if((this.<丒丘丁上丆丂一上业>k__BackingField) != null)
            {
                    return this.<丒丘丁上丆丂一上业>k__BackingField.业上丙丞丐丄丆丅七();
            }
            
            return this.<丒丘丁上丆丂一上业>k__BackingField.业上丙丞丐丄丆丅七();
        }
        public string 丝丑丏丑丄丌丐世丂()
        {
            return "LobbyItemsContent/"("LobbyItemsContent/") + this.三与丛丑且丐丈业丌();
        }
        public bool 丙丄丝丕丏世丏丛丑()
        {
            return Rilisoft.LobbyItemsController.丛且一与丑丅下丌丏(下丅丙一丂丗丅丝七:  this);
        }
        public bool 丈丌专丂丗丌不丞丐()
        {
            bool val_2 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<丒丘丁上丆丂一上业>k__BackingField.三丏丐丗业丝丞丝丄());
            val_2 = (~val_2) & 1;
            return (bool)val_2;
        }
        public bool 丘丘丒丝一业丐丛不()
        {
            if(Rilisoft.NewsHandler.News == null)
            {
                    return false;
            }
            
            if((Rilisoft.NewsHandler.News.Contains(item:  this.业上丙丞丐丄丆丅七())) == false)
            {
                    return false;
            }
            
            if(this.丐万且七专丒七丛丞() == false)
            {
                    return false;
            }
            
            if((Progress.七七世万专丕丁上业.下业一丒丗三丝丆丂().丕丄丗丌不与丌万万(丞丅上丏丂且下丅与:  this.业上丙丞丐丄丆丅七())) == false)
            {
                    return false;
            }
            
            if(this.丐业丞丘七丈业丏丗() == false)
            {
                    return this.丐丙丛世丒丛丞丁万();
            }
            
            return false;
        }
        public void 丗丘丈丂丈丕丒丂丅(bool 丙业与丙丗丝不丈东)
        {
            丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
            this.<丑丝丌丝丄七丘万业>k__BackingField.isNew = 丙业与丙丗丝不丈东;
        }
        public bool 丐万且七专丒七丛丞()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = this;
            if((this.<丑丝丌丝丄七丘万业>k__BackingField) != null)
            {
                    val_6 = null;
                val_6 = null;
                if(ExperienceController.sharedController != 0)
            {
                    val_5 = ExperienceController.丞丞丘业东丙丏七丌();
                var val_4 = (val_5 >= (this.<丒丘丁上丆丂一上业>k__BackingField.丈一下下丞世三丑丄())) ? 1 : 0;
                return (bool)val_7;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public bool 一业丟丁上丑丘丕丄()
        {
            if(this.丐万且七专丒七丛丞() == false)
            {
                    return false;
            }
            
            if(this.丏丕丂且上上下丏七() == false)
            {
                    return false;
            }
            
            return this.丐丙丛世丒丛丞丁万();
        }
        public bool 丐丙丛世丒丛丞丁万()
        {
            var val_12;
            var val_13;
            var val_17;
            val_12 = this;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<丒丘丁上丆丂一上业>k__BackingField.三丏丐丗业丝丞丝丄())) != false)
            {
                    val_13 = 1;
                return (bool)val_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().与不下且且丅东丘世().GetEnumerator();
            label_28:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_19;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            T val_10 = val_6.Current;
            if(val_10 == 0)
            {
                goto label_28;
            }
            
            Rilisoft.GameEventData val_11 = val_10.丁专丗万三上丟三丆();
            if((System.String.op_Equality(a:  val_11.EventId, b:  this.<丒丘丁上丆丂一上业>k__BackingField.三丏丐丗业丝丞丝丄())) == false)
            {
                goto label_28;
            }
            
            val_17 = 0;
            val_12 = 0;
            val_13 = 1;
            if(val_6 != null)
            {
                goto label_31;
            }
            
            goto label_39;
            label_19:
            val_17 = 0;
            val_12 = 0;
            val_13 = 0;
            if(val_6 != null)
            {
                goto label_31;
            }
            
            goto label_39;
            label_31:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_6.Dispose();
            label_39:
            if( == 1)
            {
                goto label_44;
            }
            
            if(101 == 103)
            {
                    return (bool)val_13;
            }
            
            val_13 = 0;
            if( == false)
            {
                    return (bool)val_13;
            }
            
            if(101 != 101)
            {
                goto label_47;
            }
            
            return (bool)val_13;
            label_44:
            if( == false)
            {
                goto label_49;
            }
            
            label_47:
            label_49:
            val_13 = 0;
            return (bool)val_13;
        }
        public bool 丏丕丂且上上下丏七()
        {
            var val_3;
            System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Boolean> val_5;
            if((this.<丗丌上丏丒世世丛丕>k__BackingField) == null)
            {
                    return true;
            }
            
            if((this.<丗丌上丏丒世世丛丕>k__BackingField.Count) == 0)
            {
                    return true;
            }
            
            val_3 = null;
            val_3 = null;
            val_5 = 丏丘七丞丄丙丌丞丁.<>c.<>9__57_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.All<Rilisoft.不丆丐丞业丂丁丑业>(source:  this.<丗丌上丏丒世世丛丕>k__BackingField, predicate:  System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Boolean> val_2 = null);
            }
            
            val_5 = val_2;
            val_2 = new System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Boolean>(object:  丏丘七丞丄丙丌丞丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丏丘七丞丄丙丌丞丁.<>c::丈专丐丒丘丆丌丕世(Rilisoft.不丆丐丞业丂丁丑业 丈丂业丏丕不丆业丑));
            丏丘七丞丄丙丌丞丁.<>c.<>9__57_0 = val_5;
            return System.Linq.Enumerable.All<Rilisoft.不丆丐丞业丂丁丑业>(source:  this.<丗丌上丏丒世世丛丕>k__BackingField, predicate:  val_2);
        }
        public bool 七上丞七丒丅不丘丞()
        {
            if((this.<丗丌上丏丒世世丛丕>k__BackingField) == null)
            {
                    return (bool)((this.<丗丌上丏丒世世丛丕>k__BackingField.Count) > 0) ? 1 : 0;
            }
            
            return (bool)((this.<丗丌上丏丒世世丛丕>k__BackingField.Count) > 0) ? 1 : 0;
        }
        public int 丘丌丕世丏世丙下一()
        {
            var val_3;
            System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32> val_5;
            if(this.七上丞七丒丅不丘丞() == false)
            {
                    return 0;
            }
            
            val_3 = null;
            val_3 = null;
            val_5 = 丏丘七丞丄丙丌丞丁.<>c.<>9__61_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.Sum<Rilisoft.不丆丐丞业丂丁丑业>(source:  this.<丗丌上丏丒世世丛丕>k__BackingField, selector:  System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32> val_2 = null);
            }
            
            val_5 = val_2;
            val_2 = new System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32>(object:  丏丘七丞丄丙丌丞丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丏丘七丞丄丙丌丞丁.<>c::丆三丗世专七专下且(Rilisoft.不丆丐丞业丂丁丑业 丈丂业丏丕不丆业丑));
            丏丘七丞丄丙丌丞丁.<>c.<>9__61_0 = val_5;
            return System.Linq.Enumerable.Sum<Rilisoft.不丆丐丞业丂丁丑业>(source:  this.<丗丌上丏丒世世丛丕>k__BackingField, selector:  val_2);
        }
        public int 丈丘丆丒一与丟丆丙()
        {
            var val_3;
            System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32> val_5;
            if(this.七上丞七丒丅不丘丞() == false)
            {
                    return 0;
            }
            
            val_3 = null;
            val_3 = null;
            val_5 = 丏丘七丞丄丙丌丞丁.<>c.<>9__63_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.Sum<Rilisoft.不丆丐丞业丂丁丑业>(source:  this.<丗丌上丏丒世世丛丕>k__BackingField, selector:  System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32> val_2 = null);
            }
            
            val_5 = val_2;
            val_2 = new System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32>(object:  丏丘七丞丄丙丌丞丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丏丘七丞丄丙丌丞丁.<>c::世丞世丆丗丐一丏且(Rilisoft.不丆丐丞业丂丁丑业 丈丂业丏丕不丆业丑));
            丏丘七丞丄丙丌丞丁.<>c.<>9__63_0 = val_5;
            return System.Linq.Enumerable.Sum<Rilisoft.不丆丐丞业丂丁丑业>(source:  this.<丗丌上丏丒世世丛丕>k__BackingField, selector:  val_2);
        }
        public int 下丅丙业丈丝丑万三()
        {
            var val_3;
            System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32> val_5;
            if(this.七上丞七丒丅不丘丞() == false)
            {
                    return 0;
            }
            
            val_3 = null;
            val_3 = null;
            val_5 = 丏丘七丞丄丙丌丞丁.<>c.<>9__65_0;
            if(val_5 != null)
            {
                    return System.Linq.Enumerable.Sum<Rilisoft.不丆丐丞业丂丁丑业>(source:  this.<丗丌上丏丒世世丛丕>k__BackingField, selector:  System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32> val_2 = null);
            }
            
            val_5 = val_2;
            val_2 = new System.Func<Rilisoft.不丆丐丞业丂丁丑业, System.Int32>(object:  丏丘七丞丄丙丌丞丁.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丏丘七丞丄丙丌丞丁.<>c::不丐七丈三世丘丐三(Rilisoft.不丆丐丞业丂丁丑业 丈丂业丏丕不丆业丑));
            丏丘七丞丄丙丌丞丁.<>c.<>9__65_0 = val_5;
            return System.Linq.Enumerable.Sum<Rilisoft.不丆丐丞业丂丁丑业>(source:  this.<丗丌上丏丒世世丛丕>k__BackingField, selector:  val_2);
        }
        public bool 丝丞世丕丒下东丌丄()
        {
            if((this.七东且丙一丝丙一世 & 1) == 0)
            {
                    Rilisoft.LobbyItemsController val_1 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
                bool val_4 = System.Linq.Enumerable.Any<Rilisoft.LobbyItemsBundle>(source:  val_1.Bundles, predicate:  new System.Func<Rilisoft.LobbyItemsBundle, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.丏丘七丞丄丙丌丞丁::与丟业世一丛万丙三(Rilisoft.LobbyItemsBundle 丌丗丏丏丛东专丁且)));
                this.七东且丙一丝丙一世 = 0;
            }
            
            System.Nullable<System.Boolean> val_5 = this.七东且丙一丝丙一世;
            val_5 = val_5 & 1;
            return (bool)val_5;
        }
        public Rilisoft.LobbyItemsBundle 丒丙丙世丅且下丁丐()
        {
            System.Collections.Generic.List<Rilisoft.LobbyItemsBundle> val_8;
            Rilisoft.LobbyItemsBundle val_9;
            var val_10;
            val_8 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            val_9 = this.丑不且东丛专丁丌丘;
            if(val_9 != null)
            {
                    return val_7;
            }
            
            val_8 = val_1.Bundles;
            val_10 = 0;
            goto label_3;
            label_8:
            if((System.String.op_Equality(a:  val_8.Item[0].Id, b:  this.业上丙丞丐丄丆丅七())) == true)
            {
                goto label_6;
            }
            
            val_10 = 1;
            label_3:
            if(val_10 < val_8.Count)
            {
                goto label_8;
            }
            
            val_9 = this.丑不且东丛专丁丌丘;
            return val_7;
            label_6:
            Rilisoft.LobbyItemsBundle val_7 = val_8.Item[0];
            this.丑不且东丛专丁丌丘 = val_7;
            return val_7;
        }
        public void Dispose()
        {
            var val_3 = this;
            if((this.<丗丌上丏丒世世丛丕>k__BackingField) == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.<丗丌上丏丒世世丛丕>k__BackingField.GetEnumerator();
            label_4:
            if(((-190717624) & 1) == 0)
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
        public void 丏上不丐丂丆丗三业(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.上东业丐万丈丗丌丕, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上东业丐万丈丗丌丕 != 1152921543070979624);
        
        }
        public void 丒且丆世专业丁三丑(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.上东业丐万丈丗丌丕, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.上东业丐万丈丗丌丕 != 1152921543071116200);
        
        }
        public void 东丈专万丆世东丂丄(long 丆丐七丅丆丗丛上与)
        {
            var val_8;
            if((this.<丑丝丌丝丄七丘万业>k__BackingField) != null)
            {
                    val_8 = this.<丑丝丌丝丄七丘万业>k__BackingField.CraftStartedTime;
            }
            else
            {
                    val_8 = 0.CraftStartedTime;
            }
            
            this.<丑丝丌丝丄七丘万业>k__BackingField.CraftStartedTime = val_8 - 丆丐七丅丆丗丛上与;
            System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo> val_5 = new System.Collections.Generic.List<Rilisoft.LobbyItemPlayerInfo>();
            val_5.Add(item:  this.<丑丝丌丝丄七丘万业>k__BackingField);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丛丈丒万丙丗七丐丗(丅丈上丒丄专业丂不:  val_5, 万丐丏丐丒万不丟三:  0);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  2);
            val_6.set_Item(key:  "itemId", value:  this.<丑丝丌丝丄七丘万业>k__BackingField.InfoId);
            val_6.set_Item(key:  "seconds", value:  丆丐七丅丆丗丛上与);
            PGCompany.Analytics.一业丗丆世世上丁且.丛丛丈世丅丘丙丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丅丈丌丟世丗丗丟:  "rewarded video", 丟丛丑丒丆丛东下丌:  "speed up craft", 丗七丟丈三不丕一三:  val_6, 丝丟专丒丅丁丝丘丅:  0);
        }
        private void 丟丏一万七上专丆三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(不丟丗丏丛丕不丁丌 == null)
            {
                    return;
            }
        
        }
        public void 丘七东丁丆丁业丘业(Rilisoft.LobbyItemPlayerInfo 丒上上丑丏丕丒丘与)
        {
            Rilisoft.LobbyItemPlayerInfo val_2;
            var val_3;
            val_2 = this.<丑丝丌丝丄七丘万业>k__BackingField;
            if(val_2 == null)
            {
                goto label_1;
            }
            
            val_3 = 0;
            goto label_2;
            label_1:
            Rilisoft.LobbyItemPlayerInfo val_1 = null;
            val_2 = val_1;
            val_1 = new Rilisoft.LobbyItemPlayerInfo();
            this.<丑丝丌丝丄七丘万业>k__BackingField = val_2;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            val_3 = 1;
            label_2:
            if((val_2 & 1) == 0)
            {
                goto label_4;
            }
            
            if(val_3 != 0)
            {
                goto label_5;
            }
            
            return;
            label_4:
            val_2 = this.<丑丝丌丝丄七丘万业>k__BackingField;
            val_2.且丅丗丂丗丌与且丝(丑东与丅丐丅丂丞业:  丒上上丑丏丕丒丘与);
            label_5:
            if(this.上东业丐万丈丗丌丕 == null)
            {
                    return;
            }
            
            this.上东业丐万丈丗丌丕.Invoke();
            return;
            label_3:
        }
        public string 世丛丐丕丗七一丞一()
        {
            bool val_2 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<丒丘丁上丆丂一上业>k__BackingField.丄上丑专丙丅七一丐());
            if((this.<丒丘丁上丆丂一上业>k__BackingField) == null)
            {
                goto label_4;
            }
            
            if(val_2 == false)
            {
                    return this.<丒丘丁上丆丂一上业>k__BackingField.丄上丑专丙丅七一丐();
            }
            
            label_14:
            if((this.<丒丘丁上丆丂一上业>k__BackingField.丞一下丐丟丏下丅万()) == null)
            {
                    return (string)System.String.alignConst;
            }
            
            LobbyItemBuff[] val_4 = this.<丒丘丁上丆丂一上业>k__BackingField.丞一下丐丟丏下丅万();
            if(val_4.Length == 0)
            {
                    return (string)System.String.alignConst;
            }
            
            LobbyItemBuff val_6 = this.<丒丘丁上丆丂一上业>k__BackingField.丞一下丐丟丏下丅万()[0];
            if(val_6 != null)
            {
                    return val_6.LKey;
            }
            
            return val_6.LKey;
            label_4:
            if(val_2 == true)
            {
                goto label_14;
            }
            
            return this.<丒丘丁上丆丂一上业>k__BackingField.丄上丑专丙丅七一丐();
        }
        private bool 丈丝丞丙丐下丄业下(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)
        {
            System.Collections.Generic.List<System.String> val_2 = this.丒丙丙世丅且下丁丐().ItemsIds;
            if(val_2 != null)
            {
                    return val_2.Contains(item:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七());
            }
            
            return val_2.Contains(item:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七());
        }
        private bool 与丟业世一丛万丙三(Rilisoft.LobbyItemsBundle 丌丗丏丏丛东专丁且)
        {
            return System.String.op_Equality(a:  丌丗丏丏丛东专丁且.Id, b:  this.业上丙丞丐丄丆丅七());
        }
    
    }

}
