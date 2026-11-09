using UnityEngine;

namespace Rilisoft
{
    public class VisibleAtScene : MonoBehaviour
    {
        // Fields
        private bool 丟上丈丕七丈丂丙丕;
        private bool _includeMenuScene;
        private System.Collections.Generic.List<string> _scenes;
        private Rilisoft.东上与丈丒七不丈丐 _visible;
        
        // Methods
        private void Awake()
        {
            var val_11;
            System.Func<System.String, System.String> val_13;
            if(this._includeMenuScene != false)
            {
                    this._scenes.Add(item:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐());
            }
            
            this.丟上丈丕七丈丂丙丕 = this.gameObject.activeSelf;
            val_11 = null;
            val_11 = null;
            val_13 = VisibleAtScene.<>c.<>9__4_0;
            if(val_13 == null)
            {
                    System.Func<System.String, System.String> val_5 = null;
                val_13 = val_5;
                val_5 = new System.Func<System.String, System.String>(object:  VisibleAtScene.<>c.__il2cppRuntimeField_static_fields, method:  System.String VisibleAtScene.<>c::丟丙不丝丗七万丑专(string 丏丛与丅丛丌万专丌));
                VisibleAtScene.<>c.<>9__4_0 = val_13;
            }
            
            this._scenes = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.Select<System.String, System.String>(source:  this._scenes, selector:  val_5));
            this.东与丏丒七丂万东万(三丗丂丘丝丑一丘下:  Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗());
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.七东七不不丅下丞东(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void Rilisoft.VisibleAtScene::丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丘丘丘专丗丕丞丟不)));
        }
        private void OnDestroy()
        {
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丛丌上丐丘不且丙七(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void Rilisoft.VisibleAtScene::丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丘丘丘专丗丕丞丟不)));
        }
        private void 丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丘丘丘专丗丕丞丟不)
        {
            this.东与丏丒七丂万东万(三丗丂丘丝丑一丘下:  丘丘丘专丗丕丞丟不.<且上丁世丞丛上丁不>k__BackingField.丐丏七丌丕丗业且上());
        }
        private void 东与丏丒七丂万东万(string 三丗丂丘丝丑一丘下)
        {
            Rilisoft.东上与丈丒七不丈丐 val_6;
            if((this._scenes.Contains(item:  三丗丂丘丝丑一丘下.ToLower())) != false)
            {
                    val_6 = this._visible;
                var val_4 = (val_6 == 1) ? 1 : 0;
            }
            else
            {
                    val_6 = this.丟上丈丕七丈丂丙丕;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  (val_6 == true) ? 1 : 0);
        }
        public VisibleAtScene()
        {
            this._scenes = new System.Collections.Generic.List<丞丘丒一上与丕丒且>();
        }
    
    }

}
