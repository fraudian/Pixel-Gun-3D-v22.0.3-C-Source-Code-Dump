using UnityEngine;

namespace PickUpObjectSystem
{
    internal sealed class PickUpObjectController : PGBehaviour, 东丁丆一业丈万丆丐
    {
        // Fields
        internal static PickUpObjectSystem.PickUpObjectController 丄丘七三上丕世丞业;
        private System.Collections.Generic.List<PickUpObjectSystem.PickUpObject> 丅丑东丐丌丅丅丁丒;
        private PhotonView _photonView;
        private int 万丆专下一丟不世与;
        private static readonly string 与丗丞且丆不丑一丙;
        private System.Collections.Generic.HashSet<int> 丕下丝丈且丙丈丌丑;
        private bool 丏业丈丁丒世丗丘丕;
        
        // Methods
        private void Awake()
        {
            var val_10;
            var val_11;
            System.Action<与丅丕丈丘东丝世丟> val_12;
            var val_13;
            var val_14;
            System.Action<与丅丕丈丘东丝世丟> val_15;
            val_10 = null;
            val_10 = null;
            PickUpObjectSystem.PickUpObjectController.丄丘七三上丕世丞业 = this;
            if(this._photonView != 0)
            {
                    this._photonView = this.GetComponent<PhotonView>();
            }
            
            val_11 = null;
            val_11 = null;
            val_13 = null;
            val_14 = null;
            if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PickUpObjectSystem.PickUpObjectController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != val_14))
            {
                    val_13 = null;
                val_14 = null;
                val_12 = 0;
            }
            
