using UnityEngine;

namespace Rilisoft
{
    public class InAppBonusLobbyButtonCollectionManager : MonoBehaviour
    {
        // Fields
        private Rilisoft.InAppBonusLobbyButtonView 专丑丘丟一世七下丟;
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丁丘丄丕下专东七不;
        private System.Collections.Generic.Dictionary<string, object> 丟专丙丝与业与丂丐;
        private float 丛丄下业世丄丒丌东;
        public float ChangeDelay;
        private float 丒业上丘一上专丈上;
        
        // Properties
        private Rilisoft.InAppBonusLobbyButtonView 东一万丂丗丑丟万丌 { get; }
        
        // Methods
        private Rilisoft.InAppBonusLobbyButtonView 丝丘一上丙丕丕三上()
        {
            Rilisoft.InAppBonusLobbyButtonView val_3;
            if(this.专丑丘丟一世七下丟 == 0)
            {
                    this.专丑丘丟一世七下丟 = this.GetComponent<Rilisoft.InAppBonusLobbyButtonView>();
                return val_3;
            }
            
            val_3 = this.专丑丘丟一世七下丟;
            return val_3;
        }
        internal Rilisoft.业丙丘丆东丈丕丂丄.OfferModule 丅丁一丙丆丁一丛丗()
        {
            var val_4;
            OfferModule val_5;
            val_4 = this;
            if(this.专丑丘丟一世七下丟 == 0)
            {
                    val_5 = 0;
                return val_5;
            }
            
            if(this.专丑丘丟一世七下丟.Data == null)
            {
                    return val_5;
            }
            
            val_4 = this.专丑丘丟一世七下丟.Data;
            val_5 = val_3.OfferModule;
            return val_5;
        }
        public void SetData(System.Collections.Generic.IEnumerable<System.Collections.Generic.Dictionary<string, object>> 一丐丗丁丞丆丅丟丄)
        {
            System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  一丐丗丁丞丆丅丟丄);
            this.丁丘丄丕下专东七不 = val_1;
            if(this.丁丘丄丕下专东七不 != null)
            {
                    if((val_1.与业丈一丂丂世丗丌(丏丆丑丗七丄丙丝与:  val_1, 丒丈丙丐丏丕丆万丗:  this.丁丘丄丕下专东七不)) == true)
            {
                    return;
            }
            
            }
            
            this.丒业上丘一上专丈上 = -1.175494E-38f;
        }
        private void Update()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_11;
            var val_12;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_13;
            float val_14;
            if(((this.丒业上丘一上专丈上 < this.ChangeDelay) || (this.丁丘丄丕下专东七不 == null)) || (this.丁丘丄丕下专东七不.Count < 1))
            {
                goto label_14;
            }
            
            val_11 = this.丟专丙丝与业与丂丐;
            if(val_11 == null)
            {
                goto label_9;
            }
            
            val_12 = public System.Int32 System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>>::IndexOf(System.Collections.Generic.Dictionary<System.String, System.Object> item);
            int val_2 = this.丁丘丄丕下专东七不.IndexOf(item:  val_11);
            if((val_2 & 2147483648) != 0)
            {
                goto label_8;
            }
            
            val_13 = this.丁丘丄丕下专东七不;
            val_11 = val_2 + 1;
            if(val_11 >= val_13.Count)
            {
                goto label_8;
            }
            
            if((val_11 & 2147483648) == 0)
            {
                goto label_9;
            }
            
            goto label_14;
            label_8:
            val_11 = 0;
            label_9:
            val_13 = this.丁丘丄丕下专东七不;
            this.丒业上丘一上专丈上 = 0f;
            this.丛丄下业世丄丒丌东 = 0f;
            this.丟专丙丝与业与丂丐 = val_13.Item[0];
            val_12 = 0;
            if(this.丝丘一上丙丕丕三上() != 0)
            {
                    val_13 = this.丝丘一上丙丕丕三上();
                val_12 = 0;
                val_13.SetData(丛丝丙丄七一丁丅三:  this.丟专丙丝与业与丂丐);
            }
            
            label_14:
            float val_8 = UnityEngine.Time.deltaTime;
            val_14 = this.丛丄下业世丄丒丌东;
            val_8 = this.丒业上丘一上专丈上 + val_8;
            this.丒业上丘一上专丈上 = val_8;
            if(val_14 > 0.3f)
            {
                    this.丛丄下业世丄丒丌东 = 0f;
                Rilisoft.InAppBonusLobbyButtonView val_9 = this.丝丘一上丙丕丕三上();
                val_14 = this.丛丄下业世丄丒丌东;
            }
            
