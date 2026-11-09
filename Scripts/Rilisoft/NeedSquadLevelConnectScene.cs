using UnityEngine;

namespace Rilisoft
{
    public sealed class NeedSquadLevelConnectScene : MonoBehaviour
    {
        // Fields
        private bool 丅丈专三一丄丞丐丅;
        private UILabel[] _needLevelLabels;
        private UnityEngine.GameObject _needLevelObject;
        
        // Methods
        public void RefreshNeedSquadLevelLabel()
        {
            this.丒丝丟丏世丅世不丄();
        }
        private void 丒丝丟丏世丅世不丄()
        {
            var val_11;
            var val_12;
            var val_13;
            if(this._needLevelObject == 0)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy != true)
            {
                    this.gameObject.SetActive(value:  true);
            }
            
            val_11 = static_value_081DACA8;
            val_11 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16) == 0)
            {
                goto label_11;
            }
            
            val_12 = static_value_081DACA8;
            val_12 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16.世丞不丈丕丝东丞上()) == false)
            {
                goto label_15;
            }
            
            label_11:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._needLevelObject.gameObject, 丏业丟一东丂东丘丛:  false);
            return;
            label_15:
            val_13 = static_value_081DACA8;
            val_13 = static_value_081DACA8;
            bool val_11 = static_value_081DACA8 + 184 + 16.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  static_value_081DACA8 + 184 + 16 + 48 + 136, 下下丁一下丒业丄业:  false);
            if(val_11 != true)
            {
                    this.一世丑万世丒三丑万();
            }
            
            val_11 = val_11 ^ 1;
            this._needLevelObject.gameObject.SetActive(value:  val_11);
        }
        private void Start()
        {
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.NeedSquadLevelConnectScene::丙丁与丝东丞丐丐且()));
        }
        private void OnDestroy()
        {
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.NeedSquadLevelConnectScene::丙丁与丝东丞丐丐且()));
        }
        private void OnEnable()
        {
            this.丒丝丟丏世丅世不丄();
        }
        private void 丙丁与丝东丞丐丐且()
        {
            this.丅丈专三一丄丞丐丅 = false;
        }
        private void 一世丑万世丒三丑万()
        {
            int val_18;
            var val_22;
            var val_23;
            var val_24;
            System.Func<MapPreviewController, System.Int32> val_26;
            string val_27;
            var val_28;
            var val_29;
            var val_30;
            System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世> val_32;
            var val_33;
            var val_34;
            System.Func<MapPreviewController, SceneInfo> val_36;
            var val_37;
            var val_38;
            System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世> val_40;
            int val_41;
            var val_42;
            var val_43;
            if(this._needLevelLabels == null)
            {
                    return;
            }
            
            val_22 = 1152921505052479488;
            val_23 = static_value_081DACA8;
            val_23 = static_value_081DACA8;
            val_24 = null;
            val_24 = null;
            val_26 = NeedSquadLevelConnectScene.<>c.<>9__9_0;
            if(val_26 == null)
            {
                    System.Func<MapPreviewController, System.Int32> val_1 = null;
                val_26 = val_1;
                val_1 = new System.Func<MapPreviewController, System.Int32>(object:  NeedSquadLevelConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 NeedSquadLevelConnectScene.<>c::七丗世三丐七丕丏丂(MapPreviewController 三丟东丕丄丄下下丑));
                NeedSquadLevelConnectScene.<>c.<>9__9_0 = val_26;
            }
            
            int val_2 = 丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<System.Int32, MapPreviewController>(丞下万上三丘上与专:  static_value_081DACA8 + 184 + 16 + 48 + 136, 丏丅丁丛一业丈专专:  val_1);
            if(val_2 == 4)
            {
                goto label_13;
            }
            
            if(val_2 == 3)
            {
                goto label_14;
            }
            
            if(val_2 != 2)
            {
                goto label_15;
            }
            
            val_27 = "feature.squad";
            int val_3 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  val_27);
            goto label_42;
            label_13:
            val_28 = null;
            val_28 = null;
            val_29 = static_value_081DACA8;
            val_29 = static_value_081DACA8;
            val_30 = null;
            val_30 = null;
            val_32 = NeedSquadLevelConnectScene.<>c.<>9__9_2;
            if(val_32 == null)
            {
                    System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世> val_4 = null;
                val_32 = val_4;
                val_4 = new System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世>(object:  NeedSquadLevelConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.七丕丟丏三丈一丄世 NeedSquadLevelConnectScene.<>c::丌一丆不丗且丛世丙(MapPreviewController 丒丒丄丁且丄丆丂丌));
                NeedSquadLevelConnectScene.<>c.<>9__9_2 = val_32;
            }
            
            val_33 = static_value_081DACA8;
            val_33 = static_value_081DACA8;
            val_34 = null;
            val_34 = null;
            val_36 = NeedSquadLevelConnectScene.<>c.<>9__9_3;
            if(val_36 == null)
            {
                    System.Func<MapPreviewController, SceneInfo> val_6 = null;
                val_36 = val_6;
                val_6 = new System.Func<MapPreviewController, SceneInfo>(object:  NeedSquadLevelConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  SceneInfo NeedSquadLevelConnectScene.<>c::丞与东丕七丒丏万丄(MapPreviewController 丒丒丄丁且丄丆丂丌));
                NeedSquadLevelConnectScene.<>c.<>9__9_3 = val_36;
            }
            
            val_27 = SceneInfoController.丄丘七三上丕世丞业;
            int val_8 = val_27.丝上专丂且东丏丄丌(丂丛丑东不丅丈一东:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<Rilisoft.七丕丟丏三丈一丄世, MapPreviewController>(丞下万上三丘上与专:  static_value_081DACA8 + 184 + 16 + 48 + 136, 丏丅丁丛一业丈专专:  val_4), 东下丌丝且七丛丘丒:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<SceneInfo, MapPreviewController>(丞下万上三丘上与专:  static_value_081DACA8 + 184 + 16 + 48 + 136, 丏丅丁丛一业丈专专:  val_6), 丁丏丗且上丗下与下:  false);
            goto label_42;
            label_14:
            val_37 = static_value_081DACA8;
            val_37 = static_value_081DACA8;
            val_38 = null;
            val_38 = null;
            val_40 = NeedSquadLevelConnectScene.<>c.<>9__9_1;
            if(val_40 == null)
            {
                    System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世> val_10 = null;
                val_40 = val_10;
                val_10 = new System.Func<MapPreviewController, Rilisoft.七丕丟丏三丈一丄世>(object:  NeedSquadLevelConnectScene.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.七丕丟丏三丈一丄世 NeedSquadLevelConnectScene.<>c::一七丂丐丂丑丛丁丅(MapPreviewController 丒丒丄丁且丄丆丂丌));
                NeedSquadLevelConnectScene.<>c.<>9__9_1 = val_40;
            }
            
            val_27 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
            label_42:
            val_41 = val_27.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  丞东丑专丛丆丄丝世.丆丌丂丞东丗业专丝<Rilisoft.七丕丟丏三丈一丄世, MapPreviewController>(丞下万上三丘上与专:  static_value_081DACA8 + 184 + 16 + 48 + 136, 丏丅丁丛一业丈专专:  val_10));
            goto label_57;
            label_15:
            val_41 = 2;
            label_57:
            val_42 = null;
            val_42 = null;
            if((DungeonWindowUI.dungeonsInfo.ContainsKey(key:  val_2)) != false)
            {
                    val_41 = 丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  丐丄丞世丂丄丛不一.丙丏上丙丙丘上且丁(上且丗一丏丏万丅丌:  22, 专万丟三世业丙丈且:  val_2.ToString(), 丁丏丗且上丗下与下:  false));
                if(val_41 == 2147483647)
            {
                    val_43 = null;
                val_43 = null;
                万丗且专万丟丌丂丐 val_17 = DungeonWindowUI.dungeonsInfo.Item[val_2];
                val_41 = 丐丄丞世丂丄丛不一.东丁七丝丝东万丐下(丈丘丝一丗下丈丐不:  val_18);
            }
            
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._needLevelLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11081"), arg0:  val_41));
            this.丅丈专三一丄丞丐丅 = true;
        }
        public NeedSquadLevelConnectScene()
        {
        
        }
    
    }

}
