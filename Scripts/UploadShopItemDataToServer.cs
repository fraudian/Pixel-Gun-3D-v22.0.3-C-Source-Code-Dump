using UnityEngine;
public class UploadShopItemDataToServer : MonoBehaviour
{
    // Fields
    public UIToggle defaultToggle;
    public UIToggle defaultFilterToggle;
    public System.Collections.Generic.List<丅丒丌且三丅丄丆丟> itemsData;
    public UILabel buttonApplyLabel;
    public UISprite generateButton;
    public UIWidget filtersContainer;
    public UIWidget checkAllContainer;
    private UploadShopItemDataToServer.丌丁丁业丈一三丂丁 丂丘丏丟丙丛三东丗;
    private UploadShopItemDataToServer.与且三与丌不丁丂七 与不一东丁丐丏与丒;
    
    // Methods
    private string 丌丒万丞丒专丞丒丄()
    {
        var val_18;
        var val_19;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        System.Collections.Generic.List<System.Collections.Generic.List<System.Object>> val_2 = new System.Collections.Generic.List<System.Collections.Generic.List<System.Object>>();
        System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
        val_18 = null;
        val_18 = null;
        val_3.Add(item:  与世丁丙且丑下丌不.丙不专业丙丗丁丆丌);
        val_3.Add(item:  与世丁丙且丑下丌不.三七且业丝丌一东东);
        val_3.Add(item:  与世丁丙且丑下丌不.丏业丝丌丛业与东丈);
        val_3.Add(item:  与世丁丙且丑下丌不.且下丗丐丆下且丄丌);
        System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
        val_4.Add(item:  与世丁丙且丑下丌不.下丅丙丞丛且七丂丝);
        val_4.Add(item:  与世丁丙且丑下丌不.丒丑丝丒三丅三上丈);
        val_4.Add(item:  与世丁丙且丑下丌不.丟专丛万上丐丆丂丁);
        System.Collections.Generic.List<System.String> val_5 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.String> val_6 = new System.Collections.Generic.List<System.String>();
        System.Collections.Generic.List<System.Collections.Generic.List<System.Object>> val_7 = new System.Collections.Generic.List<System.Collections.Generic.List<System.Object>>();
        val_19 = 0;
        goto label_10;
        label_34:
        丅丒丌且三丅丄丆丟 val_8 = this.itemsData.Item[0];
        if(val_8.且丑丛丏丌世丆七丌 != false)
        {
                丅丒丌且三丅丄丆丟 val_9 = this.itemsData.Item[0];
            val_5.Add(item:  val_9.丆万一不丌且东丐丐);
        }
        
        丅丒丌且三丅丄丆丟 val_10 = this.itemsData.Item[0];
        if(val_10.万世丆丏丟丑不丄丝 != false)
        {
                丅丒丌且三丅丄丆丟 val_11 = this.itemsData.Item[0];
            val_6.Add(item:  val_11.丆万一不丌且东丐丐);
        }
        
        丅丒丌且三丅丄丆丟 val_12 = this.itemsData.Item[0];
        if(val_12.三丒万万丗世三丆丄 >= 1)
        {
                System.Collections.Generic.List<System.Object> val_13 = new System.Collections.Generic.List<System.Object>();
            丅丒丌且三丅丄丆丟 val_14 = this.itemsData.Item[0];
            val_13.Add(item:  val_14.丆万一不丌且东丐丐);
            丅丒丌且三丅丄丆丟 val_15 = this.itemsData.Item[0];
            val_13.Add(item:  val_15.三丒万万丗世三丆丄);
            val_7.Add(item:  val_13);
        }
        
        val_19 = 1;
        label_10:
        if(val_19 < this.itemsData.Count)
        {
            goto label_34;
        }
        
        if(val_1 != 0)
        {
                val_1.Add(key:  "discounts", value:  val_2);
        }
        else
        {
                val_1.Add(key:  "discounts", value:  val_2);
        }
        
        val_1.Add(key:  "news", value:  val_3);
        if(val_1 != 0)
        {
                val_1.Add(key:  "news_up", value:  val_5);
        }
        else
        {
                val_1.Add(key:  "news_up", value:  val_5);
        }
        
        val_1.Add(key:  "topSellers", value:  val_4);
        if(val_1 != 0)
        {
                val_1.Add(key:  "topSellers_up", value:  val_6);
        }
        else
        {
                val_1.Add(key:  "topSellers_up", value:  val_6);
        }
        
        val_1.Add(key:  "discounts_up", value:  val_7);
        return (string)Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1);
    }
    public void Show(UploadShopItemDataToServer.与且三与丌不丁丂七 丁丅丈丌丟世丗丗丟)
    {
        UILabel val_3;
        string val_4;
        UIPanel val_2 = this.gameObject.GetComponent<UIPanel>();
        this.丂丘丏丟丙丛三东丗 = 1;
        this.defaultToggle.value = true;
        this.与不一东丁丐丏与丒 = 丁丅丈丌丟世丗丗丟;
        if(丁丅丈丌丟世丗丗丟 != 1)
        {
                if(丁丅丈丌丟世丗丗丟 != 0)
        {
                return;
        }
        
            val_3 = this.buttonApplyLabel;
            val_4 = "Upload to server";
        }
        else
        {
                val_3 = this.buttonApplyLabel;
            val_4 = "Download from server";
        }
        
        val_3.text = val_4;
    }
    public void Hide()
    {
        if((this.gameObject.GetComponent<UIPanel>()) == null)
        {
            
        }
    
    }
    public void ChangeCurrentPlatform(UIToggle 丒世丅业丝东下与丗)
    {
        丌丁丁业丈一三丂丁 val_9;
        if(丒世丅业丝东下与丗 == 0)
        {
                return;
        }
        
        if(丒世丅业丝东下与丗.value == false)
        {
                return;
        }
        
        string val_3 = 丒世丅业丝东下与丗.name;
        if((System.String.op_Equality(a:  val_3, b:  "IOSCheckbox")) != false)
        {
                this.丂丘丏丟丙丛三东丗 = 0;
            return;
        }
        
        if((System.String.op_Equality(a:  val_3, b:  "TestCheckbox")) != false)
        {
                val_9 = 1;
        }
        else
        {
                if((System.String.op_Equality(a:  val_3, b:  "AndroidCheckbox")) != false)
        {
                val_9 = 2;
        }
        else
        {
                if((System.String.op_Equality(a:  val_3, b:  "AmazonCheckbox")) != false)
        {
                val_9 = 3;
        }
        else
        {
                if((System.String.op_Equality(a:  val_3, b:  "WindowsPhoneCheckbox")) == false)
        {
                return;
        }
        
            val_9 = 4;
        }
        
        }
        
        }
        
        this.丂丘丏丟丙丛三东丗 = val_9;
    }
    private string 丞丘万丂丞专丁上与(UploadShopItemDataToServer.丌丁丁业丈一三丂丁 丁丅丈丌丟世丗丗丟)
    {
        var val_1;
        if(this.丂丘丏丟丙丛三东丗 <= 4)
        {
                val_1 = mem[130688944 + (this.丂丘丏丟丙丛三东丗) << 3];
            val_1 = 130688944 + (this.丂丘丏丟丙丛三东丗) << 3;
            return (string)val_1;
        }
        
        val_1 = "promo_actions_test1.php";
        return (string)val_1;
    }
    public string GetPromoActionUrl()
    {
        var val_1;
        if(this.丂丘丏丟丙丛三东丗 <= 4)
        {
                val_1 = mem[130688992 + (this.丂丘丏丟丙丛三东丗) << 3];
            val_1 = 130688992 + (this.丂丘丏丟丙丛三东丗) << 3;
            return (string)val_1;
        }
        
        val_1 = "https://secure.pixelgunserver.com/pixelgun3d-config/PromoActions/promo_actions.json";
        return (string)val_1;
    }
    private string 丟丌下丗丕丁业丅丙(string 丕丗丘丑丛与丑业丒)
    {
        string val_1 = this.丞丘万丂丞专丁上与(丁丅丈丌丟世丗丗丟:  丕丗丘丑丛与丑业丒);
        if((System.IO.File.Exists(path:  val_1)) != false)
        {
                System.IO.File.Delete(path:  val_1);
        }
        
        new System.Text.UTF8Encoding() = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier:  true);
        System.Byte[] val_5 = new System.Text.UTF8Encoding().GetBytes(s:  丕丗丘丑丛与丑业丒);
        var val_7 = 0;
        val_7 = val_7 + 1;
        System.IO.File.Create(path:  val_1).Dispose();
        if(0 != 1)
        {
                if(70 == 70)
        {
                return val_1;
        }
        
        }
        
        if(0 == 0)
        {
                return val_1;
        }
        
        return val_1;
    }
    private void 丑丗丅万丗丗业丄丒(string 丝丈丝丆世丁丄专丂)
    {
        System.Net.WebRequest val_13 = System.Net.WebRequest.Create(requestUriString:  "ftp://secure.pixelgunserver.com//test.htm");
        if(val_13 == null)
        {
            goto label_3;
        }
        
        if(null == null)
        {
            goto label_4;
        }
        
        label_3:
        val_13 = 0;
        label_4:
        val_13.UsePassive = false;
        new System.Net.NetworkCredential() = new System.Net.NetworkCredential(userName:  "rilisoft", password:  "11QQwwee");
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Upload File Complete, status {0}", arg0:  0.StatusDescription));
    }
    public string GenerateTextForUploadFile()
    {
        string val_12;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        System.Text.StringBuilder val_2 = val_1.AppendLine(value:  "<?php");
        string val_5 = this.丌丒万丞丒专丞丒丄().Replace(oldValue:  "\"", newValue:  "\\\"")(this.丌丒万丞丒专丞丒丄().Replace(oldValue:  "\"", newValue:  "\\\"")) + "\\r\\n";
        if(val_1 != null)
        {
                System.Text.StringBuilder val_6 = val_1.AppendFormat(format:  "$val = \"{0}\";\n", arg0:  val_5);
            System.Text.StringBuilder val_7 = val_1.AppendLine(value:  "echo $val;");
            val_12 = "?>";
            System.Text.StringBuilder val_8 = val_1.AppendLine(value:  val_12);
        }
        else
        {
                System.Text.StringBuilder val_9 = val_1.AppendFormat(format:  "$val = \"{0}\";\n", arg0:  val_5);
            System.Text.StringBuilder val_10 = val_1.AppendLine(value:  "echo $val;");
            val_12 = "?>";
            System.Text.StringBuilder val_11 = val_1.AppendLine(value:  val_12);
        }
    
    }
    private void 丝丐上丐丐与丏一业()
    {
        string val_1 = this.GenerateTextForUploadFile();
        string val_2 = this.丟丌下丗丕丁业丅丙(丕丗丘丑丛与丑业丒:  val_1);
        val_2.丑丗丅万丗丗业丄丒(丝丈丝丆世丁丄专丂:  val_1);
        UnityEngine.Debug.Log(message:  val_2);
    }
    public void ApplyButtonClick()
    {
        if(this.与不一东丁丐丏与丒 == 1)
        {
            goto label_0;
        }
        
        if(this.与不一东丁丐丏与丒 != 0)
        {
            goto label_2;
        }
        
        this.丝丐上丐丐与丏一业();
        goto label_2;
        label_0:
        this.generateButton.gameObject.SetActive(value:  true);
        this.filtersContainer.gameObject.SetActive(value:  true);
        this.checkAllContainer.gameObject.SetActive(value:  true);
        this.defaultFilterToggle.value = true;
        label_2:
        this.Hide();
    }
    public UploadShopItemDataToServer()
    {
    
    }

}
