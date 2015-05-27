using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService;


namespace WCF_SOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ToDo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ToDo.svc or ToDo.svc.cs at the Solution Explorer and start debugging.
    public class ToDo : IToDo
    {
        private static Dictionary<Guid, ToDoItem> _todos = new Dictionary<Guid, ToDoItem>();

        public List<ToDoItem> GetToDos()
        {
            var crud = new CRUD();
            var result = crud.SelectAll();
            foreach (var item in result)
            {
                AddOrUpdateToDo(new ToDoItem() { Id = item.PersonID, FirstName = item.FirstName, LastName = item.LastName });
            }
            return _todos.Values.ToList();
        }

        public void AddOrUpdateToDo(ToDoItem toDoItem)
        {
            _todos.Add(Guid.NewGuid(), toDoItem);
            //_todos[toDoItem.Id] = toDoItem;
        }

        public void DeleteToDo(ToDoItem toDoItem)
        {
            //if (_todos.ContainsKey(toDoItem.Id))
            //    _todos.Remove(toDoItem.Id);
            //else
            //    throw new FaultException("ID not found: " + toDoItem.Id);
        }
    }
}
