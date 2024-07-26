using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlaynrestoran
{
    public class User
    {
        public int id {  get; set; }
        public string name {  get; set; }
        public string buyurtma {  get; set; }
        public string Info {  get; set; }
        private List<Information> info = new List<Information>();
        private List<order> ord = new List<order>();
    }
}
