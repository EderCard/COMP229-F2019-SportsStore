﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace COMP229_F2019_SportsStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue
            ? $"{request.Path}{request.QueryString}"
            : request.Path.ToString();
    }
}