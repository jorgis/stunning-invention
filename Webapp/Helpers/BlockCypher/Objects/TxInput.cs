#region
using System.Collections.Generic;
using Newtonsoft.Json;

#endregion

namespace WebApp.Helpers.BlockCypher.Objects {
    public class TxInput {
        [JsonProperty("addresses")]
        public IList<string> Addresses { get; set; }
    }
}
