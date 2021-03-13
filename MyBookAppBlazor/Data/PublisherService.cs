using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookAppBlazor.Data
{
    public class PublisherService: IPublisherService
    {
        public DateTime CreationDate { get; set; }
        public List<Publisher> Publishers { get; set; }

        public PublisherService()
        {
            CreationDate = DateTime.Now;

            Publishers = new List<Publisher>();

            Publishers.Add(new Publisher("172-32-1176", "Menlo Park", "johnson.white@gmail.com"));
            Publishers.Add(new Publisher("213-65-8765", "Oakland", "marjoe.white@gmail.com"));
            Publishers.Add(new Publisher("223-87-7654", "Berkely", "cher.white@gmail.com"));
            Publishers.Add(new Publisher("543-65-3425", "San jose", "mich.white@gmail.com"));
            Publishers.Add(new Publisher("142-43-6576", "Oakland", "dean.white@gmail.com"));

        }

        public List<Publisher> GetPublishers()
        {
            return Publishers;
        }
        public Publisher GetPublisherById(string pubId)
        {
            return Publishers.Where(pub => pub.PublisherId == pubId).FirstOrDefault();
        }

        public DateTime GetCreateDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "V1";
        }

        public bool SavePublisher(Publisher pub)
        {
            Publishers.Add(pub);
            return true;
        }
    }
}
