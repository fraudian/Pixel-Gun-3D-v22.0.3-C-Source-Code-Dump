using UnityEngine;
public sealed class PanelWithLeagueButtons : PGBehaviour
{
    // Fields
    private WidgetLayout _widgetLayout;
    private LeagueIconWithBackground _exampleButton;
    private SelectableButtonController _selectableButtonController;
    public System.Action<LeagueIconWithBackground> buttonSelected;
    
    // Methods
    private void OnEnable()
    {
        this._selectableButtonController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PanelWithLeagueButtons::专丏且丗丙丞丛丄东()));
    }
    private void OnDisable()
    {
        this._selectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PanelWithLeagueButtons::专丏且丗丙丞丛丄东()));
    }
    public RatingSystem.RatingLeague GetSelectedLeague()
    {
        if(this._selectableButtonController == 0)
        {
                return 0;
        }
        
        if(this._selectableButtonController.selectedButton == 0)
        {
                return 0;
        }
        
        this = this._selectableButtonController.selectedButton.GetComponent<LeagueIconWithBackground>();
        if(this == 0)
        {
                return 0;
        }
        
        if(this != null)
        {
                return this.丈三与世丟下丅丄专();
        }
        
        return this.丈三与世丟下丅丄专();
    }
    public void CreateButtons()
    {
        RatingLeague val_9;
        if(this._exampleButton == 0)
        {
                return;
        }
        
        不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._widgetLayout.transform);
        this._widgetLayout.widgets.Clear();
        this._selectableButtonController.allButtons.Clear();
        val_9 = 0;
        goto label_11;
        label_25:
        LeagueIconWithBackground val_4 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<LeagueIconWithBackground>(丑且不丕与专丄业丙:  this._exampleButton, 丈东丘丏与丌东东下:  this._widgetLayout.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_4, 丏业丟一东丂东丘丛:  true);
        if(val_4 != null)
        {
                val_4.Setup(丙丑七万丆万丆且丌:  val_9);
        }
        else
        {
                val_4.Setup(丙丑七万丆万丆且丌:  val_9);
        }
        
        bool val_6 = UnityEngine.Object.op_Inequality(x:  val_4.GetComponent<SelectableButton>(), y:  0);
        val_9 = 1;
        label_11:
        if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_9)) == true)
        {
            goto label_25;
        }
        
        this._widgetLayout.CollectWidgets();
        this._widgetLayout.Reposition();
        this.上与东丆一不丄丌丌();
    }
    private void 上与东丆一不丄丌丌()
    {
        goto label_1;
        label_18:
        SelectableButton val_1 = X21 + 80.Item[0];
        if(val_1 != 0)
        {
                LeagueIconWithBackground val_3 = val_1.GetComponent<LeagueIconWithBackground>();
            if(val_3 != 0)
        {
                if(val_3.丈三与世丟下丅丄专() == RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏())
        {
            goto label_14;
        }
        
        }
        
        }
        
        0 = 1;
        label_1:
        if(0 < this._selectableButtonController.allButtons.Count)
        {
            goto label_18;
        }
        
        this._selectableButtonController.下丁万万丅丆东不不();
        return;
        label_14:
        if(this._selectableButtonController == null)
        {
            
        }
    
    }
    private void 专丏且丗丙丞丛丄东()
    {
        LeagueIconWithBackground val_1 = this._selectableButtonController.selectedButton.GetComponent<LeagueIconWithBackground>();
        if(val_1 == 0)
        {
                return;
        }
        
        if(this.buttonSelected == null)
        {
                return;
        }
        
        this.buttonSelected.Invoke(obj:  val_1);
    }
    public PanelWithLeagueButtons()
    {
    
    }

}
