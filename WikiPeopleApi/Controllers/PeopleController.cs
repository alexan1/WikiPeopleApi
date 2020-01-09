using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WikiPeopleApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetDetail([FromRoute] int key)
        {

            const string imageBase = "https://commons.wikimedia.org/wiki/Special:FilePath/";
            const string linkBase = "https://en.wikipedia.org/wiki/";
            const string urlBase = "https://www.wikidata.org/w/api.php?action=wbgetentities&ids=";
            const string urlOptions = "&format=json&languages=en&props=labels|descriptions|claims";
            var itemID = "Q" + key.ToString();
            var url = urlBase + itemID + urlOptions;
            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.88 Safari/537.36");
            var json = await client.GetStringAsync(url);
            var results = JsonDocument.Parse(json);
            int a = 0;
            /*
            var entities = results["entities"]?[itemID];
            var name = entities["labels"]["en"]["value"].ToString();

            var description1 = String.Empty;
            var description = entities["descriptions"];
            if (description != null)
            {
                description1 = description["en"]?["value"]?.ToString();
            }

            DateTime birthday1 = DateTime.MinValue;
            DateTime? birthday2 = null;
            var birthday = entities["claims"]["P569"];
            if (birthday != null)
            {
                var birth = birthday[0]?["mainsnak"]?["datavalue"]?["value"]?["time"];
                if (birth != null)
                {
                    birthday2 = DateTime.TryParse(birth.ToString().Substring(1), out birthday1) ? birthday1 : birthday2;
                }
            }

            DateTime death1 = DateTime.MinValue;
            DateTime? death2 = null;
            var death = entities["claims"]["P570"];
            if (death != null)
            {
                death2 = DateTime.TryParse(death[0]["mainsnak"]["datavalue"]["value"]["time"].ToString().Substring(1), out death1) ? death1 : DateTime.MinValue;
            }

            var link1 = entities["claims"]?["P373"]?[0]["mainsnak"]?["datavalue"]?["value"];
            var link = String.Empty;
            if (link1 != null)
            {
                link = System.Net.WebUtility.HtmlEncode(link1.ToString().Replace(" ", "_"));
            }
            var image1 = String.Empty;
            var imageLink = String.Empty;
            var image = entities["claims"]["P18"];
            if (image != null)
            {
                image1 = image[0]["mainsnak"]["datavalue"]["value"].ToString();
                imageLink = imageBase + image1;
            }

            var rating = await getRatingAsync(key);

            var person = new PersonViewModel()
            {
                ID = key,
                Name = name,
                Description = description1,
                Birthday = birthday2,
                Death = death2,
                Image = imageLink,
                Link = linkBase + link,
                Rating = rating
            };
            */
            //return person;
            return Ok(0);

        }
    }
}