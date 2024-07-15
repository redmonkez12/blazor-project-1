namespace Crypto.Models;

public class CategoriesRepository
{
    private static List<Category> _categories = [
        new Category { Name = "Bitcoin Ecosystem"},
        new Category { Name = "Ethereum Ecosystem"},
        new Category { Name = "Polkadot Ecosystem"},
        new Category { Name = "Cosmos Ecosystem"},
    ];
    
    public static List<Category> GetCategories() => _categories;
}