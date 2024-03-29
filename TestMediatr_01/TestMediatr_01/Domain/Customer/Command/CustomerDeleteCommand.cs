﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMdiatr_01.Domain.Customer.Command
{
    public class CustomerDeleteCommand : IRequest<string>
    {
        public int Id { get; set; }
    }
}
