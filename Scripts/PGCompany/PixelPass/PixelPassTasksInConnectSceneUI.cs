using UnityEngine;

namespace PGCompany.PixelPass
{
    internal sealed class PixelPassTasksInConnectSceneUI : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _buyPremiumGO;
        private UnityEngine.GameObject _lockGO;
        private UILabel _lockLabel;
        private PixelPassTaskView _taskView;
        private float _seconds;
        private GuiApplyersGroup _guiApplyersGroup;
        private PGCompany.PixelPass.丙丙丕万东丘下丅丌 丑与万三丐丒丏一专;
        private UnityEngine.Coroutine 东丄丑业丄丗丛丒丞;
        private System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丕丛丅专万丁万东一;
        private PGCompany.PixelPass.一万丄一丌丆业丐丅 与丌万不业与万万丅;
        private int 下丙丈丈专与专丑丝;
        
        // Methods
        private void OnEnable()
        {
            PixelTime.丗丛东丏丛丏丑丂丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassTasksInConnectSceneUI::丝一丅丆三东丂丞七()));
            PixelTime.业丂三上七专丌与丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassTasksInConnectSceneUI::丝一丅丆三东丂丞七()));
            GameConnect.丞且丛东不丈下且东(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassTasksInConnectSceneUI::且丐上丘七丛丐业专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            string val_30;
            var val_31;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_33;
            var val_34;
            var val_35;
            System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_37;
            Rilisoft.丝丑丂丛万丐丈丘且 val_38;
            var val_39;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_41;
            var val_42;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_44;
            var val_45;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_47;
            var val_48;
            val_30 = this;
            PGCompany.PixelPass.丘丏丅丆丑下业丙七 val_1 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世();
            this.丑与万三丐丒丏一专 = val_1.<丈丏丑不东业丟丗丘>k__BackingField;
            if((PixelTime.丝业丁丌丘东丏世与() == false) || (this.丑与万三丐丒丏一专 == null))
            {
                goto label_7;
            }
            
            if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丟丂下七且七东丛丞() != true)
            {
                    if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() == false)
            {
                goto label_7;
            }
            
            }
            
            if(this.丑与万三丐丒丏一专 != null)
            {
                    PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.下丒与丈世七丈丑丒(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 专与万丐七丌丐丁丂:  this._guiApplyersGroup);
            }
            
            if(this.丕丛丅专万丁万东一 != null)
            {
                    this.丕丛丅专万丁万东一.Clear();
            }
            
            this.下丙丈丈专与专丑丝 = 0;
            this.与丌万不业与万万丅 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyPremiumGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._taskView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockGO, 丏业丟一东丂东丘丛:  false);
            if(this.东丄丑业丄丗丛丒丞 != null)
            {
                    this.StopCoroutine(routine:  this.东丄丑业丄丗丛丒丞);
            }
            
            if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(东丐丐丝业三丅丅丆:  PGCompany.PixelPass.丁且七丅丞丐丌丌世.丑且丁不丅丅上东东())) == false)
            {
                goto label_14;
            }
            
            if(this.丑与万三丐丒丏一专.不丆丑与七下一丛丅() == false)
            {
                    return;
            }
            
            System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_9 = PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丙七丕东丅与丈三不(丈丂七世丟丞丂丗丒:  this.丑与万三丐丒丏一专, 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业(), 丞丁丑丏丄丏七丂不:  0);
            this.丕丛丅专万丁万东一 = val_9;
            if(val_9.Count < 1)
            {
                goto label_20;
            }
            
            val_31 = null;
            val_31 = null;
            val_33 = PixelPassTasksInConnectSceneUI.<>c.<>9__12_0;
            if(val_33 == null)
            {
                    System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_11 = null;
                val_33 = val_11;
                val_11 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  PixelPassTasksInConnectSceneUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassTasksInConnectSceneUI.<>c::丞专且七专丈丁丄丛(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                PixelPassTasksInConnectSceneUI.<>c.<>9__12_0 = val_33;
            }
            
            val_34 = null;
            if((System.Linq.Enumerable.Any<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  this.丕丛丅专万丁万东一, predicate:  val_11)) == false)
            {
                goto label_26;
            }
            
            val_35 = null;
            val_37 = PixelPassTasksInConnectSceneUI.<>c.<>9__12_1;
            if(val_37 == null)
            {
                    System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_13 = null;
                val_37 = val_13;
                val_13 = new System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  PixelPassTasksInConnectSceneUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassTasksInConnectSceneUI.<>c::丆业丐丗丆且丈丆丙(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                PixelPassTasksInConnectSceneUI.<>c.<>9__12_1 = val_37;
            }
            
            int val_14 = this.丕丛丅专万丁万东一.RemoveAll(match:  val_13);
            goto label_33;
            label_7:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buyPremiumGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._taskView, 丏业丟一东丂东丘丛:  false);
            label_47:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockGO, 丏业丟一东丂东丘丛:  false);
            return;
            label_14:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockGO, 丏业丟一东丂东丘丛:  true);
            val_30 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11673");
            if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丑且丁不丅丅上东东() != null)
            {
                    val_38 = val_16.Progress;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._lockLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_30, arg0:  val_38));
            return;
            label_20:
            if(this.丑与万三丐丒丏一专.三丐丌丏专世丆丞丗() == true)
            {
                    return;
            }
            
            goto label_47;
            label_26:
            val_39 = null;
            val_41 = PixelPassTasksInConnectSceneUI.<>c.<>9__12_2;
            if(val_41 == null)
            {
                    System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_19 = null;
                val_41 = val_19;
                val_19 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  PixelPassTasksInConnectSceneUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassTasksInConnectSceneUI.<>c::丕丁丗东丂丏丙三丅(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                PixelPassTasksInConnectSceneUI.<>c.<>9__12_2 = val_41;
            }
            
            val_42 = null;
            val_42 = null;
            val_44 = PixelPassTasksInConnectSceneUI.<>c.<>9__12_3;
            if(val_44 == null)
            {
                    System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_21 = null;
                val_44 = val_21;
                val_21 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  PixelPassTasksInConnectSceneUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassTasksInConnectSceneUI.<>c::丕业丘丒三七丒丅丟(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                PixelPassTasksInConnectSceneUI.<>c.<>9__12_3 = val_44;
            }
            
            val_45 = null;
            val_45 = null;
            val_47 = PixelPassTasksInConnectSceneUI.<>c.<>9__12_4;
            if(val_47 == null)
            {
                    System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_23 = null;
                val_47 = val_23;
                val_23 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  PixelPassTasksInConnectSceneUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassTasksInConnectSceneUI.<>c::东且丏丁下丝丝丗丞(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                PixelPassTasksInConnectSceneUI.<>c.<>9__12_4 = val_47;
            }
            
            val_48 = null;
            val_48 = null;
            val_37 = PixelPassTasksInConnectSceneUI.<>c.<>9__12_5;
            if(val_37 == null)
            {
                    System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_25 = null;
                val_37 = val_25;
                val_25 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  PixelPassTasksInConnectSceneUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PixelPassTasksInConnectSceneUI.<>c::七专丁东丈三与丆丟(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                PixelPassTasksInConnectSceneUI.<>c.<>9__12_5 = val_37;
            }
            
            this.丕丛丅专万丁万东一 = System.Linq.Enumerable.ToList<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  System.Linq.Enumerable.ThenBy<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(source:  System.Linq.Enumerable.ThenByDescending<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(source:  System.Linq.Enumerable.ThenByDescending<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(source:  this.丕丛丅专万丁万东一, keySelector:  val_19), keySelector:  val_21), keySelector:  val_23), keySelector:  val_25));
            label_33:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._taskView, 丏业丟一东丂东丘丛:  true);
            this.东丄丑业丄丗丛丒丞 = this.StartCoroutine(routine:  this.丗丂三一上与与三丘());
        }
        private System.Collections.IEnumerator 丗丂三一上与与三丘()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new PixelPassTasksInConnectSceneUI.与三丟丞一丑丏七专();
        }
        private void 世七丑且丂丟丅丝丑()
        {
            int val_3 = this.下丙丈丈专与专丑丝;
            if(this.丕丛丅专万丁万东一.Count <= val_3)
            {
                    val_3 = 0;
                this.下丙丈丈专与专丑丝 = 0;
            }
            
            PGCompany.PixelPass.一万丄一丌丆业丐丅 val_2 = this.丕丛丅专万丁万东一.Item[0];
            this.与丌万不业与万万丅 = val_2;
            if(this._taskView != null)
            {
                    this._taskView.丈且东丑丂且万丒丅(万不且且丛丆东丒业:  val_2);
            }
            
            int val_3 = this.下丙丈丈专与专丑丝;
            val_3 = val_3 + 1;
            this.下丙丈丈专与专丑丝 = val_3;
        }
        public void U_GoToBuyPremium()
        {
            .不丌不世且丄不三丝 = 3;
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.丛丘专丌业且丑一丄(丗三丝丈专七万丕丆:  new 丆丝丈丐不专一丟且(), 丘丒丅三丞丞丛丛丌:  0);
        }
        public void U_GoToTask()
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_5;
            if(((this.与丌万不业与万万丅.<丒下丅丏丄丗上专业>k__BackingField) != null) && ((this.与丌万不业与万万丅.<丒下丅丏丄丗上专业>k__BackingField.Type) == 4))
            {
                    if((this.与丌万不业与万万丅.<下丒丕丌业一世丙丞>k__BackingField) == null)
            {
                    return;
            }
            
                if((this.与丌万不业与万万丅.<下丒丕丌业一世丙丞>k__BackingField.丞专丅丁丁三丄上专()) == false)
            {
                    return;
            }
            
            }
            
            .不丌不世且丄不三丝 = 2;
            if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  252)) == true)
            {
                goto label_9;
            }
            
            if(this.与丌万不业与万万丅 == null)
            {
                goto label_10;
            }
            
            if((this.与丌万不业与万万丅.<丒下丅丏丄丗上专业>k__BackingField) == null)
            {
                goto label_11;
            }
            
            val_5 = this.与丌万不业与万万丅.<丒下丅丏丄丗上专业>k__BackingField.Index;
            goto label_13;
            label_10:
            val_5 = 0;
            goto label_13;
            label_11:
            val_5 = 0;
            label_13:
            .三专三丐丁世丑丁丅 = val_5;
            label_9:
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.丛丘专丌业且丑一丄(丗三丝丈专七万丕丆:  new 丆丝丈丐不专一丟且(), 丘丒丅三丞丞丛丛丌:  0);
        }
        private void OnDisable()
        {
            if(this.东丄丑业丄丗丛丒丞 != null)
            {
                    this.StopCoroutine(routine:  this.东丄丑业丄丗丛丒丞);
            }
            
            GameConnect.万上与丑丁与丕丟一(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassTasksInConnectSceneUI::且丐上丘七丛丐业专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            PixelTime.丑世世上丘丑与万丒(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassTasksInConnectSceneUI::丝一丅丆三东丂丞七()));
            PixelTime.业一丑上丑三丐七专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.PixelPass.PixelPassTasksInConnectSceneUI::丝一丅丆三东丂丞七()));
        }
        private void 三丏丆丌丐上专丐丄()
        {
            if(this.东丄丑业丄丗丛丒丞 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.东丄丑业丄丗丛丒丞);
        }
        private void 且丐上丘七丛丐业专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丝一丅丆三东丂丞七();
        }
        public PixelPassTasksInConnectSceneUI()
        {
            this._seconds = 0.5f;
        }
    
    }

}
