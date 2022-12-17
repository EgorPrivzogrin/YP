using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Hrreport
    {
        private List<Employment> employments;

        public List<Employment> Employments
        {
            get { return employments; }
            set { employments = value; }
        }

        public Hrreport()
        {
            Employments = new List<Employment>();
        }

        public Hrreport(List<Employment> employments)
        {
            this.employments = employments;
        }
    }
}
