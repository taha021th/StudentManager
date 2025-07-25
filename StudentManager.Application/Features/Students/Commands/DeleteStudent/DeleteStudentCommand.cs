﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Application.Features.Students.Commands.DeleteStudent
{
    public class DeleteStudentCommand : IRequest
    {
        public int Id { get; set; }
    }
}
