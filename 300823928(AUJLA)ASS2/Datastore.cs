using Google.Cloud.Datastore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300823928_AUJLA_ASS2
{
    class Datastore
    {

        
        private readonly DatastoreDb _db;
        private readonly KeyFactory _keyFactory;
        //  Adds a task entity to the Datastore
        // <param name="description">The taskdescription.</param>
        // <returns>The key of the entity.</returns>

        public Datastore() { 
        // Create an authorized Datastore service using Application Default Credentials.
        _db = DatastoreDb.Create("myproject45644");
        // Create a Key factory to construct keys associated with this project.
        _keyFactory = _db.CreateKeyFactory("Task");
          }


        public Key AddTask(string description)
        {
            Entity task = new Entity()
            {
                Key = _keyFactory.CreateIncompleteKey(),
                ["description"] = new Value()
                {
                    StringValue = description,
                    ExcludeFromIndexes = true
                },
                ["created"] = DateTime.UtcNow,
                ["CreateBy"] = "Amandeep Aujla",
                ["done"] = false
            };
            return _db.Insert(task);
        }

        // Marks a task entity as done.
        // <param name="id">The ID of the task entity as given by Key.</param>
        // <returns>true if the task was found.</returns>
        public bool MarkDone(long id)
        {
            using (var transaction = _db.BeginTransaction())
            {
                Entity task = transaction.Lookup(_keyFactory.CreateKey(id));
                if (task != null)
                {
                    task["done"] = true;
                    transaction.Update(task);
                }
                transaction.Commit();
                return task != null;
            }
        }


        // Deletes a task entity.
        // <param name="id">The ID of the task entity as given by Key.</param>
        public void DeleteTask(long id)
        {
            _db.Delete(_keyFactory.CreateKey(id));
        }

       
        // Returns a list of all task entities in ascending order of creation time.

        IEnumerable<Entity> ListTasks()
        {
            Query query = new Query("Task")
            {
                Order = { { "created", PropertyOrder.Types.Direction.Descending } }
            };
            return _db.RunQuery(query).Entities;
        }

        //Amandeep Aujla: added method to modify Task
        public bool modifyTask(long id, string description)
        {
            using (var transaction = _db.BeginTransaction())
            {
                Entity task = transaction.Lookup(_keyFactory.CreateKey(id));
                if (task != null)
                {
                    task["description"] = description;
                    transaction.Update(task);
                }
                transaction.Commit();
                return task != null;

            }
        }

    }
}
