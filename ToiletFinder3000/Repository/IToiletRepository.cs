using ToiletFinder3000.Model;

namespace ToiletFinder3000.Repository
{

    /**Interface for handling toilets*/
    public interface IToiletRepository
    {

        public List<Toilet> GetAll();
        
        public Toilet GetById(int id);

        public void Update(Toilet toilet);

        public void Add(Toilet toilet);

        public void Delete(int id);

        public List<Toilet> Search(string criteria);




    }
}
