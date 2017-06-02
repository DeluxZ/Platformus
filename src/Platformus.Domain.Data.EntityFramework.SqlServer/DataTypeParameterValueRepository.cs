﻿// Copyright © 2017 Dmitry Yegorov. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ExtCore.Data.EntityFramework.SqlServer;
using Platformus.Domain.Data.Abstractions;
using Platformus.Domain.Data.Models;

namespace Platformus.Domain.Data.EntityFramework.SqlServer
{
  public class DataTypeParameterValueRepository : RepositoryBase<DataTypeParameterValue>, IDataTypeParameterValueRepository
  {
    public void Create(DataTypeParameterValue dataTypeParameterValue)
    {
      this.dbSet.Add(dataTypeParameterValue);
    }
  }
}