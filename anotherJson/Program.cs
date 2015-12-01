using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Include for json
using System.IO;
using Newtonsoft.Json;

namespace anotherJson
{
    
    class Person
    {
        public string client { get; set; }
        [JsonProperty("job-number")]
        public string jobNumber { get; set; }
		[JsonProperty("job-name")]
        public string jobName { get; set; }
		public string due { get; set; }
        public string status { get; set; }

        public override string ToString()
        {
            return string.Format("Client: {0} \nJob Number: {1} \nJob Name: {2} \nDue: {3} \nStatus: {4} \n", client, jobNumber, jobName, due, status);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            String JSONstring = File.ReadAllText("jobs.json");
            Person p1 = JsonConvert.DeserializeObject<Person>(JSONstring);            
            Console.Write(p1);
        }
    }
}



