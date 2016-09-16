﻿namespace DbAndRepository.Repostirories
{
    using DbAndRepository.IRepositories;
    using System.Linq;
    using System.Data.Entity;

    class NewTechWorksRepository : GenericsEFRepository.GenericsRepository<NewTechWorks>, INewTechWorksRepository
    {
        private NewTechWorks ntw;

        public NewTechWorksRepository(DbContext newDb) : base(newDb)
        {
        }

        public override void Delete(int id)
        {
            ntw = GetById(id);
            database.Set<NewTechWorks>().Remove(ntw);
            database.Entry<NewTechWorks>(ntw).State = EntityState.Deleted;
            database.SaveChanges();
        }

        public override NewTechWorks GetById(int id)
        {
            return Get(i => i.ID == id).FirstOrDefault();
        }

        public override void Update(NewTechWorks entityToModify)
        {
            database.Entry(GetById(entityToModify.ID)).CurrentValues.SetValues(entityToModify);
            database.Entry<NewTechWorks>(entityToModify).State = EntityState.Modified;
            database.SaveChanges();
        }
    }
}