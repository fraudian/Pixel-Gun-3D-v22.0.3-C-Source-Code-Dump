using UnityEngine;

namespace Rilisoft
{
    public class GameEventExtendedEventInfoView : MonoBehaviour
    {
        // Fields
        private ArmoryInfoScreenController 下丏丗且丅丟丄丂与;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UnityEngine.Vector4 丑丘三丈且丄丒一丗;
        private Rilisoft.上专业三丟丁丞专下 不丑丆丌世丁丛与一;
        private bool 丕七且三丆丝丙丏上;
        private bool 上丁专万丗丘丄七丌;
        private System.Action 下东专丟丘丒丒丐丒;
        private UIScrollView _scroll;
        private UIWrapContent _wrap;
        private UnityEngine.GameObject _parentEventInfo;
        private UnityEngine.GameObject _childEventInfo;
        private System.Collections.Generic.List<UITextureMasked> _chestsImages;
        private Rilisoft.GameEventProgressBar _progressBar;
        private System.Collections.Generic.List<UILabel> _chestNames;
        private UILabel _text;
        private UILabel _textSuper;
        
        // Properties
        public Rilisoft.丛且世丐丆上七业丁 丞丂丄丛丛万丅丐丄 { get; }
        
        // Methods
        public Rilisoft.丛且世丐丆上七业丁 get_ContextEvent()
        {
            if(this.不丑丆丌世丁丛与一 == null)
            {
                    return 0;
            }
            
            if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世() == null)
            {
                    return 0;
            }
            
            Rilisoft.三一丈七且丄与丝东 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_2 != null)
            {
                    return val_2.丞丅业丕上丂一丂上(丅且三万丘丙业丙丗:  this.不丑丆丌世丁丛与一.丛丑丗下丗丝下丂世());
            }
            
