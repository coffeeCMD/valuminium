namespace Valuminium.Models
{
    /// <summary>Users.Role - CHECK IN ('Employee','Manager')</summary>
    public enum UserRole
    {
        Employee,
        Manager
    }

    /// <summary>Materials.MaterialType - CHECK IN ('Profile','Glass','Hardware','Other')</summary>
    public enum MaterialType
    {
        Profile,
        Glass,
        Hardware,
        Other
    }

    /// <summary>Orders.Status - CHECK IN (...)</summary>
    public enum OrderStatus
    {
        QuoteRequest,
        WaitingMaterials,
        InProduction,
        ReadyForInstall,
        Completed,
        Cancelled
    }

    /// <summary>OrderMaterials.OrderedStatus - CHECK IN ('NotOrdered','Ordered','Received')</summary>
    public enum OrderedStatus
    {
        NotOrdered,
        Ordered,
        Received
    }

    /// <summary>Payments.PaymentType - CHECK IN ('Deposit','Final','ArrivalFee')</summary>
    public enum PaymentType
    {
        Deposit,
        Final,
        ArrivalFee
    }
}
