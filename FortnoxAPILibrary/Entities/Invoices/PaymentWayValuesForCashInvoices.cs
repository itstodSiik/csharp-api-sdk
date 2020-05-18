using FortnoxAPILibrary.Serialization;
using System.Runtime.Serialization;

namespace FortnoxAPILibrary.Entities
{
    [Entity(SingularName = "PaymentWayValuesForCashInvoices", PluralName = "PaymentWayValuesForCashInvoices")]
    public enum PaymentWay
    {
        ///<summary> Cash payment </summary>
        [EnumMember]
        CASH,
        ///<summary> Card. </summary>
        [EnumMember]
        CARD,
        ///<summary> Direct debit </summary>
        [EnumMember]
        AG
    }
}