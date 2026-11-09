using UnityEngine;

namespace PGCompany
{
    internal class 丘丞丞丟丗丐世丅丈
    {
        // Fields
        private static System.Action 丛专万丄三不与丛上;
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<PGCompany.丘丞丞丟丗丐世丅丈> 丝业丆丁业三丈丟东;
        private readonly System.Collections.Generic.Dictionary<string, PlaceableItemProperties> 上丅专万丐上丄专不;
        private readonly System.Collections.Generic.List<PGCompany.一七上丂丞万与一丅.RootBuildingLevelData> 丄下丕七丘丝丒丄上;
        private readonly System.Collections.Generic.List<PGCompany.一七上丂丞万与一丅.RootBuildingLevelData> 业丑世不丅丒丟丗七;
        private PGCompany.一七上丂丞万与一丅.CommonData <丗丏专丟丘丈上上丘>k__BackingField;
        private PGCompany.一七上丂丞万与一丅.丌丆三上丏丁丞丌丙 <丏业丂万上丕丛丘丞>k__BackingField;
        
        // Properties
        internal static PGCompany.丘丞丞丟丗丐世丅丈 丆丕丝丒不丙且丐丗 { get; }
        internal PGCompany.一七上丂丞万与一丅.CommonData 丗东下丟丕与丄丆丝 { get; set; }
        internal PGCompany.一七上丂丞万与一丅.丌丆三上丏丁丞丌丙 丌丆三上丏丁丞丌丙 { get; set; }
        
