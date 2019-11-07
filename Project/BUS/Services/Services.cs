//using BUS.UnitofWork;
//using DAO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace BUS
//{
//    public class Services<T> : ISevervices<T> where T : class
//    {
//        private readonly IUnitofwork unitofwork;
//        public Services(IUnitofwork unitOfWork)
//        {
//            unitofwork = unitOfWork;
//        }
//        public void Delete(T entity)
//        {
//            unitofwork.// thấy thêm cái service kiểu này phức tạp hơn mak đồ án mình quá nhỏ
                
//        }

//        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
//        {
//        }

//        public IEnumerable<T> GetAll()
//        {
//        }

//        public T GetById(int id)
//        {
//        }

//        public void Insert(T entity)
//        {
//        }

//        public void Update(T entity)
//        {
//            throw new NotImplementedException();
//        }



//        //static Context context;
//        //static IRepository<T> repository;
//        //static Services()
//        //{
//        //    context = new Context();
//        //    repository = new Repository<T>(context);
//        //}
//        //public void Delete(T entity)
//        //{
//        //    repository.Delete(entity);
//        //}

//        //public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
//        //{
//        //    return repository.Find(predicate);
//        //}

//        //public IEnumerable<T> GetAll()
//        //{
//        //    return repository.GetAll();
//        //}

//        //public T GetById(int id)
//        //{
//        //    return repository.GetById(id);
//        //}

//        //public void Insert(T entity)
//        //{
//        //    repository.Insert(entity);
//        //}

//        //public void Update(T entity)
//        //{
//        //    repository.Update(entity);
//        //}
//    }
//}
