using UnityEngine;

namespace PGCompany
{
    internal class ClanWarTributeChestController : Singleton<PGCompany.ClanWarTributeChestController>
    {
        // Fields
        private UnityEngine.GameObject _notInWarContainer;
        private UnityEngine.GameObject _incomeTimerContainer;
        private UnityEngine.GameObject _availableContainer;
        private UnityEngine.GameObject _underSiegeContainer;
        private UnityEngine.GameObject _noIncomeContainer;
        private UnityEngine.GameObject _goblinCollectContainer;
        private UnityEngine.GameObject _buffSilverContainer;
        private TextMeshBounds _timerTextMeshBounds;
        private TextMeshBounds _silverTextMeshBounds;
        private TextMeshBounds _silverBuffTextMeshBounds;
        private TextMeshBounds _valorTextMeshBounds;
        private PGCompany.ClanWarTributeChestController.丆且丄丐专且业丄下 丗下丘世三七一专丕;
        private System.Collections.Generic.Dictionary<PGCompany.ClanWarTributeChestController.丆且丄丐专且业丄下, UnityEngine.GameObject> 七与丑且丁且与丗丕;
        private UnityEngine.Coroutine 丞世下丞万丂万丑丕;
        
        // Methods
        private void Awake()
        {
            System.Collections.Generic.Dictionary<丆且丄丐专且业丄下, UnityEngine.GameObject> val_1 = new System.Collections.Generic.Dictionary<丆且丄丐专且业丄下, UnityEngine.GameObject>();
            val_1.Add(key:  1, value:  this._notInWarContainer);
            val_1.Add(key:  2, value:  this._incomeTimerContainer);
            val_1.Add(key:  3, value:  this._availableContainer);
            val_1.Add(key:  4, value:  this._underSiegeContainer);
            val_1.Add(key:  5, value:  this._noIncomeContainer);
            val_1.Add(key:  6, value:  this._goblinCollectContainer);
            this.七与丑且丁且与丗丕 = val_1;
        }
        private void OnEnable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notInWarContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._incomeTimerContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._availableContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._underSiegeContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._noIncomeContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._goblinCollectContainer, 丏业丟一东丂东丘丛:  false);
            PGCompany.ItemExpiryController.丐丐丞丒下丙丟丂万(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.ClanWarTributeChestController::且下丆丆丙专下丑丅(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞)));
            if(this.丞世下丞万丂万丑丕 != null)
            {
                    this.StopCoroutine(routine:  this.丞世下丞万丂万丑丕);
            }
            
            this.丗不丌丗丙丄与丘下();
        }
        private void OnDisable()
        {
            PGCompany.ItemExpiryController.丙不世丅丐丛万丅且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.ClanWarTributeChestController::且下丆丆丙专下丑丅(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞)));
            this.StopCoroutine(routine:  this.丞世下丞万丂万丑丕);
        }
        internal void 业专三丗丁丕且东世()
        {
            var val_12;
            var val_13;
            val_12 = this;
            if((this.丗下丘世三七一专丕 != 5) && (this.丗下丘世三七一专丕 != 4))
            {
                    if(this.丗下丘世三七一专丕 != 3)
            {
                    return;
            }
            
                if((Rilisoft.Singleton<ClansController>.Instance.丈丝丒丌丛丙丐丐世(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  1)) != false)
            {
                    val_12 = Rilisoft.Singleton<ClansController>.Instance.丈丄一丈丆且丕丞丌(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  1);
                InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9102"), arg0:  丑丁世丒丅丄丈丑丙.七与丑下丅万丗不丞(丅专与丒丈丗丒丘丌:  1)), 丂三丟丂丈丐丆丗丟:  (float)val_12, 丛丒丟一万上丒丁七:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9101"));
                return;
            }
            
                val_13 = null;
                val_13 = null;
                ClanWarUI.上与丛三不世丄一上 = true;
            }
            
            Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丒丐与丐丝丞东丝丌();
        }
        private void 丗不丌丗丙丄与丘下()
        {
            var val_21;
            var val_42;
            ulong val_43;
            var val_44;
            this.丞世下丞万丂万丑丕 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  1f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarTributeChestController::丗不丌丗丙丄与丘下()));
            val_42 = 1152921505570795520;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buffSilverContainer, 丏业丟一东丂东丘丛:  (PGCompany.ClanStoreBuffsController.丆丛七丆万丕丘业丂() != 0) ? 1 : 0);
            val_43 = 1152921525544440992;
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丞丕业丞丆丘下三()) == false)
            {
                goto label_8;
            }
            
            int val_8 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐不业一业丁丞世丏();
            if(一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与() < 1)
            {
                goto label_12;
            }
            
            if(val_8 == 1)
            {
                goto label_18;
            }
            
            if(val_8 == 2)
            {
                goto label_37;
            }
            
            val_44 = 6;
            goto label_68;
            label_8:
            val_44 = 1;
            goto label_68;
            label_12:
            if(val_8 == 0)
            {
                goto label_17;
            }
            
            if(val_8 == 1)
            {
                goto label_18;
            }
            
            if(val_8 == 2)
            {
                goto label_37;
            }
            
            System.Nullable<System.DateTime> val_11 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世专世丒一下丟世丟();
            System.Nullable<System.DateTime> val_12 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(((-1897789168) & 1) == 0)
            {
                    return;
            }
            
            if(((-1897789184) & 1) == 0)
            {
                    return;
            }
            
            val_42 = 1152921504618614784;
            val_43;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {}, t2:  new System.DateTime() {dateData = val_43})) == false)
            {
                    return;
            }
            
            System.TimeSpan val_14 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {}, d2:  new System.DateTime() {});
            val_43 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_14._ticks}, 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            this._timerTextMeshBounds.Text = val_43;
            val_44 = 2;
            goto label_68;
            label_18:
            val_44 = 4;
            goto label_68;
            label_17:
            System.Collections.Generic.List<Rilisoft.OfferItem> val_17 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丁七丈丐且丝丐不();
            if(val_17.Count < 1)
            {
                goto label_37;
            }
            
            List.Enumerator<T> val_19 = val_17.GetEnumerator();
            goto label_46;
            label_48:
            string val_22 = val_21.丐丏七丌丕丗业且上();
            Rilisoft.OfferItemType val_23 = val_22.Type;
            if(val_23 == 1200)
            {
                goto label_41;
            }
            
            if(val_23 != 1220)
            {
                goto label_46;
            }
            
            int val_25 = val_22.Count + 0;
            goto label_46;
            label_41:
            if((System.String.op_Equality(a:  val_22.Id, b:  "ClanSilver")) != false)
            {
                    int val_29 = val_22.Count + 0;
            }
            
            label_46:
            if(((-1897789216) & 1) != 0)
            {
                goto label_48;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_56;
            label_37:
            val_44 = 5;
            label_68:
            this.丗丄且丌下世上丈与(丏业丟一东丂东丘丛:  5);
            return;
            label_56:
            ??? + 88.Text = (???) - 68.ToString();
            PGCompany.丌丐下丌丘下丝丞业 val_32 = PGCompany.ClanStoreBuffsController.丆丛七丆万丕丘业丂();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  ??? + 96, 丏业丟一东丂东丘丛:  (val_32 != 0) ? 1 : 0);
            if(val_32 != null)
            {
                    float val_42 = (float)??? + -68;
                val_42 = (((float)PGCompany.BuffController.丑七不且上丗丁一世().丅业专丏不丒丄丐一(丒与丏丛且万丘业丆:  1)) * 0.01f) * val_42;
                mem2[0] = UnityEngine.Mathf.CeilToInt(f:  val_42);
                ??? + 96.Text = (???) - 68.ToString();
            }
            
            ??? + 104.Text = (???) - 72.ToString();
            goto label_68;
        }
        private void 丗丄且丌下世上丈与(PGCompany.ClanWarTributeChestController.丆且丄丐专且业丄下 丏业丟一东丂东丘丛)
        {
            System.Collections.Generic.Dictionary<丆且丄丐专且业丄下, UnityEngine.GameObject> val_5;
            if(this.丗下丘世三七一专丕 == 丏业丟一东丂东丘丛)
            {
                    return;
            }
            
            val_5 = this.七与丑且丁且与丗丕;
            Dictionary.Enumerator<TKey, TValue> val_1 = val_5.GetEnumerator();
            label_6:
            if(((-1897580936) & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2._value._obj, 丏业丟一东丂东丘丛:  (val_2._value._obj.丙东专丂世丈丏丁丂() == 丏业丟一东丂东丘丛) ? 1 : 0);
            goto label_6;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丗下丘世三七一专丕 = 丏业丟一东丂东丘丛;
        }
        private void 且下丆丆丙专下丑丅(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丑七不与丛丆一丂丞)
        {
            string val_5;
            var val_6;
            var val_7;
            val_6 = this;
            List.Enumerator<T> val_1 = 丑七不与丛丆一丂丞.GetEnumerator();
            label_7:
            if(((-1897444312) & 1) == 0)
            {
                goto label_2;
            }
            
            val_7 = null;
            val_7 = null;
            val_5 = PGCompany.ClanStoreBuffsController.丌丛丈丏丞且丐丐不;
            if((0.丐丏七丌丕丗业且上().业上丙丞丐丄丆丅七().Equals(value:  val_5)) == false)
            {
                goto label_7;
            }
            
            this.丗不丌丗丙丄与丘下();
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public ClanWarTributeChestController()
        {
        
        }
    
    }

}
