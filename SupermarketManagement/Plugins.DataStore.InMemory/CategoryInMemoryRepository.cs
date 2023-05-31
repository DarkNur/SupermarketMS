using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private HashSet<Category> categories;
        private int lastCategoryId;

        public CategoryInMemoryRepository()
        {
            lastCategoryId = 0;
            categories = new HashSet<Category>(capacity: 3)
            {
                new Category { CategoryId = GenerateNextCategoryId(), Name = "Beverage", Description = "Beverage" },
                new Category { CategoryId = GenerateNextCategoryId(), Name = "Bakery", Description = "Bakery" },
                new Category { CategoryId = GenerateNextCategoryId(), Name = "Meat", Description = "Meat" },
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            category.CategoryId = GenerateNextCategoryId();
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public void DeleteCategory(int categoryId)
        {
            var categoryToDelete = GetCategoryById(categoryId);
            if (categoryToDelete != null)
            {
                categories.Remove(categoryToDelete);
            }
        }

        private int GenerateNextCategoryId()
        {
            lastCategoryId++;
            return lastCategoryId;
        }
    }
}

