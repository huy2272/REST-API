using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using projectAPI.Models;

namespace projectAPI.Controllers
{
    public class QuotesController : ApiController
    {
        static List<Quote> _quotes = new List<Quote>()
        {
            new Quote()
            {
                Id = 0, Author = "Einstein", Description = "Imagination is more important than knowledge",
                Title = "Imagination"
            },
            new Quote()
            {
                Id = 1, Author = "Einstein", Description = "Imagination is more important than knowledge",
                Title = "Imagination"
            },
        };

        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

        public void Post(Quote quote)
        {
            _quotes.Add(quote);
        }
    }
}
