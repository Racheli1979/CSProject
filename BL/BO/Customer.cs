using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה לפרטי לקוח
    /// </summary>
    /// <param name="CustomerId">מספר מזהה</params>
    /// <param name="CustomerName">שם לקוח</params>
    /// <param name="Address">כתובת</params>
    /// <param name="Phone">טלפון</params>

    public class Customer
    {
        public int CustomerId { get; init; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public override string ToString() => this.ToStringProperty();
    }
}
