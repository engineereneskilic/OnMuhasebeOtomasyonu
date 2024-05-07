using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BusinessLayer
{
    public abstract class db_operation
    {
        public abstract void List(DataGridView coming_datagridview);
        public abstract void Insert_Update();
        public abstract void Delete(int _Id);

        public abstract DataTable Query(int id);

        public abstract int TableRowCount();
    }
}
