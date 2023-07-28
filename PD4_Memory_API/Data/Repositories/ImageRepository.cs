using PD4_Memory_API.Data.Models;

namespace PD4_Memory_API.Data.Repositories
{
    public class ImageRepository : RepositoryBase
    {
        private string _currentTheme = "Flowers";

        internal IEnumerable<Image> GetAll()
        {
            Pd4Context context = new Pd4Context();
            return context.Images;
        }

        internal IEnumerable<int> GetIdsFront()
        {
            Pd4Context context = new Pd4Context();
            return context.Images
                .Where(a => a.Theme == _currentTheme && a.IsBack == false)
                .Select(a => a.Id)
                .ToArray();
        }

        internal int GetIdBack()
        {
            Pd4Context context = new Pd4Context();
            return context.Images
                .Where(a => a.Theme == _currentTheme && a.IsBack == true)
                .Select(a => a.Id)
                .FirstOrDefault();
        }

        //internal Image GetById(int id)
        //{
        //    Pd4Context context = new Pd4Context();
        //    var result = context.Images
        //        .Where(a => a.Id == id);
        //    if (result.Count() == 0)
        //        return null;
        //    return result.First();
        //}

        internal byte[] GetById(int id, out string contentType)
        {
            Pd4Context context = new Pd4Context();
            Image image = context.Images
                .Where(a => a.Id == id)
                .First();

            contentType = "image/" + image.Extention.Trim('.');
            return image.Image1;
        }

        internal Image[] GetByTheme(string theme)
        {
            Pd4Context context = new Pd4Context();
            return context.Images
                .Where(a => a.Theme == theme)
                .ToArray();
        }

        internal Image GetByName(string name)
        {
            Pd4Context context = new Pd4Context();
            var result = context.Images
                .Where(a => a.Name == name);
            if (result.Count() == 0)
                return null;
            return result.First();
        }
        internal Image Add(Image image)
        {
            Pd4Context context = new Pd4Context();
            context.Images.Add(image);
            context.SaveChanges();
            return image;
        }

        internal Image Update(Image image)
        {
            Pd4Context context = new Pd4Context();
            context.Images.Update(image);
            context.SaveChanges();
            return image;
        }

        internal void Delete(int id)
        {
            Pd4Context context = new Pd4Context();
            var result = context.Images
                .Where(a => a.Id == id);
            if (result.Count() == 0) return;

            context.Entry(result.First()).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
