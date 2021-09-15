using System.Collections.Generic;

namespace Store.controllers.icontroller
{
    public interface IController<T>
    {

        void insert(T o);

        T getById(long id);

        List<T> getAll();

        void deleteById(long id);

        void updateName(long id, string name);

        void updateAll(long id, T o);
    }
}
