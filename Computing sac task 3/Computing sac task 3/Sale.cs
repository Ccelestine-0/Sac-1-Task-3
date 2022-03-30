using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computing_sac_task_3
{
    internal class Sale
    {
        //grabbing the columns from the csv file
        public string Textbook {  get; set; }
        public string Subject { get; set; }
        public float PurchasePrice { get; set; }
        public string SalePrice { get; set; }
        public string Rating { get; set; }

    }
}
