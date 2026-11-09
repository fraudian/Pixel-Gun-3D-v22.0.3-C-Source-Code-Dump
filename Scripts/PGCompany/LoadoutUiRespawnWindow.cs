using UnityEngine;

namespace PGCompany
{
    public class LoadoutUiRespawnWindow : PGBehaviour
    {
        // Fields
        private PGCompany.LoadoutUiCellRespawnWindow _cellExample;
        private UnityEngine.GameObject _cellEmpty;
        private WidgetLayout _widgetLayout;
        private System.Collections.Generic.List<PGCompany.LoadoutUiCellRespawnWindow> 丌丅东丑业且丐与丛;
        
        // Methods
        private void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._cellExample, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cellEmpty, 丏业丟一东丂东丘丛:  false);
            this.丌丅东丑业且丐与丛.Clear();
        }
        private void OnEnable()
        {
            var val_20;
            var val_21;
            var val_22;
            UnityEngine.Transform val_23;
            var val_24;
            val_20 = 1152921504615739392;
            val_21 = 1152921555738780336;
            val_22 = 0;
            goto label_1;
            label_14:
            PGCompany.LoadoutUiCellRespawnWindow val_4 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<PGCompany.LoadoutUiCellRespawnWindow>(丑且不丕与专丄业丙:  this._cellExample, 丈东丘丏与丌东东下:  this._widgetLayout.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_4, 丏业丟一东丂东丘丛:  true);
            val_4.丈一且一丌上不七丌 = Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().东业七上丛上丝丘丛(与与丕万丌与下丒丆:  0);
            val_4.丝一丅丆三东丂丞七();
            val_4.add_cellClicked(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.LoadoutUiRespawnWindow::丏丘丌丅丁丐丝丞与()));
            this.丌丅东丑业且丐与丛.Add(item:  val_4);
            val_22 = 1;
            label_1:
            val_23 = Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗();
            if(val_22 < val_23.丁丁丆丈丂上丙丞丏())
            {
                goto label_14;
            }
            
            if(this.丌丅东丑业且丐与丛.Count > 2)
            {
                goto label_16;
            }
            
            val_21 = 1152921555738823344;
            val_24 = 0;
            val_20 = 3;
            goto label_17;
            label_36:
            val_23 = this._widgetLayout.transform;
            UnityEngine.GameObject val_10 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._cellEmpty, 丈东丘丏与丌东东下:  val_23, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
            if((val_10.GetComponent<PGCompany.LockedTabOfLoadoutsUi>()) != 0)
            {
                    val_23 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  专且丝丄丙丗丈不丞.丌丄丟东丂下业丕东(丑丅世丐丒丏丐三丅:  (float)Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丙丑丟业丈丐丈丑且()));
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_11.levelLabel, 丕丗丘丑丛与丑业丒:  val_23);
            }
            
            val_24 = 1;
            label_17:
            if(val_24 < (val_20 - this.丌丅东丑业且丐与丛.Count))
            {
                goto label_36;
            }
            
            label_16:
            this._widgetLayout.CollectWidgets();
            this._widgetLayout.Reposition();
        }
        private void OnDisable()
        {
            不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._widgetLayout.transform);
        }
        private void 丏丘丌丅丁丐丝丞与()
        {
            this.U_Hide();
        }
        public void U_Hide()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
        }
        public LoadoutUiRespawnWindow()
        {
            this.丌丅东丑业且丐与丛 = new System.Collections.Generic.List<PGCompany.LoadoutUiCellRespawnWindow>();
        }
    
    }

}
