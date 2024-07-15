namespace Crypto.Models;

public class CategoriesRepository
{
    private static List<Category> _categories = [
        new Category { CategoryId = 1, Name = "Bitcoin Ecosystem"},
        new Category { CategoryId = 2, Name = "Ethereum Ecosystem"},
        new Category { CategoryId = 3, Name = "Polkadot Ecosystem"},
        new Category { CategoryId = 4, Name = "Cosmos Ecosystem"},
    ];
    
    public static List<Category> GetCategories() => _categories;
}