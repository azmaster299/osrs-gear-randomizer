using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace OSRSGearRandomizer
{
    public class Item
    {
        [JsonProperty("_id")]
        public string UniqueId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("incomplete")]
        public bool Incomplete { get; set; }

        [JsonProperty("members")]
        public bool Members { get; set; }

        [JsonProperty("tradeable")]
        public bool Tradeable { get; set; }

        [JsonProperty("tradeable_on_ge")]
        public bool TradeableOnGe { get; set; }

        [JsonProperty("stackable")]
        public bool Stackable { get; set; }

        [JsonProperty("stacked")]
        public object Stacked { get; set; }

        [JsonProperty("noted")]
        public bool Noted { get; set; }

        [JsonProperty("noteable")]
        public bool Noteable { get; set; }

        [JsonProperty("linked_id_item")]
        public object LinkedIdItem { get; set; }

        [JsonProperty("linked_id_noted")]
        public int? LinkedIdNoted { get; set; }

        [JsonProperty("linked_id_placeholder")]
        public int? LinkedIdPlaceholder { get; set; }

        [JsonProperty("placeholder")]
        public bool Placeholder { get; set; }

        [JsonProperty("equipable")]
        public bool Equipable { get; set; }

        [JsonProperty("equipable_by_player")]
        public bool EquipableByPlayer { get; set; }

        [JsonProperty("equipable_weapon")]
        public bool EquipableWeapon { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("lowalch")]
        public int? Lowalch { get; set; }

        [JsonProperty("highalch")]
        public int? Highalch { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("buy_limit")]
        public int? BuyLimit { get; set; }

        [JsonProperty("quest_item")]
        public bool QuestItem { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("duplicate")]
        public bool Duplicate { get; set; }

        [JsonProperty("examine")]
        public string Examine { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("wiki_name")]
        public string WikiName { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("wiki_exchange")]
        public string WikiExchange { get; set; }

        [JsonProperty("equipment")]
        public Equipment Equipment { get; set; }

        [JsonProperty("weapon")]
        public Weapon Weapon { get; set; }

        [JsonProperty("_created")]
        public string Created { get; set; }

        [JsonProperty("_updated")]
        public string Updated { get; set; }

        [JsonProperty("_etag")]
        public string Etag { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        public BitmapImage Picture
        {
            get {
                if (!string.IsNullOrEmpty(this.Icon))
                {
                    byte[] binaryData = Convert.FromBase64String(this.Icon);

                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.StreamSource = new MemoryStream(binaryData);
                    bi.EndInit();
                    return bi;
                }
                else
                    return null;
            }
        }
    }

    public class PropertyAndValue
    {
        public PropertyAndValue(string Property, string Value)
        {
            this.Property = Property;
            this.Value = Value;
        }

        public string Property { get; set; }
        public string Value { get; set; }
    }
}