            float val_10 = UnityEngine.Time.deltaTime;
            val_10 = val_14 + val_10;
            this.丛丄下业世丄丒丌东 = val_10;
        }
        public void ShowNext()
        {
            this.丒业上丘一上专丈上 = -1.175494E-38f;
        }
        private bool 与业丈一丂丂世丗丌(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丏丆丑丗七丄丙丝与, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 丒丈丙丐丏丕丆万丗)
        {
            var val_14;
            System.Collections.Generic.IEnumerable<TSource> val_15;
            var val_16;
            System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Object> val_18;
            var val_19;
            System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Object> val_21;
            var val_22;
            val_15 = 丒丈丙丐丏丕丆万丗;
            if(丏丆丑丗七丄丙丝与 == null)
            {
                goto label_1;
            }
            
            if(val_15 == null)
            {
                goto label_22;
            }
            
            val_14 = 丏丆丑丗七丄丙丝与.Count;
            if(val_14 != val_15.Count)
            {
                goto label_22;
            }
            
            val_16 = null;
            val_16 = null;
            val_18 = InAppBonusLobbyButtonCollectionManager.<>c.<>9__12_0;
            if(val_18 == null)
            {
                    System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Object> val_3 = null;
                val_18 = val_3;
                val_3 = new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Object>(object:  InAppBonusLobbyButtonCollectionManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Object InAppBonusLobbyButtonCollectionManager.<>c::不丐丏业专丙丅世丏(System.Collections.Generic.Dictionary<string, object> 丐丆丂丒丁万丈丛丅));
                InAppBonusLobbyButtonCollectionManager.<>c.<>9__12_0 = val_18;
            }
            
            System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Object>(source:  丏丆丑丗七丄丙丝与, selector:  val_3));
            val_19 = null;
            val_19 = null;
            val_21 = InAppBonusLobbyButtonCollectionManager.<>c.<>9__12_1;
            if(val_21 == null)
            {
                    System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Object> val_6 = null;
                val_21 = val_6;
                val_6 = new System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Object>(object:  InAppBonusLobbyButtonCollectionManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Object InAppBonusLobbyButtonCollectionManager.<>c::与且七丁丏一丄专万(System.Collections.Generic.Dictionary<string, object> 丐丆丂丒丁万丈丛丅));
                InAppBonusLobbyButtonCollectionManager.<>c.<>9__12_1 = val_21;
            }
            
            val_15 = System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.Dictionary<System.String, System.Object>, System.Object>(source:  val_15, selector:  val_6));
            val_14 = 0;
            label_21:
            if(val_14 >= val_5.Count)
            {
                goto label_23;
            }
            
            if((val_15.Contains(item:  val_5.Item[0])) == false)
            {
                goto label_22;
            }
            
            val_14 = val_14 + 1;
            if((val_5.Contains(item:  val_15.Item[0])) == true)
            {
                goto label_21;
            }
            
            goto label_22;
            label_1:
            if(val_15 == null)
            {
                goto label_23;
            }
            
            label_22:
            val_22 = 0;
            return (bool)val_22;
            label_23:
            val_22 = 1;
            return (bool)val_22;
        }
        private void 丙丕三万且与万上丌()
        {
            Rilisoft.InAppBonusLobbyButtonView val_7 = this.丝丘一上丙丕丕三上();
            if(val_7 == 0)
            {
                    return;
            }
            
            if(val_1.BadgeObject == 0)
            {
                    return;
            }
            
            int val_4 = this.丆下万专丐丈丌不丗();
            if(val_4 >= 1)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1.BadgeObject, 丏业丟一东丂东丘丛:  true);
                if(val_1.BadgeLabel == 0)
            {
                    return;
            }
            
                val_7 = val_1.BadgeLabel;
                val_7.text = val_4.ToString();
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1.BadgeObject, 丏业丟一东丂东丘丛:  false);
        }
        private int 丆下万专丐丈丌不丗()
        {
            bool val_2 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏();
            if(val_2 == false)
            {
                    return val_2.丙丂丝丘丛世东上业();
            }
            
            return val_2.三丞丆万下丒丟与丛();
        }
        private int 三丞丆万下丒丟与丛()
        {
            var val_6;
            System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一> val_1 = new System.Collections.Generic.List<PGCompany.MainStore.世专丟丕丝丝专东一>();
            PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().不丈丒且丐丝丟丛丅(且下丒丒丑与不丛业:  "Default", 万丆丛世丈上丕东丗: ref  val_1);
            List.Enumerator<T> val_3 = val_1.GetEnumerator();
            val_6 = 0;
            goto label_3;
            label_5:
            val_6 = 0.丐丏七丌丕丗业且上().丄丟七丆丕东丞丆上() + val_6;
            label_3:
            if(( & 1) != 0)
            {
                goto label_5;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (int)val_6;
        }
        private int 丙丂丝丘丛世东上业()
        {
            System.Collections.Generic.IEnumerable<System.String> val_1 = BalanceController.丈东上丟丅丝与丝丟();
            if(val_1 == null)
            {
                    return (int)val_1;
            }
            
            return System.Linq.Enumerable.Count<System.String>(source:  val_1);
        }
        public InAppBonusLobbyButtonCollectionManager()
        {
            this.ChangeDelay = 5f;
        }
    
    }

}
