using ToiletFinder3000.Model;
using ToiletFinder3000.Repository;

namespace ToiletFinder3000
{
    public class ToiletService
    {


        private readonly IToiletRepository _toiletRepository;

        public ToiletService(IToiletRepository repo)
        {
            _toiletRepository = repo;
        }



        public List<Toilet> GetAll()
        {
            return _toiletRepository.GetAll();
        }


        public void Add(Toilet toilet) { 
          _toiletRepository.Add(toilet);
        }

        public Toilet GetToilet(int id)
        {
            return _toiletRepository.GetById(id);
        }
    }
}
