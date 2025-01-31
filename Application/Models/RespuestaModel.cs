namespace Application;


public class RespuestaModel:ErrorModel
{
     public string message { get; set; }
    public bool success { get; set; }
    public object data { get; set; }
    public RespuestaModel()
    {
        
    }

    public RespuestaModel(string message, bool success, object data, string error)
    {
        this.message=message;
        this.success=success;
        this.data=data;
        this.error=error;
    }

}
