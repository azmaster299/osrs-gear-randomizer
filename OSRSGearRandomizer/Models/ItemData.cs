using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace OSRSGearRandomizer
{
    public static class ItemData
    {
        public static string ItemDataFilePath
        {
            get
            {
                return Directory.GetCurrentDirectory() + "/Resources/equipment.json";
            }
        }

        public static List<Item> Get
        {
            get
            {
                return JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(ItemDataFilePath));
            }
        }

        public static async void Update(DownloadingWindow window)
        {
            const string BaseUrl = "https://api.osrsbox.com/";
            window.lblDownloadingProgess.Content = "Attempting Download from \n" + BaseUrl;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            JArray itemArray = new JArray();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(BaseUrl + "equipment?max_results=50");
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    JObject parentObj = JObject.Parse(jsonString);
                    foreach (JObject itemObj in parentObj.SelectToken("_items"))
                    {
                        itemArray.Add(itemObj);
                    }
                    JToken nextPageToken = parentObj.SelectToken("_links").SelectToken("next");
                    int metaTotal = parentObj.SelectToken("_meta").Value<int>("total");

                    if (nextPageToken != null)
                    {
                        string nextPageUri = nextPageToken.Value<string>("href");
                        JToken lastPageToken = parentObj.SelectToken("_links").SelectToken("last");
                        string finalUri = lastPageToken.Value<string>("href");
                        while (nextPageUri != finalUri)
                        {
                            response = await client.GetAsync(BaseUrl + nextPageUri);
                            jsonString = await response.Content.ReadAsStringAsync();
                            parentObj = JObject.Parse(jsonString);
                            foreach (JObject itemObj in parentObj.SelectToken("_items"))
                            {
                                itemArray.Add(itemObj);
                            }
                            nextPageToken = parentObj.SelectToken("_links").SelectToken("next");
                            nextPageUri = nextPageToken.Value<string>("href");
                            window.lblDownloadingProgess.Content = "Downloading: " + itemArray.Count + " / " + metaTotal.ToString();
                        }
                    }

                    window.lblDownloadingProgess.Content = "Download Complete.";
                    window.btnClose.Visibility = Visibility.Visible;
                    StreamWriter writer = File.CreateText(ItemDataFilePath);
                    writer.Write(itemArray.ToString());
                    writer.Close();
                    writer.Dispose();
                } catch (Exception e)
                {
                    window.lblDownloadingProgess.Content = e.Message;
                    MessageBox.Show("Unable to update item data.\n" + e.Message);
                    window.btnClose.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
