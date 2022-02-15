﻿using AppCore.Business.Models.Results;
using AppCore.Records;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AppCore.Business.Services.Base
{
    public interface IService<TModel> : IDisposable where TModel : Record, new()
    {
        IQueryable<TModel> Query(Expression<Func<TModel, bool>> predicate = null);
        Result Add(TModel model);
        Result Update(TModel model);
        Result Delete(string guId);
    }
}
