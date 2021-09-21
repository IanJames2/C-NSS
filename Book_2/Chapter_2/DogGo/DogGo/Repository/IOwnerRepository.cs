﻿using System;
using System.Collections.Generic;
using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repository
{
    interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
    }
}
