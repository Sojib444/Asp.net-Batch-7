namespace Assignment_4
{
    public interface Iorm<G, T> where T:class, IGuid<G>
    {
        void Insert(T item);
        void Update(T item);
        //void Delete(T item);
        //void Delete(G id);
        //void GetById(G id);
        //void GetAll();
    }
}