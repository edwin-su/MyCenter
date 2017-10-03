﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCenter.Utilities
{
    public interface ICache
    {
        bool Contains(string key);

        T Get<T>(string key);

        bool TryGet<T>(string key, out T source);

        void Add<T>(string key, T source);

        void Remove(string key);
    }
}