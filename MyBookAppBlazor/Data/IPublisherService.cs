using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookAppBlazor.Data
{
    public interface IPublisherService
    {
        List<Publisher> GetPublishers();
        Publisher GetPublisherById(string pubId);
        DateTime GetCreateDate();
        string GetVersion();
        bool SavePublisher(Publisher publisher);
    }
}
