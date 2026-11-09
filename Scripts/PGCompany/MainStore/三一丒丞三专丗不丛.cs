using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 三一丒丞三专丗不丛
    {
        // Fields
        private static System.Action<PGCompany.专丟专世丅丂丁且专> 丏丕丐丌专世上七丈;
        private const string 丒丌七下丙丙丈丑丈 = "NOT_NEW_PROMOTIONS";
        private readonly Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>>> 东与业万七丄不丂与;
        private static PGCompany.MainStore.三一丒丞三专丗不丛 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.MainStore.三一丒丞三专丗不丛 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static void 丂丙丌七下丛丌丞丅(System.Action<PGCompany.专丟专世丅丂丁且专> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.MainStore.三一丒丞三专丗不丛.丒丌七下丙丙丈丑丈, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 上丅丘丕丆丞丟丅丑(System.Action<PGCompany.专丟专世丅丂丁且专> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.MainStore.三一丒丞三专丗不丛.丒丌七下丙丙丈丑丈, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static PGCompany.MainStore.三一丒丞三专丗不丛 丑七不且上丗丁一世()
        {
            PGCompany.MainStore.三一丒丞三专丗不丛 val_2;
            PGCompany.MainStore.三一丒丞三专丗不丛 val_3 = PGCompany.MainStore.三一丒丞三专丗不丛.丝业丆丁业三丈丟东;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PGCompany.MainStore.三一丒丞三专丗不丛 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.MainStore.三一丒丞三专丗不丛();
            PGCompany.MainStore.三一丒丞三专丗不丛.丝业丆丁业三丈丟东 = val_2;
            val_3 = PGCompany.MainStore.三一丒丞三专丗不丛.丝业丆丁业三丈丟东;
            return val_3;
        }
        internal 三一丒丞三专丗不丛()
        {
            Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>>> val_4 = new Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>>>(丟东丟丑丕丄丂丟丙:  "NOT_NEW_PROMOTIONS." + FriendsController.不丝丕丒丂丆丘丙丙(), 东三丁丙丗万业七丟:  new PGCompany.MainStore.丛七丒丝世且一丅丏());
            this.东与业万七丄不丂与 = val_4;
            if(val_4 != null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>>();
            if(this.东与业万七丄不丂与 == null)
            {
                
            }
        
        }
        internal bool 专与丁丝丒丟丐业世(string 丙丐万丗丁丏丞专丄, PGCompany.专丟专世丅丂丁且专 专丟专世丅丂丁且专)
        {
            var val_7;
            var val_9;
            val_7 = this;
            if((System.String.IsNullOrEmpty(value:  丙丐万丗丁丏丞专丄)) != true)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                if(专丟专世丅丂丁且专.丑丕丈丈不不且丑且() != false)
            {
                    if((this.东与业万七丄不丂与.ContainsKey(key:  丙丐万丗丁丏丞专丄)) == false)
            {
                    return (bool)val_9 & 1;
            }
            
                val_7 = this.东与业万七丄不丂与;
                val_9 = (val_7.Item[丙丐万丗丁丏丞专丄].Contains(item:  专丟专世丅丂丁且专)) ^ 1;
                return (bool)val_9 & 1;
            }
            
            }
            
            val_9 = 0;
            return (bool)val_9 & 1;
        }
        internal void 专丟东业丅与七与且(string 丙丐万丗丁丏丞专丄, System.Collections.Generic.List<PGCompany.MainStore.下丐丒丙丂丁丗丘丘> 丈不丅丝丂丝丟丁丞)
        {
            var val_6;
            var val_15;
            if((System.String.IsNullOrEmpty(value:  丙丐万丗丁丏丞专丄)) == true)
            {
                    return;
            }
            
            val_15 = this.东与业万七丄不丂与;
            if((val_15.ContainsKey(key:  丙丐万丗丁丏丞专丄)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专> val_3 = null;
            val_15 = val_3;
            val_3 = new System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>();
            List.Enumerator<T> val_4 = 丈不丅丝丂丝丟丁丞.GetEnumerator();
            label_9:
            if(((-614314288) & 1) == 0)
            {
                goto label_6;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if(val_7 == null)
            {
                goto label_9;
            }
            
            val_3.Add(item:  val_7.七丈丒丒下下且万与());
            goto label_9;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专> val_9 = new System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>();
            List.Enumerator<T> val_11 = this.东与业万七丄不丂与.Item[丙丐万丗丁丏丞专丄].GetEnumerator();
            label_22:
            if(((-614314312) & 1) == 0)
            {
                goto label_18;
            }
            
            string val_12 = 0.丐丏七丌丕丗业且上();
            if((val_3.Contains(item:  val_12)) == true)
            {
                goto label_22;
            }
            
            val_9.Add(item:  val_12);
            goto label_22;
            label_18:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丄上丗丌丄丟丑丙七(丙丐万丗丁丏丞专丄:  丙丐万丗丁丏丞专丄, 丁与丅下丝世三专丈:  val_9);
        }
        internal void 丈丕丅下一丆丏丞下(string 丙丐万丗丁丏丞专丄, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专> 丈东丒丌与丟东丑丒)
        {
            Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>>> val_4;
            var val_5;
            val_4 = this;
            List.Enumerator<T> val_1 = 丈东丒丌与丟东丑丒.GetEnumerator();
            val_5 = 0;
            goto label_2;
            label_3:
            val_5 = val_5 | (this.东七丙三丌丘一不丙(丙丐万丗丁丏丞专丄:  丙丐万丗丁丏丞专丄, 一丗与一专丙丙丅丄:  0.丐丏七丌丕丗业且上(), 丅丁三世丝三丞专世:  false));
            label_2:
            if(((-614143880) & 1) != 0)
            {
                goto label_3;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_5 != true)
            {
                    return;
            }
            
            val_4 = this.东与业万七丄不丂与;
            val_4.丂且不业丂专丛丆东();
        }
        internal bool 东七丙三丌丘一不丙(string 丙丐万丗丁丏丞专丄, PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄, bool 丅丁三世丝三丞专世 = True)
        {
            var val_8;
            string val_10;
            if((System.String.IsNullOrEmpty(value:  丙丐万丗丁丏丞专丄)) == true)
            {
                    return false;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(一丗与一专丙丙丅丄.丑丕丈丈不不且丑且() == false)
            {
                    return false;
            }
            
            val_10 = 丙丐万丗丁丏丞专丄;
            if((this.东与业万七丄不丂与.ContainsKey(key:  val_10)) != true)
            {
                    val_10 = 丙丐万丗丁丏丞专丄;
                this.东与业万七丄不丂与.set_Item(key:  val_10, value:  new System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>());
            }
            
            val_8 = this.东与业万七丄不丂与.Item[丙丐万丗丁丏丞专丄];
            if((val_8.Contains(item:  一丗与一专丙丙丅丄)) != false)
            {
                    return false;
            }
            
            this.东与业万七丄不丂与.Item[丙丐万丗丁丏丞专丄].Add(item:  一丗与一专丙丙丅丄);
            if(PGCompany.MainStore.三一丒丞三专丗不丛.丒丌七下丙丙丈丑丈 != null)
            {
                    PGCompany.MainStore.三一丒丞三专丗不丛.丒丌七下丙丙丈丑丈.Invoke(obj:  一丗与一专丙丙丅丄);
            }
            
            if(丅丁三世丝三丞专世 == false)
            {
                    return false;
            }
            
            this.东与业万七丄不丂与.丂且不业丂专丛丆东();
            return false;
        }
        internal void 丄上丗丌丄丟丑丙七(string 丙丐万丗丁丏丞专丄, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专> 丁与丅下丝世三专丈)
        {
            Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>>> val_4;
            var val_5;
            val_4 = this;
            List.Enumerator<T> val_1 = 丁与丅下丝世三专丈.GetEnumerator();
            val_5 = 0;
            goto label_2;
            label_3:
            val_5 = val_5 | (this.丄上丗丌丄丟丑丙七(丙丐万丗丁丏丞专丄:  丙丐万丗丁丏丞专丄, 丁与丅下丝世三专丈:  0.丐丏七丌丕丗业且上(), 丅丁三世丝三丞专世:  false));
            label_2:
            if(((-613804136) & 1) != 0)
            {
                goto label_3;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_5 != true)
            {
                    return;
            }
            
            val_4 = this.东与业万七丄不丂与;
            val_4.丂且不业丂专丛丆东();
        }
        internal bool 丄上丗丌丄丟丑丙七(string 丙丐万丗丁丏丞专丄, PGCompany.专丟专世丅丂丁且专 丁与丅下丝世三专丈, bool 丅丁三世丝三丞专世 = True)
        {
            var val_11;
            Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专>>> val_12;
            var val_14;
            val_12 = 丅丁三世丝三丞专世;
            if((System.String.IsNullOrEmpty(value:  丙丐万丗丁丏丞专丄)) != true)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                if(丁与丅下丝世三专丈.丑丕丈丈不不且丑且() != false)
            {
                    val_11 = this.东与业万七丄不丂与;
                if((val_11.ContainsKey(key:  丙丐万丗丁丏丞专丄)) != false)
            {
                    val_11 = this.东与业万七丄不丂与.Item[丙丐万丗丁丏丞专丄];
                if((val_11.Contains(item:  丁与丅下丝世三专丈)) != false)
            {
                    val_11 = this.东与业万七丄不丂与.Item[丙丐万丗丁丏丞专丄];
                bool val_8 = val_11.Remove(item:  丁与丅下丝世三专丈);
                if(this.东与业万七丄不丂与.Item[丙丐万丗丁丏丞专丄].Count == 0)
            {
                    bool val_11 = this.东与业万七丄不丂与.Remove(key:  丙丐万丗丁丏丞专丄);
            }
            
                if(val_12 != false)
            {
                    val_12 = this.东与业万七丄不丂与;
                val_12.丂且不业丂专丛丆东();
            }
            
                val_14 = 1;
                return (bool)val_14;
            }
            
            }
            
            }
            
            }
            
            val_14 = 0;
            return (bool)val_14;
        }
    
    }

}
