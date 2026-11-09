using UnityEngine;

namespace Rilisoft
{
    internal sealed class ClanMembersHeaderView : PGBehaviour
    {
        // Fields
        private DynamicWrapGrid wrap;
        private UICenterOnChild centerOnChild;
        private float distanceToUpdateClan;
        private Rilisoft.ClanMembersHeaderViewItem 丅东七且丑丈丑丗不;
        
        // Methods
        private void LateUpdate()
        {
            Rilisoft.ClanMembersHeaderViewItem val_19;
            var val_20;
            if(this.wrap.ScrollView.isDragging != true)
            {
                    UnityEngine.Vector3 val_4 = this.wrap.ScrollView.currentMomentum;
                if(val_4.x <= 0.0001f)
            {
                    return;
            }
            
            }
            
            val_19 = 0;
            val_20 = 0;
            goto label_7;
            label_19:
            UnityEngine.Vector3 val_9 = this.transform.position;
            UnityEngine.Vector3 val_10 = this.wrap.GridItems.Item[0].transform.position;
            val_10.x = val_9.x - val_10.x;
            float val_19 = System.Math.Abs(val_10.x);
            if(((3.402823E+38f) > val_19) && (val_19 < 0))
            {
                    val_20 = val_19;
            }
            
            val_19 = 1;
            label_7:
            if(val_19 < this.wrap.GridItems.Count)
            {
                goto label_19;
            }
            
            if(val_20 == 1)
            {
                    return;
            }
            
            val_19 = this.丅东七且丑丈丑丗不;
            if(this.wrap.GridItems.Item[0] == val_19)
            {
                    return;
            }
            
            val_19 = this.wrap.GridItems;
            this.丕丙与三且丌丒丞丟(下且专丒下丙丈丈丒:  val_19.Item[0].gameObject);
        }
        private void OnEnable()
        {
            ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanMembersHeaderView::东丘丙且丐丛丏丝业()));
            this.wrap.allowNegativeIndices = true;
            this.丛万丅一丁丂丅丝丁();
            this.centerOnChild.enabled = false;
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.不丑丏三下丟丒业世());
            this.丂丗丏不丛丂上丝丟(丁丅丈丌丟世丗丗丟:  0);
        }
        private System.Collections.IEnumerator 不丑丏三下丟丒业世()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ClanMembersHeaderView.一丂且下丄上世不上();
        }
        private void OnDisable()
        {
            ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanMembersHeaderView::东丘丙且丐丛丏丝业()));
        }
        private void 丂丗丏不丛丂上丝丟(Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 丁丅丈丌丟世丗丗丟)
        {
            object val_9;
            UnityEngine.Object val_10;
            ClanMembersHeaderView.业东下丕世丗丏万丏 val_1 = null;
            val_9 = val_1;
            val_1 = new ClanMembersHeaderView.业东下丕世丗丏万丏();
            .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
            int val_4 = this.丆丝不丆不与丂下丑().FindIndex(match:  new System.Predicate<Rilisoft.一世丑丙丝与丒一丐>(object:  val_1, method:  System.Boolean ClanMembersHeaderView.业东下丕世丗丏万丏::专三下丝丟世丂万丞(Rilisoft.一世丑丙丝与丒一丐 三丟东丕丄丄下下丑)));
            if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
            this.wrap.ScrollToCenterOnItem(世万专丛与丐丌专不:  val_4);
            val_9 = this.wrap;
            System.Collections.Generic.List<DynamicWrapGridItem> val_5 = val_9.GridItems;
            if(val_5 != null)
            {
                    val_10 = val_5.Item[val_4];
            }
            else
            {
                    val_10 = 0;
            }
            
            if(val_10 == 0)
            {
                    return;
            }
            
            this.丅东七且丑丈丑丗不 = val_10.GetComponent<Rilisoft.ClanMembersHeaderViewItem>();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            this.东丘丙且丐丛丏丝业();
            this.丕丙与三且丌丒丞丟();
        }
        internal void 丛万丅一丁丂丅丝丁()
        {
            this.东丘丙且丐丛丏丝业();
            this.丕丙与三且丌丒丞丟(下且专丒下丙丈丈丒:  this.世丐丟丆丞丈丁丏三());
        }
        internal void 七丑丏丁专且丄丆丛()
        {
            丄丂丏世丛丏万三丆 val_4;
            if(this.丅东七且丑丈丑丗不.type == 1)
            {
                goto label_2;
            }
            
            if(this.丅东七且丑丈丑丗不.type == 0)
            {
                goto label_3;
            }
            
            if(this.丅东七且丑丈丑丗不.type != 1)
            {
                goto label_4;
            }
            
            label_2:
            val_4 = this.丅东七且丑丈丑丗不.type + 1;
            if(val_4 != 1)
            {
                goto label_6;
            }
            
            label_4:
            val_4 = 0;
            goto label_6;
            label_3:
            val_4 = 1;
            label_6:
            this.丂丗丏不丛丂上丝丟(丁丅丈丌丟世丗丗丟:  val_4);
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            丄丌丈不丒且丈丒丈 val_2 = (val_4 < 3) ? (val_4) : (!0);
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) != null)
            {
                    Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.丑丒上业丈不七丕丐 = val_2;
            }
            else
            {
                    Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.丑丒上业丈不七丕丐 = val_2;
            }
            
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.UpdateMembersScroll();
        }
        internal void 且丟上丞丑三丄专一()
        {
            丄丌丈不丒且丈丒丈 val_6;
            丄丌丈不丒且丈丒丈 val_7;
            丄丂丏世丛丏万三丆 val_2 = (this.丅东七且丑丈丑丗不.type == 1) ? 0 : ((this.丅东七且丑丈丑丗不.type != 2) ? (true + 1) : true);
            this.丂丗丏不丛丂上丝丟(丁丅丈丌丟世丗丗丟:  val_2);
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            var val_4 = val_2 & 3;
            if(val_4 == 0)
            {
                goto label_7;
            }
            
            if((val_4 != 1) && (val_4 != 2))
            {
                    val_6 = 0;
            }
            
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) == null)
            {
                goto label_10;
            }
            
            label_12:
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.丑丒上业丈不七丕丐 = val_6;
            goto label_13;
            label_7:
            val_7 = 0;
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) != null)
            {
                goto label_12;
            }
            
            label_10:
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.丑丒上业丈不七丕丐 = val_7;
            label_13:
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.UpdateMembersScroll();
        }
        private void 丕丙与三且丌丒丞丟()
        {
            if(this.centerOnChild == 0)
            {
                    return;
            }
            
            if(this.centerOnChild.centeredObject == 0)
            {
                    return;
            }
            
            this.丕丙与三且丌丒丞丟(下且专丒下丙丈丈丒:  this.centerOnChild.centeredObject);
        }
        private void 丕丙与三且丌丒丞丟(UnityEngine.GameObject 下且专丒下丙丈丈丒)
        {
            UnityEngine.GameObject val_7 = 下且专丒下丙丈丈丒;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_7 = val_7.GetComponent<Rilisoft.ClanMembersHeaderViewItem>();
            this.丅东七且丑丈丑丗不 = val_7;
            if(val_7 == 0)
            {
                    return;
            }
            
            if((Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.丑丒上业丈不七丕丐 = (val_2.type < 3) ? val_2.type : (!0);
            Rilisoft.ClansLobbyGui.<不丁丄七丛不丆丁丕>k__BackingField.UpdateMembersScroll();
        }
        private void 东丘丙且丐丛丏丝业()
        {
            this.wrap.UpdateContent(三丏丑不业丏不丂丈:  System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.Cast<System.Object>(source:  this.丆丝不丆不与丂下丑())));
        }
        private System.Collections.Generic.List<Rilisoft.一世丑丙丝与丒一丐> 丆丝不丆不与丂下丑()
        {
            Rilisoft.一世丑丙丝与丒一丐 val_23;
            var val_24;
            System.Func<七丈丗不丞丈丝丙七, System.Int32> val_26;
            var val_27;
            var val_28;
            System.Func<七丈丗不丞丈丝丙七, System.Int32> val_30;
            var val_31;
            System.Func<七丈丗不丞丈丝丙七, System.Int32> val_33;
            var val_34;
            val_23 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_23.丞丗丑丈一丅丗丌丟() == null)
            {
                goto label_2;
            }
            
            Rilisoft.一世丑丙丝与丒一丐 val_3 = null;
            val_23 = val_3;
            val_3 = new Rilisoft.一世丑丙丝与丒一丐();
            val_24 = null;
            val_24 = null;
            val_26 = ClanMembersHeaderView.<>c.<>9__16_0;
            if(val_26 == null)
            {
                    System.Func<七丈丗不丞丈丝丙七, System.Int32> val_7 = null;
                val_26 = val_7;
                val_7 = new System.Func<七丈丗不丞丈丝丙七, System.Int32>(object:  ClanMembersHeaderView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanMembersHeaderView.<>c::丂丆丌丌与丅丈丒与(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
                ClanMembersHeaderView.<>c.<>9__16_0 = val_26;
            }
            
            int val_8 = System.Linq.Enumerable.Sum<七丈丗不丞丈丝丙七>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不(), selector:  val_7);
            if(val_23 == null)
            {
                goto label_10;
            }
            
            val_3.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_8);
            goto label_11;
            label_2:
            System.Collections.Generic.List<Rilisoft.一世丑丙丝与丒一丐> val_9 = null;
            val_27 = val_9;
            val_9 = new System.Collections.Generic.List<Rilisoft.一世丑丙丝与丒一丐>();
            return (System.Collections.Generic.List<Rilisoft.一世丑丙丝与丒一丐>)val_27;
            label_10:
            val_3.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_8);
            label_11:
            val_3.东丝丕专丒丏三三与(丙业与丙丗丝不丈东:  0);
            Rilisoft.一世丑丙丝与丒一丐 val_10 = new Rilisoft.一世丑丙丝与丒一丐();
            val_28 = null;
            val_28 = null;
            val_30 = ClanMembersHeaderView.<>c.<>9__16_1;
            if(val_30 == null)
            {
                    System.Func<七丈丗不丞丈丝丙七, System.Int32> val_14 = null;
                val_30 = val_14;
                val_14 = new System.Func<七丈丗不丞丈丝丙七, System.Int32>(object:  ClanMembersHeaderView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanMembersHeaderView.<>c::不丄丛丅世万丂与丑(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
                ClanMembersHeaderView.<>c.<>9__16_1 = val_30;
            }
            
            int val_15 = System.Linq.Enumerable.Sum<七丈丗不丞丈丝丙七>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不(), selector:  val_14);
            if(val_10 != null)
            {
                    val_10.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_15);
            }
            else
            {
                    val_10.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_15);
            }
            
            val_10.东丝丕专丒丏三三与(丙业与丙丗丝不丈东:  1);
            Rilisoft.一世丑丙丝与丒一丐 val_16 = new Rilisoft.一世丑丙丝与丒一丐();
            val_31 = null;
            val_31 = null;
            val_33 = ClanMembersHeaderView.<>c.<>9__16_2;
            if(val_33 == null)
            {
                    System.Func<七丈丗不丞丈丝丙七, System.Int32> val_20 = null;
                val_33 = val_20;
                val_20 = new System.Func<七丈丗不丞丈丝丙七, System.Int32>(object:  ClanMembersHeaderView.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 ClanMembersHeaderView.<>c::三丐丐丘业丟丁万下(七丈丗不丞丈丝丙七 三丟东丕丄丄下下丑));
                ClanMembersHeaderView.<>c.<>9__16_2 = val_33;
            }
            
            int val_21 = System.Linq.Enumerable.Sum<七丈丗不丞丈丝丙七>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丙丆丞东丆丏丞一不(), selector:  val_20);
            if(val_16 != null)
            {
                    val_16.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_21);
            }
            else
            {
                    val_16.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_21);
            }
            
            val_16.东丝丕专丒丏三三与(丙业与丙丗丝不丈东:  2);
            System.Collections.Generic.List<Rilisoft.一世丑丙丝与丒一丐> val_22 = null;
            val_27 = val_22;
            val_22 = new System.Collections.Generic.List<Rilisoft.一世丑丙丝与丒一丐>();
            if(val_27 != null)
            {
                    val_34 = 1152921542390780704;
                val_22.Add(item:  val_3);
                val_22.Add(item:  val_10);
            }
            else
            {
                    val_34 = 1152921542390780704;
                val_22.Add(item:  val_3);
                val_22.Add(item:  val_10);
            }
            
            val_22.Add(item:  val_16);
            return (System.Collections.Generic.List<Rilisoft.一世丑丙丝与丒一丐>)val_27;
        }
        private UnityEngine.GameObject 世丐丟丆丞丈丁丏三()
        {
            var val_5;
            List.Enumerator<T> val_2 = this.wrap.GridItems.GetEnumerator();
            label_6:
            if(((-870552776) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_3 = 0.丐丏七丌丕丗业且上();
            if(((val_3 == null) || (null != null)) || (null != 0))
            {
                goto label_6;
            }
            
            val_5 = val_3.gameObject;
            goto label_7;
            label_3:
            val_5 = 0;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (UnityEngine.GameObject);
        }
        private Rilisoft.ClansLobbyGui.丄丌丈不丒且丈丒丈 丛下丄万丅丕三世丑(Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 丁丅丈丌丟世丗丗丟)
        {
            return (丄丌丈不丒且丈丒丈)(丁丅丈丌丟世丗丗丟 < 3) ? 丁丅丈丌丟世丗丗丟 : (!0);
        }
        public ClanMembersHeaderView()
        {
            this.distanceToUpdateClan = 0.07f;
        }
    
    }

}
