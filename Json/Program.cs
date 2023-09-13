using System;
using System.Text.Json;

namespace Json
{


    class Program
    {

        static void Main(string[] args) {

            Beer myBerr = new Beer()
            {
                Name="pilsem",
                Brand ="backus"
            };

           // string json = "{\"Name\":\"pilsen\",\"Brand\":\"backus\"}";

            string json =JsonSerializer.Serialize(myBerr);

            Beer beer = JsonSerializer.Deserialize<Beer>(json);


            Beer[] beers = new Beer[] {
                new Beer(){
                 Name="pilsem",
                Brand ="backus"
                },
                  new Beer(){
                 Name="cristal",
                Brand ="backus"
                },
            };

            // string json2 = "["+"{\"Name\":\"pilsen\",\"Brand\":\"backus\"}\",\"{\"Name\":\"cristal\",\"Brand\":\"backus\"}"+"]";

            string json2 = JsonSerializer.Serialize(beers);
            Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);

        }

    }

    public class Beer {

        public string Name { get; set; }
        public string Brand { get; set; }
    
    };

}