            return val_2.丞丅业丕上丂一丂上(丅且三万丘丙业丙丗:  this.不丑丆丌世丁丛与一.丛丑丗下丗丝下丂世());
        }
        public void add_OnCloseRequest(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.下东专丟丘丒丒丐丒, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下东专丟丘丒丒丐丒 != 1152921542832685688);
        
        }
        public void remove_OnCloseRequest(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.下东专丟丘丒丒丐丒, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下东专丟丘丒丒丐丒 != 1152921542832822264);
        
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.GameEventExtendedEventInfoView::Hide()), 与且专丈不万东一万:  0);
        }
        private void OnDisable()
        {
            丞东丑专丛丆丄丝世.不不丏专丟丆丕丛丗(丄丑三东丘丆丂丟丙:  this._scroll);
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        public void Show(Rilisoft.上专业三丟丁丞专下 丐下丝丘丑丟丟丗丌, bool 丁丞丅上丝三丐丅丆 = False)
        {
            var val_24;
            var val_25;
            float val_26;
            float val_27;
            System.Collections.Generic.List<UITextureMasked> val_28;
            var val_29;
            bool val_1 = 丁丞丅上丝三丐丅丆;
            this.不丑丆丌世丁丛与一 = 丐下丝丘丑丟丟丗丌;
            this.丕七且三丆丝丙丏上 = val_1;
            this.丝一丅丆三东丂丞七();
            if(val_1 == false)
            {
                goto label_1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressBar.gameObject, 丏业丟一东丂东丘丛:  false);
            if((UnityEngine.Object.op_Implicit(exists:  this._text)) != false)
            {
                    this._text.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6700");
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._textSuper)) != false)
            {
                    this._textSuper.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6700");
            }
            
            val_24 = 1152921542833233680;
            val_25 = 0;
            val_26 = 30f;
            goto label_17;
            label_28:
            if((UnityEngine.Object.op_Implicit(exists:  this._chestsImages.Item[0])) != false)
            {
                    UnityEngine.Vector3 val_11 = UnityEngine.Vector3.down;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_26);
                val_27 = val_12.y;
                this._chestsImages.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_27, z = val_12.z};
            }
            
            val_25 = 1;
            label_17:
            val_28 = this._chestsImages;
            if(val_25 < val_28.Count)
            {
                goto label_28;
            }
            
            return;
            label_1:
            if((UnityEngine.Object.op_Implicit(exists:  this._text)) != false)
            {
                    this._text.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3458");
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._textSuper)) != false)
            {
                    this._textSuper.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3913");
            }
            
            val_24 = 1152921542833233680;
            val_29 = 0;
            goto label_42;
            label_53:
            if((UnityEngine.Object.op_Implicit(exists:  this._chestsImages.Item[0])) != false)
            {
                    UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
                val_26 = val_22.x;
                val_27 = val_22.z;
                this._chestsImages.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = val_26, y = val_22.y, z = val_27};
            }
            
            val_29 = 1;
            label_42:
            val_28 = this._chestsImages;
            if(val_29 < val_28.Count)
            {
                goto label_53;
            }
        
        }
        public void Hide()
        {
            if(this.下东专丟丘丒丒丐丒 == null)
            {
                    return;
            }
            
            this.下东专丟丘丒丒丐丒.Invoke();
        }
        private void 丝一丅丆三东丂丞七()
        {
            System.Collections.Generic.List<UITextureMasked> val_19;
            var val_20;
            var val_21;
            if(this.不丑丆丌世丁丛与一 == null)
            {
                    return;
            }
            
            bool val_1 = this.不丑丆丌世丁丛与一.丐丏下丕三丒丗丅丛();
            val_19 = this._childEventInfo.gameObject;
            if(val_19 == null)
            {
                goto label_3;
            }
            
            if(val_1 == false)
            {
                goto label_4;
            }
            
            label_11:
            val_19.SetActive(value:  true);
            this._parentEventInfo.gameObject.SetActive(value:  false);
            val_20 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressBar.gameObject, 丏业丟一东丂东丘丛:  false);
            goto label_10;
            label_3:
            if(val_1 == true)
            {
                goto label_11;
            }
            
            label_4:
            val_19.SetActive(value:  false);
            this._parentEventInfo.gameObject.SetActive(value:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressBar.gameObject, 丏业丟一东丂东丘丛:  true);
            this._progressBar.SetPossibleProgress(丐下丝丘丑丟丟丗丌:  this.不丑丆丌世丁丛与一, 丌丙丆丐丂东下丘不:  (this.丕七且三丆丝丙丏上 == false) ? 1 : 0);
            val_21 = 0;
            goto label_18;
            label_24:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._chestsImages.Item[0], 丏业丟一东丂东丘丛:  (val_21 == (this.不丑丆丌世丁丛与一.业上丙丞丐丄丆丅七() - 1)) ? 1 : 0);
            val_21 = 1;
            label_18:
            val_19 = this._chestsImages;
            val_20 = public System.Int32 System.Collections.Generic.List<UITextureMasked>::get_Count();
            if(val_21 < val_19.Count)
            {
                goto label_24;
            }
            
            label_10:
            if(this._chestNames != null)
            {
                    val_19 = 1152921505284374528;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.不丑丆丌世丁丛与一)) != true)
            {
                    val_19 = this._chestNames;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_19, 丕丗丘丑丛与丑业丒:  this.不丑丆丌世丁丛与一);
            }
            
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.业丑丈丁丙丁世丂丁());
            UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  this.业丑丈丁丙丁世丂丁());
        }
        private System.Collections.IEnumerator 业丑丈丁丙丁世丂丁()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventExtendedEventInfoView.丁丂与丙下东丐丏丑();
        }
        private void 丘丙丅下丟丄丏下丆(GameEventItemGui 与与三一丞丛丒不丟)
        {
            UnityEngine.Object val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            丕丈丏丑丌丂且万不 val_32;
            string val_33;
            int val_34;
            val_26 = 与与三一丞丛丒不丟;
            val_27 = 1152921504848912384;
            if(val_26 == 0)
            {
                    return;
            }
            
            if(val_26.Data == null)
            {
                    return;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() != 0)
            {
                    Rilisoft.AbstractGameEventGui val_5 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
                Rilisoft.GameEventItemData val_6 = val_26.Data;
                val_28 = ???;
                val_29 = ???;
            }
            else
            {
                    val_30 = null;
                val_30 = null;
                if(DuelController.丄丘七三上丕世丞业 != 0)
            {
                    val_31 = null;
                val_31 = null;
                DuelController.丄丘七三上丕世丞业.duelUI.不一丒丁丗上丗上世(丙丈下丕丑专上丕丛:  val_28.Data);
                return;
            }
            
                val_32 = 0;
                if(val_28.Data.Type == 1300)
            {
                    ItemViewer.丕丈丏丑丌丂且万不 val_18 = null;
                val_32 = val_18;
                val_18 = new ItemViewer.丕丈丏丑丌丂且万不();
                .万丄丅丛下丐丒丞上 = ExperienceController.丞丞丘业东丙丏七丌();
            }
            
                val_33 = val_28.Data.Id;
                val_34 = val_28.Data.Count;
                Rilisoft.ItemViewer val_24 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  0, 丕丁下丌不万丅丞丛:  val_33, 丅三丟世下丞丝丙万:  val_34, 丗丟上上丒丐丗丞丙:  val_18, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  true);
            }
        
        }
        private void 上且不七上下丆万丄(int 丞东丆与下丁丆七与)
        {
            float val_8;
            int val_8 = UnityEngine.Mathf.Clamp(value:  丞东丆与下丁丆七与 - 1, min:  1, max:  2147483647);
            val_8 = val_8 * this._wrap.itemSize;
            UnityEngine.Vector4 val_4 = UnityEngine.Vector4.zero;
            if((UnityEngine.Vector4.op_Equality(lhs:  new UnityEngine.Vector4() {x = this.丑丘三丈且丄丒一丗, y = V9.16B, z = V10.16B, w = V8.16B}, rhs:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w})) != false)
            {
                    UnityEngine.Vector4 val_6 = this._scroll.GetComponent<UIPanel>().finalClipRegion;
                val_8 = val_6.z;
                this.丑丘三丈且丄丒一丗 = val_6;
                mem[1152921542834348348] = val_6.y;
                mem[1152921542834348352] = val_8;
                mem[1152921542834348356] = val_6.w;
            }
            
            this._scroll.disableDragIfFits = (S8 > (float)val_8) ? 1 : 0;
        }
        public GameEventExtendedEventInfoView()
        {
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
            this.丑丘三丈且丄丒一丗 = val_1;
            mem[1152921542834476732] = val_1.y;
            mem[1152921542834476736] = val_1.z;
            mem[1152921542834476740] = val_1.w;
            this.上丁专万丗丘丄七丌 = true;
        }
    
    }

}
