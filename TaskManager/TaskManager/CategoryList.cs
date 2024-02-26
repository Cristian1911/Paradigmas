using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class CategoryList
    {
        public static List<string> Categories;
        static CategoryList()
        {
            CategoryList.Categories = new List<string>();
            CategoryList.Categories.Add("Default Category");
        }
        public static void GetCategoryList()
        {
            Console.WriteLine("Categorías existentes:");
            for (int i = 0; i < CategoryList.Categories.Count; i++)
            {
                Console.WriteLine($"{i+1}. {CategoryList.Categories[i]}");
            }
        }
        public static void CreateCategory(string name)
        {
            CategoryList.Categories.Add(name);
        }
    }
}
