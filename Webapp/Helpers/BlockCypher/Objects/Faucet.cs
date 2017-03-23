#region
using Newtonsoft.Json;

#endregion

namespace WebApp.Helpers.BlockCypher.Objects {
    public class Faucet : BaseObject {
        [JsonProperty("tx_ref")]
        public string TxReference { get; set; }
    }
}
