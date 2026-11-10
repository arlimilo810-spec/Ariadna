namespace sharpness_sharp.Data.Models;
 
public class Cafe
{
    public int Id { get; set; }
    public string? Imagen { get; set; }
    public string? NombreCafe { get; set; }
    public string? DescripcionCafe { get; set; }
    public decimal PrecioCafe { get; set; }
 
    public Cafe() { }
}
