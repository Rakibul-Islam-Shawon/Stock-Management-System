using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SMS.Repository;
using SMS.Models;

namespace SMS.Bll
{
    public class CategorySetupManager
    {
        CategorySetupRepo _categorySetup = new CategorySetupRepo();

        public void SaveCategory(Category category)
        {
            _categorySetup.SaveCategory(category);
        }

        public DataTable ShowCategory()
        {
            return _categorySetup.ShowCategory();
        }
    }
}
