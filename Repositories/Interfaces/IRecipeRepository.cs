using New_Recipe_API.Models;

namespace New_Recipe_API.Repositories.Interfaces
{
    public interface IRecipeRepository
    {
        Recipe Add(Recipe recipe);
        Recipe Delete(int id);
        Recipe Edit(int id, Recipe data);
        IEnumerable<Recipe> GetAll(string? tag = null);
        Recipe GetById(int id);
    }
}