        // Methods
        internal static void 丑丑不下丗丛上七三(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  PGCompany.丘丞丞丟丗丐世丅丈.丛专万丄三不与丛上, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丑七七丌东不下上丁(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  PGCompany.丘丞丞丟丗丐世丅丈.丛专万丄三不与丛上, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static PGCompany.丘丞丞丟丗丐世丅丈 丑七不且上丗丁一世()
        {
            null = null;
            if(PGCompany.丘丞丞丟丗丐世丅丈.丝业丆丁业三丈丟东 != null)
            {
                    return PGCompany.丘丞丞丟丗丐世丅丈.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return PGCompany.丘丞丞丟丗丐世丅丈.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        internal PGCompany.一七上丂丞万与一丅.CommonData 万丑世丗丐丞下丟丄()
        {
            return (一七上丂丞万与一丅.CommonData)this.<丗丏专丟丘丈上上丘>k__BackingField;
        }
        private void 丌一丛与丞万与丗三(PGCompany.一七上丂丞万与一丅.CommonData 丙业与丙丗丝不丈东)
        {
            this.<丗丏专丟丘丈上上丘>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.一七上丂丞万与一丅.丌丆三上丏丁丞丌丙 丑丗三丛丛丆丟丌丆()
        {
            return (一七上丂丞万与一丅.丌丆三上丏丁丞丌丙)this.<丏业丂万上丕丛丘丞>k__BackingField;
        }
        private void 上丙丄三丈万丌世丐(PGCompany.一七上丂丞万与一丅.丌丆三上丏丁丞丌丙 丙业与丙丗丝不丈东)
        {
            this.<丏业丂万上丕丛丘丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PlaceableItemProperties 东丐丒一且丄下一丒(string 丞一丁业丄一一业且)
        {
            string val_5;
            var val_6;
            val_5 = 丞一丁业丄一一业且;
            if((this.上丅专万丐上丄专不.ContainsKey(key:  val_5)) != false)
            {
                    val_6 = this.上丅专万丐上丄专不.Item[val_5];
                return (PlaceableItemProperties)val_6;
            }
            
            PlaceableItemProperties val_3 = null;
            val_6 = val_3;
            val_3 = new PlaceableItemProperties();
            if(val_6 != null)
            {
                    .ItemId = val_5;
            }
            else
            {
                    mem[16] = val_5;
            }
            
            val_5 = (PlaceableItemProperties)[1152921554030465392].Upgrades;
            val_5.Add(item:  new PlaceableItemProperties.Upgrade());
            return (PlaceableItemProperties)val_6;
        }
        internal System.Collections.Generic.List<PGCompany.一七上丂丞万与一丅.RootBuildingLevelData> 丗丁丗丄丞一丛一万()
        {
            return System.Linq.Enumerable.ToList<RootBuildingLevelData>(source:  this.丄下丕七丘丝丒丄上);
        }
        internal System.Collections.Generic.List<PGCompany.一七上丂丞万与一丅.RootBuildingLevelData> 丈世与不业下世丑业()
        {
            return System.Linq.Enumerable.ToList<RootBuildingLevelData>(source:  this.业丑世不丅丒丟丗七);
        }
        private 丘丞丞丟丗丐世丅丈()
        {
            this.上丅专万丐上丄专不 = new System.Collections.Generic.Dictionary<System.String, PlaceableItemProperties>();
            this.丄下丕七丘丝丒丄上 = new System.Collections.Generic.List<RootBuildingLevelData>();
            this.业丑世不丅丒丟丗七 = new System.Collections.Generic.List<RootBuildingLevelData>();
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.丘丞丞丟丗丐世丅丈::丒丌丙丆丑且丑且丝(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            this.丛不丄与丅丘丙丁与(丞丕丒专一下丙业上:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  70));
        }
        private void 丒丌丙丆丑且丑且丝(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 70)
            {
                    return;
            }
            
            this.丛不丄与丅丘丙丁与(丞丕丒专一下丙业上:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  70));
        }
        private void 丛不丄与丅丘丙丁与(string 丞丕丒专一下丙业上)
        {
            System.Exception val_5;
            var val_11;
            var val_15;
            var val_18;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_25;
            this.上丅专万丐上丄专不.Clear();
            this.丄下丕七丘丝丒丄上.Clear();
            this.业丑世不丅丒丟丗七.Clear();
            this.<丗丏专丟丘丈上上丘>k__BackingField = 0;
            mem[1152921554031191184] = 0;
            DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(0 == 0)
            {
                goto label_12;
            }
            
            List.Enumerator<T> val_3 = 0.GetEnumerator();
            val_20 = 1152921554031126064;
            val_21 = "\'";
            label_21:
            if(((-2115275520) & 1) == 0)
            {
                goto label_13;
            }
            
            if((this.上丅专万丐上丄专不.ContainsKey(key:  val_6.m_stringLength)) == false)
            {
                goto label_16;
            }
            
            UnityEngine.Debug.LogError(message:  "duplicate key: \'"("duplicate key: \'") + val_6.m_stringLength + "\'");
            goto label_21;
            label_16:
            this.上丅专万丐上丄专不.Add(key:  val_6.m_stringLength, value:  val_5.丐丏七丌丕丗业且上());
            goto label_21;
            label_12:
            val_22 = 0;
            goto label_22;
            label_13:
            val_18 = -2115275680;
            val_23 = 0;
            val_22 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(( == 1) || ( != 179))
            {
                goto label_34;
            }
            
            label_22:
            val_23 = 0;
            if(val_1 != null)
            {
                goto label_38;
            }
            
            goto label_36;
            label_34:
            if( != 0)
            {
                    val_22 = 0;
            }
            
            if(val_1 != null)
            {
                goto label_38;
            }
            
            label_36:
            label_38:
            if(0 == 0)
            {
                goto label_53;
            }
            
            List.Enumerator<T> val_9 = 0.GetEnumerator();
            val_21 = 1152921554031147680;
            val_20 = 1152921554031148704;
            label_42:
            if(((-2115275552) & 1) == 0)
            {
                goto label_40;
            }
            
            this.丄下丕七丘丝丒丄上.Add(item:  val_11.丐丏七丌丕丗业且上());
            goto label_42;
            label_40:
            val_23 = 0 + 1;
            mem2[0] = 248;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_23 == 1) || ((val_18 + ((0 + 1)) << 2) != 248))
            {
                goto label_50;
            }
            
            var val_18 = 0;
            val_18 = val_18 ^ (val_23 >> 31);
            val_23 = val_23 + val_18;
            if(val_1 != null)
            {
                goto label_54;
            }
            
            goto label_52;
            label_50:
            if( != 0)
            {
                    val_22 = 0;
            }
            
            label_53:
            if(val_1 != null)
            {
                goto label_54;
            }
            
            label_52:
            label_54:
            if(0 == 0)
            {
                goto label_69;
            }
            
            List.Enumerator<T> val_13 = 0.GetEnumerator();
            val_21 = 1152921554031147680;
            val_20 = 1152921554031148704;
            label_58:
            if(((-2115275552) & 1) == 0)
            {
                goto label_56;
            }
            
            this.业丑世不丅丒丟丗七.Add(item:  val_15.丐丏七丌丕丗业且上());
            goto label_58;
            label_56:
            val_23 = val_23 + 1;
            mem2[0] = 317;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_23 == 1)
            {
                goto label_65;
            }
            
            if( == 0)
            {
                goto label_69;
            }
            
            if((val_18 + (((0 + 1) + 1)) << 2) != 317)
            {
                goto label_67;
            }
            
            goto label_69;
            label_65:
            if( == 0)
            {
                goto label_69;
            }
            
            label_67:
            label_69:
            if(val_1 != null)
            {
                    mem2[0] = 1152921554031157920;
            }
            else
            {
                    mem2[0] = 135970152;
            }
            
            this.<丏业丂万上丕丛丘丞>k__BackingField = 135970152;
            val_25 = null;
            val_25 = null;
            if(PGCompany.丘丞丞丟丗丐世丅丈.丛专万丄三不与丛上 == null)
            {
                    return;
            }
            
            PGCompany.丘丞丞丟丗丐世丅丈.丛专万丄三不与丛上.Invoke();
        }
        private static 丘丞丞丟丗丐世丅丈()
        {
            null = null;
            PGCompany.丘丞丞丟丗丐世丅丈.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<PGCompany.丘丞丞丟丗丐世丅丈>(丙丂丌且丌世丒丐三:  new System.Func<PGCompany.丘丞丞丟丗丐世丅丈>(object:  丘丞丞丟丗丐世丅丈.<>c.<>9, method:  PGCompany.丘丞丞丟丗丐世丅丈 丘丞丞丟丗丐世丅丈.<>c::三丂丗丏上丄丏丗丟()));
        }
    
    }

}
