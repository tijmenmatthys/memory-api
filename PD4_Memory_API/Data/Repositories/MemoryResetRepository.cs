using PD4_Memory_API.Data.Models;

namespace PD4_Memory_API.Data.Repositories
{
    public class MemoryResetRepository : RepositoryBase
    {

        internal IEnumerable<MemoryReset> Get()
        {
            Pd4Context context = new Pd4Context();
            return context.MemoryResets;
        }

        internal MemoryReset Add(MemoryReset memoryReset)
        {
            Pd4Context context = new Pd4Context();
            context.MemoryResets.Add(memoryReset);
            context.SaveChanges();
            return memoryReset;
        }

        internal MemoryReset Update(MemoryReset memoryReset)
        {
            Pd4Context context = new Pd4Context();
            context.MemoryResets.Update(memoryReset);
            context.SaveChanges();
            return memoryReset;
        }

        internal void Delete(int id)
        {
            Pd4Context context = new Pd4Context();
            var result = context.MemoryResets
                .Where(a => a.Id == id);
            if (result.Count() == 0) return;

            context.Entry(result.First()).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
