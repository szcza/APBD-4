namespace APBD_4.Visits;

public class Visit
{
    public int Id {get; set;}
    public int AnimalId { get; set; }
    public DateTime VisitDate { get; set; }
    public string VisitDescription { get; set; }
    public double VetFee { get; set; }
}