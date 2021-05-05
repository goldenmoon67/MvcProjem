using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BussinesLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryDescription == "" || p.CategoryName.Length <= 3)
            {
                //hata mesajı ver//
            }
            else
            {
                repo.insert(p);
            }
        }
    }
}
