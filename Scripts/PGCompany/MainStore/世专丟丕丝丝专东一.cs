using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 世专丟丕丝丝专东一 : IDisposable
    {
        // Fields
        private readonly PGCompany.DataObjects.丙七丘三丛丕丙丒丒 上世丏丁世丟世丆业;
        private readonly System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> 丌且与丈丞丛下丆万;
        private int <一丐丐丏东万不上丂>k__BackingField;
        private TagSystem.三与下丘七丘丌丏丄 世下丆丒万丆丛丛丄;
        
        // Properties
        internal string 专丕与丒丗丁丘专丟 { get; }
        internal string 不专与丂丂下丅丞丞 { get; }
        internal string 丘丏丐丞丈专三且世 { get; }
        internal System.Collections.Generic.IReadOnlyList<string> 丅丗丄下丞七丗丒上 { get; }
        internal int 不丒丐丁丗世七下丏 { get; set; }
        internal int 七三不业三丕丈丅丈 { get; }
        internal TagSystem.三与下丘七丘丌丏丄 一丟丘万世一下不下 { get; }
        
        // Methods
        internal string 东丙上东业丆不丟丘()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.上世丏丁世丟世丆业.TitleLocKey);
        }
        internal string 丙业丆丘万丙专万丟()
        {
            if(this.上世丏丁世丟世丆业 != null)
            {
                    return (string)this.上世丏丁世丟世丆业.Section;
            }
            
            return (string)this.上世丏丁世丟世丆业.Section;
        }
        internal string 丅上万丛一丐上上丕()
        {
            if(this.上世丏丁世丟世丆业 != null)
            {
                    return (string)this.上世丏丁世丟世丆业.Season;
            }
            
            return (string)this.上世丏丁世丟世丆业.Season;
        }
        internal System.Collections.Generic.IReadOnlyList<string> 七且与三三世且丈一()
        {
            System.Collections.Generic.List<System.String> val_2;
            if(this.上世丏丁世丟世丆业 == null)
            {
                    return (System.Collections.Generic.IReadOnlyList<System.String>)System.Array.Empty<System.String>();
            }
            
            val_2 = this.上世丏丁世丟世丆业.Shops;
            if(val_2 != null)
            {
                    return (System.Collections.Generic.IReadOnlyList<System.String>)System.Array.Empty<System.String>();
            }
            
            return (System.Collections.Generic.IReadOnlyList<System.String>)System.Array.Empty<System.String>();
        }
        internal int 丒不丈业下且与丟丈()
        {
            return (int)this.<一丐丐丏东万不上丂>k__BackingField;
        }
        private void 丙一丝下万丅丏七不(int 丙业与丙丗丝不丈东)
        {
            this.<一丐丐丏东万不上丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 丟丈丅丙一万三丅丒()
        {
            var val_2;
            if((this.<一丐丐丏东万不上丂>k__BackingField) >= 1)
            {
                    val_2 = (this.<一丐丐丏东万不上丂>k__BackingField) - PixelTime.丙丅丅业丟丁世丁丗();
                return (int)val_2;
            }
            
            val_2 = 0;
            return (int)val_2;
        }
        internal TagSystem.三与下丘七丘丌丏丄 与不丞丑七丘丁丂丛()
        {
            TagSystem.三与下丘七丘丌丏丄 val_2 = this.世下丆丒万丆丛丛丄;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            val_2 = this.上世丏丁世丟世丆业.Tag;
            if(val_2 == null)
            {
                    TagSystem.三与下丘七丘丌丏丄 val_1 = null;
                val_2 = val_1;
                val_1 = new TagSystem.三与下丘七丘丌丏丄();
            }
            
            this.世下丆丒万丆丛丛丄 = val_2;
            return val_2;
        }
        internal 世专丟丕丝丝专东一(PGCompany.DataObjects.丙七丘三丛丕丙丒丒 上世丏丁世丟世丆业, System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> 不丅上丏丐一丟丆丞)
        {
            var val_6;
            System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_15;
            var val_16;
            val_1 = new System.Object();
            this.上世丏丁世丟世丆业 = 上世丏丁世丟世丆业;
            System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_2 = null;
            val_15 = val_2;
            val_2 = new System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>();
            this.丌且与丈丞丛下丆万 = val_15;
            if((System.Linq.Enumerable.Any<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_1 = 不丅上丏丐一丟丆丞)) == false)
            {
                goto label_23;
            }
            
            List.Enumerator<T> val_4 = val_1.GetEnumerator();
            val_16 = 0;
            goto label_9;
            label_11:
            val_15 = val_6.丐丏七丌丕丗业且上();
            this.丌且与丈丞丛下丆万.Add(item:  val_15);
            if((this.<一丐丐丏东万不上丂>k__BackingField) >= 1)
            {
                    if(val_15.下丒丗丄丌丘不丑丘() >= (this.<一丐丐丏东万不上丂>k__BackingField))
            {
                goto label_9;
            }
            
            }
            
            if(val_15.下丒丗丄丌丘不丑丘() >= 1)
            {
                    val_16 = val_15;
                this.<一丐丐丏东万不上丂>k__BackingField = val_15.下丒丗丄丌丘不丑丘();
            }
            
            label_9:
            if(((-599986032) & 1) != 0)
            {
                goto label_11;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_16 == null)
            {
                
            }
            else
            {
                    if(val_16.丅世丄丆不丆且丐七() != null)
            {
                    PGCompany.DataObjects.专丅一丄上丗且丑一 val_12 = val_16.丅世丄丆不丆且丐七();
                if(val_12.丑丂丕上丏上业丐且 != true)
            {
                    this.<一丐丐丏东万不上丂>k__BackingField = 0;
            }
            
            }
            
            }
            
            label_23:
            this.丑三丏丞丐丐与丞丘();
            this.丘丗上上丅世丅东丟();
            Rilisoft.丗下丙丅且丐丞丙世.世丗东丈业上万且丒(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void PGCompany.MainStore.世专丟丕丝丝专东一::一丑丕三业业不丙业(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
        }
        private void 一丑丕三业业不丙业(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)
        {
            if(丕上业丕丘上丘七一 != 40)
            {
                    return;
            }
            
            this.丑三丏丞丐丐与丞丘();
        }
        private void 丑三丏丞丐丐与丞丘()
        {
            if((System.String.op_Equality(a:  this.上世丏丁世丟世丆业.Section, b:  "event")) == false)
            {
                    return;
            }
            
            if((Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏(丗与丟上上丑专世丗:  40)) == null)
            {
                    return;
            }
        
        }
        internal void 丆丕丅丘丅丝丘东丈()
        {
            this.丘丗上上丅世丅东丟();
        }
        private void 丘丗上上丅世丅东丟()
        {
            var val_8;
            if(this.丌且与丈丞丛下丆万 == null)
            {
                    return;
            }
            
            this.与不丞丑七丘丁丂丛().Remove(丆万一不丌且东丐丐:  "X10");
            this.与不丞丑七丘丁丂丛().Remove(丆万一不丌且东丐丐:  "X3");
            this.与不丞丑七丘丁丂丛().Remove(丆万一不丌且东丐丐:  "new");
            this.与不丞丑七丘丁丂丛().Remove(丆万一不丌且东丐丐:  "free");
            this.与不丞丑七丘丁丂丛().Remove(丆万一不丌且东丐丐:  "multiplier");
            List.Enumerator<T> val_6 = this.丌且与丈丞丛下丆万.GetEnumerator();
            label_42:
            if(((-599353728) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_9 = val_8.丐丏七丌丕丗业且上();
            if(val_9.与不丞丑七丘丁丂丛() == null)
            {
                goto label_42;
            }
            
            if((val_9.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "multiplier")) != false)
            {
                    if((this.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "multiplier")) != true)
            {
                    bool val_16 = this.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "multiplier");
            }
            
            }
            
            if((val_9.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "X10")) != false)
            {
                    bool val_20 = this.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "X10");
                if((this.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "X3")) != false)
            {
                    this.与不丞丑七丘丁丂丛().Remove(丆万一不丌且东丐丐:  "X3");
            }
            
            }
            
            if((val_9.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "X3")) != false)
            {
                    if((this.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "X10")) != true)
            {
                    bool val_29 = this.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "X3");
            }
            
            }
            
            if((val_9.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "new")) != false)
            {
                    if((this.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "new")) != true)
            {
                    bool val_35 = this.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "new");
            }
            
            }
            
            if(((val_9.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "free")) == false) || ((this.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "free")) == true))
            {
                goto label_42;
            }
            
            bool val_41 = this.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "free");
            goto label_42;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal bool 丈且丈且上丟不丝万()
        {
            bool val_1 = PGCompany.丞丒专七世下丅万丂.丁三专上上业丝丘丁<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(丈丆丕与丒丌丘丕且:  this.丌且与丈丞丛下丆万);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        internal bool 丕万丛丂丈丑万专丆(PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
            var val_5;
            PGCompany.专丟专世丅丂丁且专 val_6 = 一丗与一专丙丙丅丄;
            if(val_6 == null)
            {
                    return (bool);
            }
            
            List.Enumerator<T> val_1 = this.丌且与丈丞丛下丆万.GetEnumerator();
            val_5 = 1152921537159756944;
            label_9:
            if(((-599001672) & 1) == 0)
            {
                goto label_3;
            }
            
            PGCompany.专丟专世丅丂丁且专 val_3 = 0.丐丏七丌丕丗业且上().七丈丒丒下下且万与();
            var val_6 = 0;
            val_6 = val_6 + 1;
            if((val_6.Equals(other:  null)) == false)
            {
                goto label_9;
            }
            
            val_6 = 1;
            goto label_10;
            label_3:
            val_6 = 0;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool);
        }
        internal bool 丗不丞一且丟丈丈丗(ref System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> 专丂丕丗丗东世丞下, TagSystem.三与下丘七丘丌丏丄 三不丟丈丐丟丏专丁, TagSystem.下万上丅丗丂丄七上 丁丏且丝丞丙万丗与 = 3)
        {
            var val_5;
            System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_13;
            TagSystem.下万上丅丗丂丄七上 val_14;
            System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_15;
            var val_16;
            val_14 = 丁丏且丝丞丙万丗与;
            val_15 = this.丌且与丈丞丛下丆万;
            if(val_15 == null)
            {
                    return (bool)val_15;
            }
            
            if(((System.Linq.Enumerable.Any<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  val_15)) == false) || (专丂丕丗丗东世丞下 == null))
            {
                goto label_3;
            }
            
            if(三不丟丈丐丟丏专丁 != null)
            {
                    if(三不丟丈丐丟丏专丁.不丈丅万不下丙丄丅() == true)
            {
                goto label_13;
            }
            
            }
            
            val_13 = this.丌且与丈丞丛下丆万;
            List.Enumerator<T> val_3 = val_13.GetEnumerator();
            val_16 = 1152921537159756944;
            label_9:
            if(((-598832416) & 1) == 0)
            {
                goto label_15;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_5.丐丏七丌丕丗业且上());
            goto label_9;
            label_3:
            val_15 = 0;
            return (bool)val_15;
            label_13:
            List.Enumerator<T> val_7 = this.丌且与丈丞丛下丆万.GetEnumerator();
            val_16 = 1152921537159757968;
            label_21:
            if(((-598832416) & 1) == 0)
            {
                goto label_15;
            }
            
            string val_8 = val_5.丐丏七丌丕丗业且上();
            if(((val_8 == null) || (val_8.与不丞丑七丘丁丂丛() == null)) || ((val_8.与不丞丑七丘丁丂丛().丂丆世世丕丅丕丅上(丘丛丏丘丝七世七丅:  三不丟丈丐丟丏专丁, 丟且丒专下丈七丗丕:  val_14)) == false))
            {
                goto label_21;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_8);
            goto label_21;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_15 = 1;
            return (bool)val_15;
        }
        internal bool 丗不丞一且丟丈丈丗(ref System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> 专丂丕丗丗东世丞下, System.Collections.Generic.IReadOnlyList<PGCompany.三东丏不丗世丅丌丄> 业世东丛专丑世丂不, PGCompany.七丁丌丝丁丙丝世丁 丟且丒专下丈七丗丕)
        {
            var val_5;
            System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_11;
            PGCompany.七丁丌丝丁丙丝世丁 val_12;
            System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> val_13;
            var val_14;
            val_12 = 丟且丒专下丈七丗丕;
            val_13 = this.丌且与丈丞丛下丆万;
            if(val_13 == null)
            {
                    return (bool)val_13;
            }
            
            if(((System.Linq.Enumerable.Any<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  val_13)) == false) || (专丂丕丗丗东世丞下 == null))
            {
                goto label_3;
            }
            
            if(业世东丛专丑世丂不 != null)
            {
                    if((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  业世东丛专丑世丂不)) == true)
            {
                goto label_13;
            }
            
            }
            
            val_11 = this.丌且与丈丞丛下丆万;
            List.Enumerator<T> val_3 = val_11.GetEnumerator();
            val_14 = 1152921537159756944;
            label_9:
            if(((-598646816) & 1) == 0)
            {
                goto label_15;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_5.丐丏七丌丕丗业且上());
            goto label_9;
            label_3:
            val_13 = 0;
            return (bool)val_13;
            label_13:
            List.Enumerator<T> val_7 = this.丌且与丈丞丛下丆万.GetEnumerator();
            val_14 = 1152921537159757968;
            label_20:
            if(((-598646816) & 1) == 0)
            {
                goto label_15;
            }
            
            string val_8 = val_5.丐丏七丌丕丗业且上();
            if(((val_8 == null) || (val_8 == null)) || ((PGCompany.上丘丆丁一丞上且且.丂丆世世丕丅丕丅上(与丒丟丟丝丗七三上:  val_8, 世专丐丄不丘丅与一:  业世东丛专丑世丂不, 丟且丒专下丈七丗丕:  val_12)) == false))
            {
                goto label_20;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_8);
            goto label_20;
            label_15:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_13 = 1;
            return (bool)val_13;
        }
        internal int 丅丄丕丞一七东丙与(TagSystem.三与下丘七丘丌丏丄 三不丟丈丐丟丏专丁, TagSystem.下万上丅丗丂丄七上 丁丏且丝丞丙万丗与)
        {
            var val_7;
            if((三不丟丈丐丟丏专丁 == null) || (三不丟丈丐丟丏专丁.不丈丅万不下丙丄丅() == false))
            {
                goto label_2;
            }
            
            List.Enumerator<T> val_2 = this.丌且与丈丞丛下丆万.GetEnumerator();
            val_7 = 0;
            goto label_6;
            label_7:
            TagSystem.三与下丘七丘丌丏丄 val_4 = 0.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛();
            if(val_4 != null)
            {
                    val_7 = val_7 + (val_4.丂丆世世丕丅丕丅上(丘丛丏丘丝七世七丅:  三不丟丈丐丟丏专丁, 丟且丒专下丈七丗丕:  丁丏且丝丞丙万丗与));
            }
            
            label_6:
            if(((-598481592) & 1) != 0)
            {
                goto label_7;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (int)val_7;
            label_2:
            val_7 = 0;
            return (int)val_7;
        }
        internal int 丄丟七丆丕东丞丆上()
        {
            var val_6;
            List.Enumerator<T> val_1 = this.丌且与丈丞丛下丆万.GetEnumerator();
            val_6 = 0;
            goto label_2;
            label_5:
            val_6 = val_6 + (0.丐丏七丌丕丗业且上().与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "new"));
            label_2:
            if(((-598336824) & 1) != 0)
            {
                goto label_5;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (int)val_6;
        }
        public void Dispose()
        {
            Rilisoft.丗下丙丅且丐丞丙世.世丟丆丞不东丅丝三(丙业与丙丗丝不丈东:  new System.Action<OfferModule>(object:  this, method:  System.Void PGCompany.MainStore.世专丟丕丝丝专东一::一丑丕三业业不丙业(Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丕上业丕丘上丘七一)));
        }
    
    }

}
