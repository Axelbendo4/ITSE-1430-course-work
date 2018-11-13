﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public interface IMessageServices
    {
        void Send( Message message );

        IEnumerable<Message> GetAllCore();





    }
}

