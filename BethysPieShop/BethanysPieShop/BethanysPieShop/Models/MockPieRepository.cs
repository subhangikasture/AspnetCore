namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId=1, Name="Strawberry Pie", Price=15.95M, ShortDescription="Our famous strawberry pie!", LongDescription="Icing carrot cake jelly-o", CategoryId=1, ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, IsPieOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"},
                new Pie{PieId=2, Name="Cheese Cake", Price=18.95M, ShortDescription="Plain cheese cake. Plain pleasure.", LongDescription="Cheesecake jelly beans apple pie", CategoryId=2, ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Pie{PieId=3, Name="Rhubarb Pie", Price=15.95M, ShortDescription="A summer classic!", LongDescription="Rhubarb pie jelly beans apple pie", CategoryId=1, ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
            };

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AllPies.Where(p => p.IsPieOfTheWeek);
            }
        }
        public Pie? GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }

        public IEnumerable<Pie> SearchPie(string searchQuery)
        {

            throw new NotImplementedException();
        }

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
