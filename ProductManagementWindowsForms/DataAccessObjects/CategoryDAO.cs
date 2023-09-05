﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            List<Category> listCategories = new List<Category>();
            try
            {
                using (var context = new MyStoreContext())
                {
                    listCategories = context.Categories.ToList();
                }

                }catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return listCategories;
        }
    }
}
