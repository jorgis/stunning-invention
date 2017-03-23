﻿#region
using WebApp.Helpers.BlockCypher.Helpers;
using WebApp.Helpers.BlockCypher.Pcl;
using Newtonsoft.Json;

#endregion

namespace WebApp.Helpers.BlockCypher.Objects {
    public class AddressInfo : BaseObject {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("private")]
        public string Private { get; set; }

        [JsonProperty("public")]
        public string Public { get; set; }

        public string Wif {
            get {
                var privateKey = Private.FromHexString();

                if (privateKey[0] != 0x80)
                    privateKey = ("80" + privateKey.ToHexString() + "01").FromHexString();

                var hash = privateKey.ToSHA256();
                var reHash = hash.ToSHA256();

                return
                    Base58Helper.Encode(
                        (privateKey.ToHexString() + reHash.ToHexString().Substring(0, 8)).FromHexString());
            }
        }

        public AddressInfo() {
        }

        public AddressInfo(string address, string priv, string pub) {
            Address = address;
            Private = priv;
            Public = pub;
        }
    }
}
