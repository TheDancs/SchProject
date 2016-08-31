﻿namespace DbAndRepository.Repostirories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using DbAndRepository.GenericsEFRepository;
    using DbAndRepository.IRepositories;
    using System.Windows.Media.Imaging;
    using System.Windows.Media;

    public class RegUserRepository : GenericsRepository<RegUser>, IRegUserRepository
    {
        private RegUser user;

        public RegUserRepository(DbContext newDb) : base(newDb)
        {
        }

        public bool Autenthicate(string userName, string password)
        {
            user = Get(i => i.Username == userName && i.Password == password).FirstOrDefault();
            if (user == null)
                return false;
            return true;
        }

        public override void Delete(int id)
        {
            user = GetById(id);
            database.Set<RegUser>().Remove(user);
            database.Entry<RegUser>(user).State = EntityState.Deleted;
            database.SaveChanges();
        }

        public override RegUser GetById(int id)
        {
            return database.Set<RegUser>().FirstOrDefault(i => i.ID == id);
        }

        public BitmapImage GetPicture(string userName)
        {
            return (BitmapImage)new ImageSourceConverter().
                ConvertFrom((Get(i => i.Username == userName).FirstOrDefault().Picture));
        }

        public override void Update(RegUser entityToModify)
        {
            database.Entry(GetById(entityToModify.ID)).CurrentValues.SetValues(entityToModify);
            database.Entry<RegUser>(entityToModify).State = EntityState.Modified;
            database.SaveChanges();
        }
    }
}