            GameConnect.丆且丏丂丁且专一下 = val_12;
            if(((System.Delegate.Combine(a:  GameConnect.不且一万专丟丝专丘, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PickUpObjectSystem.PickUpObjectController::不且一万专丟丝专丘(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)))) != null) && (null != null))
            {
                    val_15 = 0;
            }
            
            GameConnect.不且一万专丟丝专丘 = val_15;
            InGameConnection.不丘业专下下丅丂丗(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PickUpObjectSystem.PickUpObjectController::丛丑三不丈一不世丘(bool 丂丘下万丈丘丅一丄)));
            OnlineModeController.add_onDisconnect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PickUpObjectSystem.PickUpObjectController::上丆丁东三丆丄一丕()));
        }
        private void OnDestroy()
        {
            var val_8;
            System.Delegate val_10;
            System.Action<与丅丕丈丘东丝世丟> val_11;
            System.Action<与丅丕丈丘东丝世丟> val_13;
            val_8 = null;
            val_8 = null;
            if(GameConnect.丆且丏丂丁且专一下 != null)
            {
                    System.Action<与丅丕丈丘东丝世丟> val_1 = null;
                val_10 = val_1;
                val_1 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PickUpObjectSystem.PickUpObjectController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
                val_8 = null;
                if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  val_1)) != null) && (null != null))
            {
                    val_8 = null;
                val_11 = 0;
            }
            
                GameConnect.丆且丏丂丁且专一下 = val_11;
            }
            
            val_8 = null;
            if(GameConnect.不且一万专丟丝专丘 != null)
            {
                    System.Action<与丅丕丈丘东丝世丟> val_4 = null;
                val_10 = val_4;
                val_4 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PickUpObjectSystem.PickUpObjectController::不且一万专丟丝专丘(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
                if(((System.Delegate.Remove(source:  GameConnect.不且一万专丟丝专丘, value:  val_4)) != null) && (null != null))
            {
                    val_13 = 0;
            }
            
                GameConnect.不且一万专丟丝专丘 = val_13;
            }
            
            InGameConnection.丌专世世丑丗丁丙万(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PickUpObjectSystem.PickUpObjectController::丛丑三不丈一不世丘(bool 丂丘下万丈丘丅一丄)));
            OnlineModeController.remove_onDisconnect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PickUpObjectSystem.PickUpObjectController::上丆丁东三丆丄一丕()));
        }
        private void 上丆丁东三丆丄一丕()
        {
            List.Enumerator<T> val_1 = this.丅丑东丐丌丅丅丁丒.GetEnumerator();
            label_6:
            if((1891705048 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  0.丐丏七丌丕丗业且上().gameObject);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.丅丑东丐丌丅丅丁丒.Clear();
        }
        private void 丛丑三不丈一不世丘(bool 丂丘下万丈丘丅一丄)
        {
            var val_7;
            string val_8;
            var val_9;
            this.丏业丈丁丒世丗丘丕 = false;
            val_7 = null;
            val_7 = null;
            val_8 = PickUpObjectSystem.PickUpObjectController.与丗丞且丆不丑一丙;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_8)) == false)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            val_8 = PickUpObjectSystem.PickUpObjectController.与丗丞且丆不丑一丙;
            object val_6 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_8];
            this.万丆专下一丟不世与 = null;
        }
        public void AddPickUpObject(PickUpObjectSystem.丈东丐世丌丏丞丂世 丂一丘丞丗下丝丁丞, object[] 专丒丌丆下丐丞丟丞)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(丂一丘丞丗下丝丁丞 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(丂一丘丞丗下丝丁丞 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = 丂一丘丞丗下丝丁丞;
            val_1[1] = 专丒丌丆下丐丞丟丞;
            this._photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  172, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_1);
        }
        public void AddPickUpObjectRPC(PickUpObjectSystem.丈东丐世丌丏丞丂世 丂一丘丞丗下丝丁丞, int 丞世不丒下上上丝丑, string 丞丅上丏丂且下丅与, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, int 丌丒丝东丌下丕丁丅, object[] 专丒丌丆下丐丞丟丞)
        {
            System.Collections.Generic.List<PickUpObjectSystem.PickUpObject> val_9;
            PickUpObjectSystem.PickUpObject val_2 = PickUpObjectSystem.丁丈丞上与丘丛丟丁.七世丙丂东东丌专丕(上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丂一丘丞丗下丝丁丞:  丂一丘丞丗下丝丁丞, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丗专丆万丏万丂丂丆:  专丒丌丆下丐丞丟丞);
            val_2.丘上丐世丆丑且丞丒(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
            var val_9 = 0;
            label_10:
            val_9 = this.丅丑东丐丌丅丅丁丒;
            if(val_9 >= val_9.Count)
            {
                goto label_7;
            }
            
            val_9 = this.丅丑东丐丌丅丅丁丒.Item[0];
            val_9 = val_9 + 1;
            if(val_4.丏世丑万世一七丟丞 != 丞世不丒下上上丝丑)
            {
                goto label_10;
            }
            
            return;
            label_7:
            if(val_2 == 0)
            {
                    return;
            }
            
            val_2.丌丟丄业且三丛丕丄().SetParent(p:  this.transform);
            val_2.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
            val_2.丏世丑万世一七丟丞 = 丞世不丒下上上丝丑;
            this.丅丑东丐丌丅丅丁丒.Add(item:  val_2);
        }
        private void 丆丙丌丏丒丞东下丑(PickUpObjectSystem.丈东丐世丌丏丞丂世 丂一丘丞丗下丝丁丞, string 丞丅上丏丂且下丅与, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, int 丌丒丝东丌下丕丁丅, object[] 专丒丌丆下丐丞丟丞)
        {
            System.Object[] val_11;
            int val_12;
            string val_13;
            var val_14;
            object val_15;
            var val_16;
            ExitGames.Client.Photon.Hashtable val_17;
            val_11 = 专丒丌丆下丐丞丟丞;
            val_12 = 丌丒丝东丌下丕丁丅;
            val_13 = 丞丅上丏丂且下丅与;
            int val_11 = this.万丆专下一丟不世与;
            val_11 = val_11 + 1;
            this.万丆专下一丟不世与 = val_11;
            val_14 = 1152921505107111936;
            if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
            {
                goto label_20;
            }
            
            ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
            val_15 = 1152921505347686400;
            val_16 = null;
            val_16 = null;
            val_2.Add(key:  PickUpObjectSystem.PickUpObjectController.与丗丞且丆不丑一丙, value:  this.万丆专下一丟不世与);
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  PickUpObjectSystem.PickUpObjectController.与丗丞且丆不丑一丙)) == false)
            {
                goto label_11;
            }
            
            object val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[PickUpObjectSystem.PickUpObjectController.与丗丞且丆不丑一丙];
            ExitGames.Client.Photon.Hashtable val_9 = null;
            val_17 = val_9;
            val_9 = new ExitGames.Client.Photon.Hashtable();
            int val_12 = this.万丆专下一丟不世与;
            val_12 = val_12 - 1;
            val_15 = val_12;
            val_9.Add(key:  null, value:  val_12);
            val_11 = val_11;
            val_12 = val_12;
            val_13 = val_13;
            val_14 = 1152921505107111936;
            if(null < this.万丆专下一丟不世与)
            {
                goto label_19;
            }
            
            goto label_20;
            label_11:
            val_17 = 0;
            label_19:
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  val_17, 丅丞丏丈且专丆不丟:  false);
            label_20:
            this.AddPickUpObjectRPC(丂一丘丞丗下丝丁丞:  丂一丘丞丗下丝丁丞, 丞世不丒下上上丝丑:  this.万丆专下一丟不世与, 丞丅上丏丂且下丅与:  val_13, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 丌丒丝东丌下丕丁丅:  val_12, 专丒丌丆下丐丞丟丞:  val_11);
        }
        public void RemoveObject(PickUpObjectSystem.PickUpObject 丂一丘丞丗下丝丁丞)
        {
            bool val_1 = this.丅丑东丐丌丅丅丁丒.Remove(item:  丂一丘丞丗下丝丁丞);
        }
        internal void 丂丘丗丛上世丝丅丗(PickUpObjectSystem.PickUpObject 不丌丘丟丅丛丄丌丞)
        {
            object val_6;
            PhotonView val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = 不丌丘丟丅丛丄丌丞;
            val_7 = this._photonView;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            val_7 = GameController.onlineMode;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            val_7 = mem[GameController.onlineMode + 352];
            val_7 = GameController.onlineMode.丟三丏丅世一丟丟上;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            if(NetworkStartTable.__il2cppRuntimeField_flags == 0)
            {
                    return;
            }
            
            object[] val_5 = new object[2];
            val_7 = val_5;
            val_7[0] = 不丌丘丟丅丛丄丌丞.丏世丑万世一七丟丞;
            val_11 = null;
            val_11 = null;
            val_6 = 124105336;
            val_7[1] = val_6;
            this._photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  170, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_5);
        }
        private void 丅丒丝丆丈丐上丐丄(int 丞世不丒下上上丝丑, int 丅上丁不丛丁上七丈)
        {
            int val_3;
            System.Collections.Generic.List<PickUpObjectSystem.PickUpObject> val_4;
            val_3 = 丅上丁不丛丁上七丈;
            val_4 = this.丅丑东丐丌丅丅丁丒;
            List.Enumerator<T> val_1 = val_4.GetEnumerator();
            label_4:
            if((1893085080 & 1) == 0)
            {
                goto label_2;
            }
            
            val_4 = 0.丐丏七丌丕丗业且上();
            if(1893085080 != 丞世不丒下上上丝丑)
            {
                goto label_4;
            }
            
            val_4.七世丙丂东东丌专丕(丅上丁不丛丁上七丈:  val_3);
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
        {
            System.Collections.Generic.HashSet<System.Int32> val_8;
            var val_9;
            var val_10;
            string val_11;
            System.Object[] val_12;
            float val_14;
            float val_15;
            float val_16;
            bool val_17;
            int val_18;
            int val_19;
            val_8 = 丞世不丒下上上丝丑;
            byte val_1 = val_8 & 255;
            if(val_1 > 129)
            {
                goto label_1;
            }
            
            if(val_1 == 2)
            {
                goto label_2;
            }
            
            if(val_1 != 129)
            {
                goto label_8;
            }
            
            object val_8 = 专丒丌丆下丐丞丟丞[0];
            this.OnPhotonPlayerConnected(专丞上七七且丝七丗:  与丅丕丈丘东丝世丟.丕丒与丘丏下丁业丕(丁业世丅丌丛上下与:  21884928));
            goto label_50;
            label_1:
            if(val_1 == 170)
            {
                goto label_7;
            }
            
            if(val_1 != 172)
            {
                goto label_8;
            }
            
            object val_9 = 专丒丌丆下丐丞丟丞[0];
            if((1152921504628731903 > 1) || (专丒丌丆下丐丞丟丞.Length < 2))
            {
                goto label_50;
            }
            
            object val_10 = 专丒丌丆下丐丞丟丞[1];
            if(val_10 == null)
            {
                goto label_13;
            }
            
            val_9 = val_10;
            if(val_9 != null)
            {
                goto label_14;
            }
            
            label_13:
            val_9 = 0;
            label_14:
            val_10 = 28563616;
            if(专丒丌丆下丐丞丟丞.Length == 0)
            {
                    val_10 = 28563616;
            }
            
            object val_11 = 专丒丌丆下丐丞丟丞[0];
            if(val_10 == 0)
            {
                    val_10 = 28563616;
            }
            
            val_11 = 64;
            if(val_10 <= 1)
            {
                    val_10 = 28563616;
            }
            
            if(28563616 >= 4)
            {
                goto label_19;
            }
            
            val_12 = System.Array.Empty<System.Object>();
            if((val_11 != 0) && (1 != null))
            {
                    val_11 = 0;
            }
            
            val_14 = 4.09887E-35f;
            val_15 = 0f;
            val_16 = 4.098876E-35f;
            goto label_22;
            label_8:
            val_17 = 0;
            return (bool)val_17;
            label_2:
            object val_12 = 专丒丌丆下丐丞丟丞[0];
            if(null == null)
            {
                goto label_26;
            }
            
            val_17 = true;
            if(1152921504628731903 >= 2)
            {
                    return (bool)val_17;
            }
            
            this.丏业丈丁丒世丗丘丕 = val_17;
            val_8 = this.丕下丝丈且丙丈丌丑;
            object val_13 = 专丒丌丆下丐丞丟丞[1];
            if((val_8.Contains(item:  21884928)) == true)
            {
                goto label_50;
            }
            
            val_18 = 专丒丌丆下丐丞丟丞.Length;
            if(val_18 == 0)
            {
                    val_18 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_14 = 专丒丌丆下丐丞丟丞[0];
            if(val_18 <= 1)
            {
                    val_18 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_15 = 专丒丌丆下丐丞丟丞[1];
            if(val_18 <= 2)
            {
                    val_18 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            val_8 = 专丒丌丆下丐丞丟丞[2];
            if(val_18 <= 3)
            {
                    val_18 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_16 = 专丒丌丆下丐丞丟丞[3];
            object val_17 = 专丒丌丆下丐丞丟丞[4];
            if((val_8 != null) && (null != null))
            {
                    val_8 = 0;
            }
            
            this.AddPickUpObjectRPC(丂一丘丞丗下丝丁丞:  1152921504628731904, 丞世不丒下上上丝丑:  21884928, 丞丅上丏丂且下丅与:  val_8, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 丌丒丝东丌下丕丁丅:  21884928, 专丒丌丆下丐丞丟丞:  System.Array.Empty<System.Object>());
            goto label_50;
            label_7:
            val_19 = 专丒丌丆下丐丞丟丞.Length;
            if(val_19 == 0)
            {
                    val_19 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_18 = 专丒丌丆下丐丞丟丞[0];
            object val_19 = 专丒丌丆下丐丞丟丞[1];
            this.丅丒丝丆丈丐上丐丄(丞世不丒下上上丝丑:  21884928, 丅上丁不丛丁上七丈:  21884928);
            label_50:
            val_17 = 1;
            return (bool)val_17;
            label_26:
            this.丏业丈丁丒世丗丘丕 = true;
            return (bool)val_17;
            label_19:
            object[] val_7 = new object[1];
            val_12 = val_7;
            val_12[0] = mem[7599944634466311];
            if((val_11 != 0) && (1 != null))
            {
                    val_11 = 0;
            }
            
            val_14 = 4.09887E-35f;
            val_15 = 0f;
            val_16 = 4.098876E-35f;
            label_22:
            this.丆丙丌丏丒丞东下丑(丂一丘丞丗下丝丁丞:  1152921504628731904, 丞丅上丏丂且下丅与:  val_11, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, 丌丒丝东丌下丕丁丅:  mem[15762873573703680], 专丒丌丆下丐丞丟丞:  val_7);
            goto label_50;
        }
        private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
        {
            object val_3;
            float val_4;
            System.Collections.Generic.List<PickUpObjectSystem.PickUpObject> val_11;
            if(专丞上七七且丝七丗 == null)
            {
                    return;
            }
            
            if((this.丅丑东丐丌丅丅丁丒 == null) || (this.丅丑东丐丌丅丅丁丒.Count == 0))
            {
                goto label_3;
            }
            
            val_11 = this.丅丑东丐丌丅丅丁丒;
            List.Enumerator<T> val_2 = val_11.GetEnumerator();
            label_25:
            if((1893736144 & 1) == 0)
            {
                goto label_5;
            }
            
            object[] val_6 = new object[5];
            val_6[0] = val_3;
            val_6[1] = val_6.Length;
            val_6[2] = val_6.Length;
            UnityEngine.Vector3 val_8 = val_4.丐丏七丌丕丗业且上().丌丟丄业且三丛丕丄().position;
            val_4 = val_8.x;
            val_6[3] = val_8;
            val_6[4] = val_6.Length;
            this._photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  2, 万丌万丅专丞业丈万:  专丞上七七且丝七丗 = 专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_6);
            goto label_25;
            label_3:
            object[] val_9 = new object[1];
            val_11 = val_9;
            val_4 = 0;
            val_11[0] = val_4;
            this._photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  2, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_9);
            return;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 不且一万专丟丝专丘(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
        {
            System.Object[] val_6;
            if(专丞上七七且丝七丗 == null)
            {
                    return;
            }
            
            if(this.丏业丈丁丒世丗丘丕 == true)
            {
                    return;
            }
            
            val_6 = 1152921505107111936;
            if((专丞上七七且丝七丗.Equals(丘丛丏丘丝七世七丅:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())) != false)
            {
                    this.丏业丈丁丒世丗丘丕 = true;
                return;
            }
            
            object[] val_3 = new object[1];
            val_6 = val_3;
            val_6[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
            this._photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  129, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_3);
        }
        public PickUpObjectController()
        {
            this.丅丑东丐丌丅丅丁丒 = new System.Collections.Generic.List<PickUpObjectSystem.PickUpObject>();
            this.丕下丝丈且丙丈丌丑 = new System.Collections.Generic.HashSet<System.Int32>();
        }
        private static PickUpObjectController()
        {
            PickUpObjectSystem.PickUpObjectController.与丗丞且丆不丑一丙 = "KEY_CURRENT_INDEX_PICK_UP_OBJECT_CONTROLLER";
        }
    
    }

}
