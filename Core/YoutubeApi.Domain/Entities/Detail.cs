using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Domain.Entities
{
    public class Detail: EntityBase
    {
        public Detail()
        {

        }

        public Detail(string title, string description,int categoryId)
        {
            Title = title;
            Description = description;
            categoryId = categoryId;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public   MyProperty { get; set; }

    }
}
