namespace deliveryCenter;

internal class InternationalShipment : Shipment 
{
    public string DestinationCountry { get; set { if (value != null && value != " ") DestinationCountry = value; } }
    public decimal CustomsFee { get; set { if (value >= 0) CustomsFee = value; } }
    public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination,string destinationCountry,decimal customsFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }
    public override decimal EstimatedCost {get { return DeliveryFee + (Weight * 5) + CustomsFee;} }

}
