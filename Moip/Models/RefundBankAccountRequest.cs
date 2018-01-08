using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Moip;
using Moip.Utilities;

namespace Moip.Models
{
    public class RefundBankAccountRequest : BaseModel
    {
        // These fields hold the values for the public properties.
        private int? amount;
        private Models.RefundingInstrumentBankAccountRequest refundingInstrument;

        [JsonProperty("amount")]
        public int? Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        [JsonProperty("refundingInstrument")]
        public Models.RefundingInstrumentBankAccountRequest RefundingInstrument
        {
            get
            {
                return this.refundingInstrument;
            }
            set
            {
                this.refundingInstrument = value;
                onPropertyChanged("refundingInstrument");
            }
        }
    }
}
