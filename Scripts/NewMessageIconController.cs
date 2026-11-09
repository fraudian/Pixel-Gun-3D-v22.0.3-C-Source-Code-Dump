using UnityEngine;
public class NewMessageIconController : MonoBehaviour
{
    // Fields
    public bool privateMessageFriends;
    public bool inviteToFriends;
    public bool inviteToClan;
    public bool clanMessages;
    public bool privateMessageClan;
    public bool requestsInClan;
    public bool giftsCount;
    public UnityEngine.GameObject newMessageSprite;
    public UILabel countLabel;
    
    // Methods
    private void Start()
    {
        this.丑丌丏世丂七世万丏();
    }
    private void 丑丌丏世丂七世万丏()
    {
        var val_63;
        UILabel val_83;
        var val_84;
        var val_85;
        int val_86;
        var val_87;
        var val_88;
        var val_89;
        System.Func<丅下丙一东丄丕丛下, System.Boolean> val_91;
        var val_92;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_94;
        var val_95;
        System.Func<System.String, System.Boolean> val_97;
        var val_98;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_100;
        var val_101;
        System.Func<System.String, System.Boolean> val_103;
        UnityEngine.GameObject val_104;
        val_83 = this;
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                var val_6 = ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丟业丅世丟丗丄丞万()) < 2) ? 1 : 0;
        }
        else
        {
                val_84 = 0;
        }
        
        if(this.privateMessageFriends == false)
        {
            goto label_9;
        }
        
        val_85 = null;
        val_85 = null;
        val_86 = ChatController.丑万丂世丛丙万丝丛;
        if(val_86 < 1)
        {
            goto label_9;
        }
        
        val_86 = ChatController.丑万丂世丛丙万丝丛;
        if(val_84 != 0)
        {
            goto label_12;
        }
        
        label_14:
        val_87 = 0;
        goto label_13;
        label_9:
        val_86 = 0;
        if(val_84 == 0)
        {
            goto label_14;
        }
        
        label_12:
        if(((this.requestsInClan != false) && ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)) && (((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) - 1) <= 1))
        {
                val_88 = 1152921525729783104;
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄().Count) >= 1)
        {
                val_89 = null;
            val_89 = null;
            val_91 = NewMessageIconController.<>c.<>9__10_0;
            if(val_91 == null)
        {
                System.Func<丅下丙一东丄丕丛下, System.Boolean> val_21 = null;
            val_91 = val_21;
            val_21 = new System.Func<丅下丙一东丄丕丛下, System.Boolean>(object:  NewMessageIconController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NewMessageIconController.<>c::丗下丌丆丈丁世丘丐(丅下丙一东丄丕丛下 下丅丙一丂丗丅丝七));
            NewMessageIconController.<>c.<>9__10_0 = val_91;
        }
        
            if((System.Linq.Enumerable.Any<丅下丙一东丄丕丛下>(source:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄(), predicate:  val_21)) != false)
        {
                val_86 = (Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().上丟下丌丞业丞专丄().Count) + val_86;
        }
        
        }
        
        }
        
        val_87 = 1;
        label_13:
        if((this.inviteToClan != false) && ((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null))
        {
                if((System.Linq.Enumerable.Any<System.String>(source:  PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丟丒丙七丛万与丅丟().上丞东丌丐世与业丕())) != false)
        {
                val_86 = PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丟丒丙七丛万与丅丟().上丞东丌丐世与业丕().Count + val_86;
        }
        
        }
        
        if(this.inviteToFriends == false)
        {
            goto label_113;
        }
        
        System.Collections.Generic.HashSet<System.String> val_42 = new System.Collections.Generic.HashSet<System.String>();
        丄上三丛丛上一业三 val_43 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if(val_43.业丈丞丐万丄不上丄 != null)
        {
                丄上三丛丛上一业三 val_44 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
            val_92 = null;
            val_92 = null;
            val_94 = NewMessageIconController.<>c.<>9__10_1;
            if(val_94 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_45 = null;
            val_94 = val_45;
            val_45 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  NewMessageIconController.<>c.__il2cppRuntimeField_static_fields, method:  System.String NewMessageIconController.<>c::与一专万专丗丙丌上(System.Collections.Generic.KeyValuePair<string, string> 三丟东丕丄丄下下丑));
            NewMessageIconController.<>c.<>9__10_1 = val_94;
        }
        
            val_95 = null;
            val_95 = null;
            val_97 = NewMessageIconController.<>c.<>9__10_2;
            if(val_97 == null)
        {
                System.Func<System.String, System.Boolean> val_47 = null;
            val_97 = val_47;
            val_47 = new System.Func<System.String, System.Boolean>(object:  NewMessageIconController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NewMessageIconController.<>c::丞业世丏丘丛丏丑丆(string 三丟东丕丄丄下下丑));
            NewMessageIconController.<>c.<>9__10_2 = val_97;
        }
        
            val_42.UnionWith(other:  System.Linq.Enumerable.Where<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  val_44.业丈丞丐万丄不上丄, selector:  val_45), predicate:  val_47));
        }
        
        丄上三丛丛上一业三 val_49 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
        if(val_49.一丒丈丈专上丝丝丞 != null)
        {
                丄上三丛丛上一业三 val_50 = 丄上三丛丛上一业三.丑七不且上丗丁一世();
            val_98 = null;
            val_98 = null;
            val_100 = NewMessageIconController.<>c.<>9__10_3;
            if(val_100 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_51 = null;
            val_100 = val_51;
            val_51 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  NewMessageIconController.<>c.__il2cppRuntimeField_static_fields, method:  System.String NewMessageIconController.<>c::与丅业专下丞丌专东(System.Collections.Generic.KeyValuePair<string, string> 三丟东丕丄丄下下丑));
            NewMessageIconController.<>c.<>9__10_3 = val_100;
        }
        
            val_101 = null;
            val_101 = null;
            val_103 = NewMessageIconController.<>c.<>9__10_4;
            if(val_103 == null)
        {
                System.Func<System.String, System.Boolean> val_53 = null;
            val_103 = val_53;
            val_53 = new System.Func<System.String, System.Boolean>(object:  NewMessageIconController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NewMessageIconController.<>c::丝丛丐丐下丄丘丛东(string 三丟东丕丄丄下下丑));
            NewMessageIconController.<>c.<>9__10_4 = val_103;
        }
        
            val_42.UnionWith(other:  System.Linq.Enumerable.Where<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  val_50.一丒丈丈专上丝丝丞, selector:  val_51), predicate:  val_53));
        }
        
        System.Collections.Generic.IEnumerable<System.String> val_56 = Rilisoft.丈丑丟丏丏与丟丙且.丑七不且上丗丁一世().业丆丙丆东上丛三丅();
        if(val_56 != null)
        {
                val_42.UnionWith(other:  val_56);
        }
        
        if(且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万() != null)
        {
                val_42.UnionWith(other:  且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万());
        }
        
        HashSet.Enumerator<T> val_61 = val_42.GetEnumerator();
        val_88 = 1152921516734113248;
        goto label_102;
        label_103:
        string val_64 = val_63.丐丏七丌丕丗业且上();
        if((丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄().ContainsKey(key:  val_64)) != true)
        {
                if((丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁().ContainsKey(key:  val_64)) != true)
        {
                if((且世且丄七世丗丂丑.丑七不且上丗丁一世().丟丕丅丌丒业东专万().Contains(item:  val_64)) == false)
        {
            goto label_102;
        }
        
        }
        
        }
        
        int val_82 = ChatController.丗丟三丙丆丝三万丂() + val_86;
        val_82 = val_82 + 1;
        label_102:
        if((679891200 & 1) != 0)
        {
            goto label_103;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        label_113:
        int val_83 = val_82;
        val_83 = this.业东与业业不三丘丒() + val_83;
        val_104 = this.newMessageSprite;
        bool val_84 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
        if(val_104 != 0)
        {
                val_104 = this.newMessageSprite;
            bool val_78 = val_84 ^ 1;
            val_84 = ((val_83 > 0) ? 1 : 0) & val_78;
            val_78 = val_84 ^ val_104.activeSelf;
            if(val_78 != false)
        {
                val_104 = this.newMessageSprite;
            val_104.SetActive(value:  val_84);
        }
        
        }
        
        if(this.countLabel == 0)
        {
                return;
        }
        
        val_83 = this.countLabel;
        val_83.text = val_83.ToString();
    }
    private void Update()
    {
        this.丑丌丏世丂七世万丏();
    }
    private int 业东与业业不三丘丒()
    {
        var val_4;
        System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean> val_6;
        if(this.giftsCount == false)
        {
                return 0;
        }
        
        val_4 = null;
        val_4 = null;
        val_6 = NewMessageIconController.<>c.<>9__12_0;
        if(val_6 != null)
        {
                return System.Linq.Enumerable.Count<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(source:  Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘(), predicate:  System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean> val_3 = null);
        }
        
        val_6 = val_3;
        val_3 = new System.Func<PGCompany.GiftSystem.丏下丙丂万且一丑丛, System.Boolean>(object:  NewMessageIconController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean NewMessageIconController.<>c::丙丘上丟丂丛东丛丕(PGCompany.GiftSystem.丏下丙丂万且一丑丛 三丟东丕丄丄下下丑));
        NewMessageIconController.<>c.<>9__12_0 = val_6;
        return System.Linq.Enumerable.Count<PGCompany.GiftSystem.丏下丙丂万且一丑丛>(source:  Progress.七七世万专丕丁上业.丕丏丛丏丑七七丁专().丏专丞丅且不丛丟丘(), predicate:  val_3);
    }
    public NewMessageIconController()
    {
    
    }

}
