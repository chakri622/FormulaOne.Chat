﻿using FormulaOne.Chat.Models;
using System.Collections.Concurrent;

namespace FormulaOne.Chat.DataService
{
    public class SharedDb
    {
        private readonly ConcurrentDictionary<string, UserConnection> _connections=new ConcurrentDictionary<string, UserConnection>();

        public ConcurrentDictionary<string, UserConnection>  connections => _connections;
    }
}
