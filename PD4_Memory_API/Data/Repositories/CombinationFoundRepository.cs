using PD4_Memory_API.Data.Models;

namespace PD4_Memory_API.Data.Repositories
{
    public class CombinationFoundRepository : RepositoryBase
    {

        internal IEnumerable<CombinationFound> Get()
        {
            Pd4Context context = new Pd4Context();
            return context.CombinationFounds;
        }

        internal CombinationFound Add(CombinationFound combinationFound)
        {
            Pd4Context context = new Pd4Context();
            context.CombinationFounds.Add(combinationFound);
            context.SaveChanges();
            return combinationFound;
        }

        internal CombinationFound Update(CombinationFound combinationFound)
        {
            Pd4Context context = new Pd4Context();
            context.CombinationFounds.Update(combinationFound);
            context.SaveChanges();
            return combinationFound;
        }

        internal void Delete(int id)
        {
            Pd4Context context = new Pd4Context();
            var result = context.CombinationFounds
                .Where(a => a.Id == id);
            if (result.Count() == 0) return;

            context.Entry(result.First()).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
