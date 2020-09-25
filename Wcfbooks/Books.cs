using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using booksdal;
 
namespace Wcfbooks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Books : IBooks
    {
        public book findbycode(string bookcode)
        {
            booksdallayer dal = new booksdallayer();
          book b= dal.findbycode(bookcode);
            return b;
        }

        

       
    }
}
