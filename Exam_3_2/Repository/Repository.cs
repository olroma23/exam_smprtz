using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Exam_3_2.Repository
{
    public class Repository<TEntity> where TEntity : class
    {
        internal Context context;
        internal DbSet<TEntity> dbSet;


    }
}
