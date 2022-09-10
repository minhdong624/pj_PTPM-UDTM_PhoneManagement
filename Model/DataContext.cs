using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class DataContext:DbContext
    {
        public DataContext(string connectionstring) : base(connectionstring)
        { }
    }
}
