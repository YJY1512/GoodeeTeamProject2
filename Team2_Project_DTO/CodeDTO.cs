using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Project_DTO
{
    public class CodeDTO
    {
        public string Code { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Pcode { get; set; }
    }

    public class CommonPop<T>
    {
        public List<T> DgvDatasource { get; set; }
        public List<DataGridViewTextBoxColumn> DgvCols { get; set; }
        public string PopName { get; set; }

    }

    
}
