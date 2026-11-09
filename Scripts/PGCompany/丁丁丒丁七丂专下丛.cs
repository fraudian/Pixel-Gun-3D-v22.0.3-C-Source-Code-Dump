using UnityEngine;

namespace PGCompany
{
    internal sealed class 丁丁丒丁七丂专下丛
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 丄七丗业丐万丁丆丄;
        private Rilisoft.丛且世丐丆上七业丁 且丞丂丐不丐不丂丒;
        private Rilisoft.上专业三丟丁丞专下 不丑丆丌世丁丛与一;
        private Rilisoft.GameEventDropChanceData 一万丑丅丘丑专与丆;
        private Rilisoft.GameEventDropChanceData.一七下丝丐丞丁万丌 丈丅丑丅专丝七丆一;
        private Rilisoft.丒丙丂丛丙且且不丕 丙世丘丐一丗丏下世;
        private bool <丆丕业世丙丕丆不丁>k__BackingField;
        private PGCompany.三东丏不丗世丅丌丄 <丑七不丛一丁世丏业>k__BackingField;
        
        // Properties
        internal bool 不专丞丐一丁上下丁 { get; set; }
        internal PGCompany.三东丏不丗世丅丌丄 丒丆丕丁丟业上七丅 { get; set; }
        
        // Methods
        internal bool 不丐丗丝业丅下丆东()
        {
            return (bool)this.<丆丕业世丙丕丆不丁>k__BackingField;
        }
        private void 专丁丘丐丆不丅丂丗(bool 丙业与丙丗丝不丈东)
        {
            this.<丆丕业世丙丕丆不丁>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.三东丏不丗世丅丌丄 丟丂丞不专丆万丒世()
        {
            return (PGCompany.三东丏不丗世丅丌丄)this.<丑七不丛一丁世丏业>k__BackingField;
        }
        private void 三专丞丝与丐万丆七(PGCompany.三东丏不丗世丅丌丄 丙业与丙丗丝不丈东)
        {
            this.<丑七不丛一丁世丏业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丁丁丒丁七丂专下丛(System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 东丆一丝三不世万丙, Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝, Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌, Rilisoft.GameEventDropChanceData 丐丐万丕丛丑丗丏丁)
        {
            System.Collections.Generic.List<一七下丝丐丞丁万丌> val_9;
            IntPtr val_11;
            val_1 = new System.Object();
            this.丄七丗业丐万丁丆丄 = 东丆一丝三不世万丙;
            this.且丞丂丐不丐不丂丒 = val_1;
            this.不丑丆丌世丁丛与一 = 丐下丝丘丑丟丟丗丌;
            this.一万丑丅丘丑专与丆 = 丐丐万丕丛丑丗丏丁;
            Rilisoft.GameEventType val_2 = val_1.不业丙丒丂丞下丆丙();
            if((val_2 == 300) || (val_2 == 200))
            {
                goto label_3;
            }
            
            if(val_2 != 100)
            {
                goto label_4;
            }
            
            val_9 = 丐丐万丕丛丑丗丏丁.ChestsDatas;
            val_11 = 1152921555329726848;
            goto label_6;
            label_3:
            val_9 = 丐丐万丕丛丑丗丏丁.RouletteDatas;
            System.Func<一七下丝丐丞丁万丌, System.Boolean> val_3 = null;
            val_11 = 1152921555329736064;
            label_6:
            val_3 = new System.Func<一七下丝丐丞丁万丌, System.Boolean>(object:  this, method:  val_11);
            this.丈丅丑丅专丝七丆一 = System.Linq.Enumerable.FirstOrDefault<一七下丝丐丞丁万丌>(source:  val_9, predicate:  val_3);
            label_4:
            this.<丑七不丛一丁世丏业>k__BackingField = this.丂一丆丂且三丟丗一();
            this.<丆丕业世丙丕丆不丁>k__BackingField = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  this.<丑七不丛一丁世丏业>k__BackingField, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        internal System.Collections.Generic.List<Rilisoft.GameEventItemContainer> 丌丂七丕丕丈丂丑丟()
        {
            System.Collections.Generic.List<Rilisoft.GameEventItemContainer> val_6;
            if((((this.且丞丂丐不丐不丂丒 != null) && (this.不丑丆丌世丁丛与一 != null)) && (this.一万丑丅丘丑专与丆 != null)) && (this.丈丅丑丅专丝七丆一 != null))
            {
                    System.Collections.Generic.Dictionary<Rilisoft.丒丙丂丛丙且且不丕, System.Int32> val_1 = this.丘丞丌丒丛万丘丈业();
                if(val_1.Count != 0)
            {
                    this.丙世丘丐一丗丏下世 = 丞东丑专丛丆丄丝世.丄三七丂专丆七丏丗<Rilisoft.丒丙丂丛丙且且不丕>(丑东与丅丐丅丂丞业:  val_1);
                System.Collections.Generic.List<T> val_5 = this.丄七丗业丐万丁丆丄.FindAll(match:  new System.Predicate<Rilisoft.GameEventItemContainer>(object:  this, method:  System.Boolean PGCompany.丁丁丒丁七丂专下丛::丞丝丂专丟东丆丏丅(Rilisoft.GameEventItemContainer 丈丛丘丙东专七七且)));
                return val_6;
            }
            
            }
            
            val_6 = this.丄七丗业丐万丁丆丄;
            return val_6;
        }
        internal void 世丗丒丐丑丝丄丏丄()
        {
            var val_13;
            object val_38;
            System.Collections.Generic.Dictionary<Rilisoft.丒丙丂丛丙且且不丕, System.Int32> val_39;
            GameEventDropChanceData.丙三丏一丈上且丌丒 val_40;
            丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐 val_1 = null;
            val_38 = val_1;
            val_1 = new 丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐();
            .丝且与丝丒丟万丁专 = this;
            if(this.且丞丂丐不丐不丂丒 == null)
            {
                    return;
            }
            
            if(this.不丑丆丌世丁丛与一 == null)
            {
                    return;
            }
            
            if(this.一万丑丅丘丑专与丆 == null)
            {
                    return;
            }
            
            if(this.丈丅丑丅专丝七丆一 == null)
            {
                    return;
            }
            
            .丌丕一丂丏与丈三世 = new System.Collections.Generic.Dictionary<Rilisoft.丒丙丂丛丙且且不丕, System.Int32>();
            .丐丟丟丌东业丂万丄 = new System.Collections.Generic.Dictionary<Rilisoft.丒丙丂丛丙且且不丕, System.Int32>();
            val_39 = 1152921504615686144;
            this.丈丅丑丅专丝七丆一.ChanceDatas.ForEach(action:  new System.Action<丙三丏一丈上且丌丒>(object:  val_1, method:  System.Void 丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐::上丘丝丞丆丛丘丗丂(Rilisoft.GameEventDropChanceData.丙三丏一丈上且丌丒 一丐丗丁丞丆丅丟丄)));
            this.丈丅丑丅专丝七丆一.ChanceDatas.ForEach(action:  new System.Action<丙三丏一丈上且丌丒>(object:  val_1, method:  System.Void 丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐::丞专丆丘丗专不丌丕(Rilisoft.GameEventDropChanceData.丙三丏一丈上且丌丒 一丐丗丁丞丆丅丟丄)));
            val_40 = System.Linq.Enumerable.FirstOrDefault<丙三丏一丈上且丌丒>(source:  this.丈丅丑丅专丝七丆一.ChanceDatas, predicate:  new System.Func<丙三丏一丈上且丌丒, System.Boolean>(object:  val_1, method:  System.Boolean 丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐::丗丕专丏丟与东与不(Rilisoft.GameEventDropChanceData.丙三丏一丈上且丌丒 下丂世丟一上世丆世)));
            if(val_40 == null)
            {
                    GameEventDropChanceData.丙三丏一丈上且丌丒 val_8 = null;
                val_40 = val_8;
                val_8 = new GameEventDropChanceData.丙三丏一丈上且丌丒();
            }
            
            if((this.<丆丕业世丙丕丆不丁>k__BackingField) == false)
            {
                goto label_43;
            }
            
            if(val_8.丌七万丞丅业丑丕丗() == 0)
            {
                    val_39 = (丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄;
                val_39.set_Item(key:  this.丙世丘丐一丗丏下世, value:  val_8.丒且丁丑下专丘丈业());
            }
            
            List.Enumerator<T> val_11 = this.丈丅丑丅专丝七丆一.ChanceDatas.GetEnumerator();
            label_30:
            if(((-816151840) & 1) == 0)
            {
                goto label_19;
            }
            
            string val_14 = val_13.丐丏七丌丕丗业且上();
            if(val_14.m_stringLength == this.丙世丘丐一丗丏下世)
            {
                    if(val_14.丌七万丞丅业丑丕丗() == 0)
            {
                goto label_30;
            }
            
            }
            
            if((丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄.Item[val_14.m_stringLength] <= val_14.丒且丁丑下专丘丈业())
            {
                goto label_30;
            }
            
            (丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄.set_Item(key:  val_14.m_stringLength, value:  UnityEngine.Mathf.Max(a:  (丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄.Item[val_14.m_stringLength] - val_14.丌七万丞丅业丑丕丗(), b:  val_14.丒且丁丑下专丘丈业()));
            goto label_30;
            label_19:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_31;
            label_43:
            val_39 = (丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄;
            val_39.set_Item(key:  this.丙世丘丐一丗丏下世, value:  val_8.丒且丁丑下专丘丈业());
            label_31:
            List.Enumerator<T> val_24 = this.丈丅丑丅专丝七丆一.ChanceDatas.GetEnumerator();
            label_60:
            if(((-816151840) & 1) == 0)
            {
                goto label_49;
            }
            
            string val_25 = val_13.丐丏七丌丕丗业且上();
            if(((val_25.m_stringLength == this.丙世丘丐一丗丏下世) || (val_25.下万三上三万东不七() == 0)) || ((丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄.Item[val_25.m_stringLength] >= val_25.专业丑丏上丐万上一()))
            {
                goto label_60;
            }
            
            (丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄.set_Item(key:  val_25.m_stringLength, value:  UnityEngine.Mathf.Min(a:  val_25.下万三上三万东不七() + (丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄.Item[val_25.m_stringLength], b:  val_25.专业丑丏上丐万上一()));
            goto label_60;
            label_49:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_38 = (丁丁丒丁七丂专下丛.丞丆丌万丛不且七丐)[1152921555330346816].丐丟丟丌东业丂万丄;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丝丄丘丛丂万世丞丆(丅丒且丂丁丒丆丈下:  this.不丑丆丌世丁丛与一.丐丂丏丑丄丑丛丂丝(), 与世丗且丟丁不专丏:  this.且丞丂丐不丐不丂丒.不业丙丒丂丞下丆丙(), 丘且丑丒丟丘与丗丒:  val_38);
        }
        private System.Collections.Generic.Dictionary<Rilisoft.丒丙丂丛丙且且不丕, int> 丘丞丌丒丛万丘丈业()
        {
            var val_4;
            System.Collections.Generic.Dictionary<Rilisoft.丒丙丂丛丙且且不丕, System.Int32> val_1 = new System.Collections.Generic.Dictionary<Rilisoft.丒丙丂丛丙且且不丕, System.Int32>();
            List.Enumerator<T> val_2 = this.丄七丗业丐万丁丆丄.GetEnumerator();
            label_9:
            if(((-815854480) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if((val_1.ContainsKey(key:  val_5.DropCategory)) == true)
            {
                goto label_9;
            }
            
            val_1.set_Item(key:  val_5.DropCategory, value:  this.专丆上不且丄上丅丕(七丆丒与丗丌丄且丂:  val_5.DropCategory));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        private int 专丆上不且丄上丅丕(Rilisoft.丒丙丂丛丙且且不丕 七丆丒与丗丌丄且丂)
        {
            var val_12;
            var val_13;
            var val_14;
            val_12 = this;
            .七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
            丙三丏一丈上且丌丒 val_3 = System.Linq.Enumerable.FirstOrDefault<丙三丏一丈上且丌丒>(source:  this.丈丅丑丅专丝七丆一.ChanceDatas, predicate:  new System.Func<丙三丏一丈上且丌丒, System.Boolean>(object:  new 丁丁丒丁七丂专下丛.与丟业一丈上丅上不(), method:  System.Boolean 丁丁丒丁七丂专下丛.与丟业一丈上丅上不::与丆丝丙业丈丕七丅(Rilisoft.GameEventDropChanceData.丙三丏一丈上且丌丒 下丂世丟一上世丆世)));
            Rilisoft.GameEventType val_4 = this.且丞丂丐不丐不丂丒.不业丙丒丂丞下丆丙();
            if((val_4 == 300) || (val_4 == 200))
            {
                goto label_5;
            }
            
            if(val_4 != 100)
            {
                goto label_6;
            }
            
            val_12 = Progress.七七世万专丕丁上业.丘丘丂业丒专丞丞丟();
            val_13 = val_12;
            System.Nullable<System.Int32> val_7 = val_13.上丆丁丕丘丁丞丞丝(丐东业丕丕丂丗丅丙:  this.不丑丆丌世丁丛与一.丐丂丏丑丄丑丛丂丝(), 七丆丒与丗丌丄且丂:  (丁丁丒丁七丂专下丛.与丟业一丈上丅上不)[1152921555330843200].七丆丒与丗丌丄且丂);
            goto label_11;
            label_5:
            val_12 = Progress.七七世万专丕丁上业.丘丘丂业丒专丞丞丟();
            val_13 = val_12;
            System.Nullable<System.Int32> val_10 = val_13.下业三丄丝丄丂一七(丐东业丕丕丂丗丅丙:  this.不丑丆丌世丁丛与一.丐丂丏丑丄丑丛丂丝(), 七丆丒与丗丌丄且丂:  (丁丁丒丁七丂专下丛.与丟业一丈上丅上不)[1152921555330843200].七丆丒与丗丌丄且丂);
            label_11:
            label_6:
            if(((-815659480) & 1) != 0)
            {
                    return (int)val_14;
            }
            
            if(val_3 != null)
            {
                    val_14 = val_3;
                int val_11 = val_14.丒且丁丑下专丘丈业();
                return (int)val_14;
            }
            
            val_14 = 0;
            return (int)val_14;
        }
        private PGCompany.三东丏不丗世丅丌丄 丂一丆丂且三丟丗一()
        {
            int val_5;
            int val_6;
            var val_7;
            Rilisoft.GameEventType val_1 = this.且丞丂丐不丐不丂丒.不业丙丒丂丞下丆丙();
            if((val_1 != 300) && (val_1 != 200))
            {
                    if(val_1 != 100)
            {
                    return 0;
            }
            
                val_5 = this.不丑丆丌世丁丛与一.丐丂丏丑丄丑丛丂丝();
                val_6 = PGCompany.丁七丛丑丄丄丂东世.丐丝东丆三丅丗专丞(丐东业丕丕丂丗丅丙:  val_5);
                val_7 = 23015;
                return PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  255, 丂丕丂丏专丂丄丕且:  val_6 = val_5.RoulettePrice);
            }
            
            val_5 = this.一万丑丅丘丑专与丆;
            val_7 = 22015;
            return PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  255, 丂丕丂丏专丂丄丕且:  val_6);
        }
        private bool 丄丕丝一丞丕丑三一(Rilisoft.GameEventDropChanceData.一七下丝丐丞丁万丌 下丂世丟一上世丆世)
        {
            return (bool)(下丂世丟一上世丆世.丂万业丕万丐东一不() == this.不丑丆丌世丁丛与一.丐丂丏丑丄丑丛丂丝()) ? 1 : 0;
        }
        private bool 丕万丄不丑丆丐一丘(Rilisoft.GameEventDropChanceData.一七下丝丐丞丁万丌 下丂世丟一上世丆世)
        {
            return (bool)(下丂世丟一上世丆世.丂万业丕万丐东一不() == this.不丑丆丌世丁丛与一.丐丂丏丑丄丑丛丂丝()) ? 1 : 0;
        }
        private bool 丞丝丂专丟东丆丏丅(Rilisoft.GameEventItemContainer 丈丛丘丙东专七七且)
        {
            return (bool)(丈丛丘丙东专七七且.DropCategory == this.丙世丘丐一丗丏下世) ? 1 : 0;
        }
    
    }

}
