using UnityEngine;
public class AGSRequestResponse
{
    // Fields
    public string error;
    public int userData;
    protected const string PLATFORM_NOT_SUPPORTED_ERROR = "PLATFORM_NOT_SUPPORTED";
    protected const string JSON_PARSE_ERROR = "ERROR_PARSING_JSON";
    
    // Methods
    public bool IsError()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.error);
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    public AGSRequestResponse()
    {
    
    }

}
