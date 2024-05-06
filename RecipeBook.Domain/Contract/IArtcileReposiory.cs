﻿using RecipeBook.Domain.Contract.Common;
using RecipeBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Domain.Contract
{
	public interface IArtcileReposiory : IAsyncRepository<Article>
	{
	}
}